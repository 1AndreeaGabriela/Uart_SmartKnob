#include "LPUART_S32K11x.h"

#include <S32K118.h>
#include <cstdint>
#include <stdbool.h>
#include<string.h>
//#define PCR_MUX_POS 8        								/* Position of MUX bits in the PCR register */
//#define PCR_MUX_MASK (0x7 << PCR_MUX_POS)  					/* Mask for clearing the MUX bits */


void LPUART0_init(void)  									/* Init : 19200 baud, 1 stop bit, 8 bit format, no parity */
{
	PCC->PCCn[PCC_LPUART0_INDEX] &= ~PCC_PCCn_CGC_MASK;     /* Ensure clk disabled for config */
	PCC->PCCn[PCC_LPUART0_INDEX] |= PCC_PCCn_PCS(2)    	    /* Clock Src= 1 (SIRCDIV2_CLK) */
								 |  PCC_PCCn_CGC_MASK;      /* Enable clock for LPUART1 regs */

	LPUART0->BAUD = LPUART_BAUD_SBR(0x1A)  				    /* Initialize for 19200 baud, 1 stop: */
                			|LPUART_BAUD_OSR(15);  			/* SBR=26 (0x1A): baud divisor = 8M/19200/16 = ~26 */
															/* OSR=15: Over sampling ratio = 15+1=16 */
															/* SBNS=0: One stop bit */
															/* BOTHEDGE=0: receiver samples only on rising edge */
															/* M10=0: Rx and Tx use 7 to 9 bit data characters */
															/* RESYNCDIS=0: Resync during rec'd data word supported */
															/* LBKDIE, RXEDGIE=0: interrupts disable */
															/* TDMAE, RDMAE, TDMAE=0: DMA requests disabled */
															/* MAEN1, MAEN2,  MATCFG=0: Match disabled */

	LPUART0->CTRL =	LPUART_CTRL_RE_MASK
			|LPUART_CTRL_TE_MASK;   						/* Enable transmitter & receiver, no parity, 8 bit char: */
															/* RE=1: Receiver enabled */
															/* TE=1: Transmitter enabled */
															/* PE,PT=0: No hw parity generation or checking */
															/* M7,M,R8T9,R9T8=0: 8-bit data characters*/
															/* DOZEEN=0: LPUART enabled in Doze mode */
															/* ORIE,NEIE,FEIE,PEIE,TIE,TCIE,RIE,ILIE,MA1IE,MA2IE=0: no IRQ*/
															/* TxDIR=0: TxD pin is input if in single-wire mode */
															/* TXINV=0: TRansmit data not inverted */
															/* RWU,WAKE=0: normal operation; rcvr not in statndby */
															/* IDLCFG=0: one idle character */
															/* ILT=0: Idle char bit count starts after start bit */
															/* SBK=0: Normal transmitter operation - no break char */
															/* LOOPS,RSRC=0: no loop back */

}

/* Init :LPUART0 RX pin -> PTA 2, LPUART0 TX pin -> PTA 3 */
/*!
	 *
	 * Pins definitions
	 * ===================================================
	 *
	 * Pin number        | Function
	 * ----------------- |------------------
	 * PTA2              | LPUART0 RX
	 * PTA3              | LPUART0 TX
	 * ===================================================
*/

void PORT_init_RX_TX (void)
{

	PCC->PCCn[PCC_PORTA_INDEX]|=PCC_PCCn_CGC_MASK;		/* Enable clock for PORT A */

//	PORTA->PCR[2] &= ~PCR_MUX_MASK;
//	PORTA->PCR[2] |= (6 << PCR_MUX_POS); 				/* Set MUX to ALT 6 for UART RX */
//
//
//	PORTA->PCR[3] &= ~PCR_MUX_MASK;
//	PORTA->PCR[3] |= (6 << PCR_MUX_POS); 				/* Set MUX to ALT 6 for UART TX */

	PORTA->PCR[2] |= PORT_PCR_MUX(6);
	PORTA->PCR[3] |= PORT_PCR_MUX(6);
}
void check_uart_errors(void)
{
	if (LPUART0->STAT & LPUART_STAT_OR_MASK)
	{
		LPUART0->STAT |= LPUART_STAT_OR_MASK;  			/* Reset overrun flag */
	}
	if (LPUART0->STAT & LPUART_STAT_FE_MASK)
	{
		LPUART0->STAT |= LPUART_STAT_FE_MASK;           /* Reset framing flag */
	}
	if (LPUART0->STAT & LPUART_STAT_PF_MASK)
	{
		LPUART0->STAT |= LPUART_STAT_PF_MASK; 			/* Reset parity flag */
	}
	if (LPUART0->STAT & LPUART_STAT_NF_MASK)
	{
		LPUART0->STAT |= LPUART_STAT_NF_MASK; 			/* Reset noise flag */
	}
}

/* Function to transmit single char */
void LPUART0_transmit_char(char send)
{
	/* Wait for transmit buffer to be empty */
	while((LPUART0->STAT & LPUART_STAT_TDRE_MASK)>>LPUART_STAT_TDRE_SHIFT==0);


	LPUART0->DATA=send;              					/* Send data */
}

/* Function to transmit whole string */
void LPUART0_transmit_string(char data_string[])  {
	uint32_t i=0;
	while(data_string[i] != '\0')
	{
		LPUART0_transmit_char(data_string[i]);			/* Send chars one at a time */
		i++;
	}
}

/* Function to receive single char */
char LPUART0_receive_char(void)
{
	char receive;
	check_uart_errors();

	if ((LPUART0->STAT & LPUART_STAT_RDRF_MASK) == 0)
	{
		/* Return '\0' if no data available */
		return '\0';
	}

	/* Wait for received buffer to be full */
	receive = LPUART0->DATA;

	return receive;
}

void LPUART0_receive_string(char* buffer, size_t max_len)
{

	size_t i = 0;
	memset(buffer,'\0',max_len);

	char received_char;

	while (i < max_len - 1) {
		check_uart_errors();
		received_char = LPUART0_receive_char();
		if (received_char == '\0') {
			continue ;
		}

		if (received_char == '\n' || received_char == '\r') {
			break;
		}
		buffer[i++] = received_char;
	}

	buffer[i] = '\0';

    /*Clear RX buffer*/
	LPUART0->FIFO |= LPUART_FIFO_RXFLUSH_MASK;

}

/* Function to echo received char back */
void LPUART0_receive_and_echo_char(void)
{
	char receivedChar = LPUART0_receive_char();
	if (receivedChar != '\0')							/* Receive Char */
	{
		LPUART0_transmit_char(receivedChar);            /* Transmit same char back to the sender */
	}
}

/* Function to echo received string back */
bool LPUART0_echo_string(bool *stop)
{
	char buffer[256];
	LPUART0_receive_string(buffer, sizeof(buffer));    /* Receives a string from UART, non-blocking */
	LPUART0_transmit_string(buffer);                   /* Transmit the received string back */
	LPUART0_transmit_char('\n');

	*stop = false;
	return stop;

}

