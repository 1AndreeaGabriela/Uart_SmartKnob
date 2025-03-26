#ifndef LPUART_S32K11X_H_
#define LPUART_S32K11X_H_
#include <stddef.h>
#include <stdbool.h>

/* Function to initialize the UART RX TX pins*/
void PORT_init_RX_TX (void);

/* Function to initialize the UART with specific settings */
void LPUART0_init(void);

/* Function to transmit a single character */
void LPUART0_transmit_char(char send);

/* Function to transmit a string */
void LPUART0_transmit_string(char data_string[]);

/* Function to receive a single character */
char LPUART0_receive_char(void);

/* Function to receive a string until a newline is encountered */
void LPUART0_receive_string(char* buffer, size_t max_len);

/* Function to echo received characters back */
void LPUART0_receive_and_echo_char(void);

/* Function to echo received string back */
bool LPUART0_echo_string(bool *stop);

void check_uart_errors(void);


#endif /* LPUART_S32K11X_H_ */
