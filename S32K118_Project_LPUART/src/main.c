/*
 * Copyright (c) 2014 - 2016, Freescale Semiconductor, Inc.
 * Copyright (c) 2016 - 2018, NXP.
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *
 * 1. Redistributions of source code must retain the above copyright notice,
 *    this list of conditions and the following disclaimer.
 *
 * 2. Redistributions in binary form must reproduce the above copyright notice,
 *    this list of conditions and the following disclaimer in the documentation
 *    and/or other materials provided with the distribution.
 *
 * 3. Neither the name of the copyright holder nor the names of its contributors
 *    may be used to endorse or promote products derived from this software
 *    without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY NXP "AS IS" AND ANY EXPRESSED OR
 * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 * IN NO EVENT SHALL NXP OR ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING
 * IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF
 * THE POSSIBILITY OF SUCH DAMAGE.
 */

/*!
 * Description:
 * ==========================================================================================
 * This example performs a simple UART transfer to a COM port on a PC. FIFOs, interrupts and
 * DMA are not implemented. The Open SDA interface can be used on the evaluation board, where
 * the UART signals are transferred to a USB interface, which can connect to a PC which has a
 * terminal emulation program such as PUTTY, TeraTerm or other software.
 * */

#include <stdbool.h>
#include <stdio.h >
#include <S32K118.h>
#include <cstdint>
#include <cstdio>

#include "clocks_and_modes_S32K11x.h"
#include "LPUART_S32K11x.h"

//#define MAX_STRING_LENGTH 2048  // Definirea dimensiunii maxime a bufferului
//#define MAX_BUFFER_SIZE 2048  // Definirea dimensiunii maxime a bufferului
//char data=0;
//char receivedChar;
//bool dataAvailable;
//char buffer[MAX_BUFFER_SIZE];
//char receivedString[MAX_STRING_LENGTH];  // Buffer to hold the received string
//char copiedString[MAX_BUFFER_SIZE];    // Buffer pentru copia string-ului
//char stringTest[10] = "test3   \n";

bool stop = false;

void WDOG_disable (void)
{
	WDOG->CNT = 0xD928C520;     /* Unlock watchdog */
	WDOG->TOVAL = 0x0000FFFF;   /* Maximum timeout value */
	WDOG->CS = 0x00002100;      /* Disable watchdog */
}
void software_delay(uint32_t delay) {
	while (delay-- > 0) {
		__asm("NOP");
	}
}

bool LPUART0_data_available()
{
	return (LPUART0->STAT & LPUART_STAT_RDRF_MASK) != 0;
}
void LPUART0_wait_for_transmission_complete(void)
{
	while(!(LPUART0->STAT & LPUART_STAT_TC_MASK))
	{
		/* Wait for transmission to complete */
	}
}

int main(void)
{
	/*!
	 * Initialization:
	 * =======================
	 */

	int i = 0;
	WDOG_disable();        /* Disable WDOG */
	PORT_init_RX_TX();     /* Configure ports */
	SOSC_init_40MHz(); 	   /* Initialize system oscillator for 40 MHz xtal */
	RUN_mode_48MHz();	   /* Init clocks: 48 MHz sys, core and bus, 24 MHz flash. */
	LPUART0_init();        /* Initialize LPUART @ 19200*/


	/*!
	 * Infinite for:
	 * ========================
	 */

	for(;;)
	{

/*!
*
* =======================
*/
	if (LPUART0_data_available())
		{
			stop = true;
			LPUART0_echo_string(&stop);
			//char buffer[256];
			//LPUART0_receive_string(buffer, sizeof(buffer));
		}
		else
		{
			if(i% 1000000 == 0){
				check_uart_errors();
				LPUART0_transmit_string("01 02 03 AA 00 BB 00 30\n");
				LPUART0_wait_for_transmission_complete();
				software_delay(100000);

			}
		}

/*!
 * =======================
 * For receiving a char
 * =======================
 */
/*
		LPUART0_transmit_string("01 02 03 AA 00 BB 00 30\n");
		receivedChar = LPUART0_receive_char();

		if (receivedChar != '\0')
		{
			LPUART0_transmit_char('\n');
			LPUART0_transmit_char(receivedChar);
			LPUART0_transmit_char('\n');
		}


		software_delay(1000000);
*
*/


	}
}
