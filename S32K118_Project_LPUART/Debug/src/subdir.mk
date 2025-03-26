################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../src/Asrv_App.c \
../src/LPUART_S32K11x.c \
../src/clocks_and_modes_S32K11x.c \
../src/main.c 

OBJS += \
./src/Asrv_App.o \
./src/LPUART_S32K11x.o \
./src/clocks_and_modes_S32K11x.o \
./src/main.o 

C_DEPS += \
./src/Asrv_App.d \
./src/LPUART_S32K11x.d \
./src/clocks_and_modes_S32K11x.d \
./src/main.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: Standard S32DS C Compiler'
	arm-none-eabi-gcc "@src/Asrv_App.args" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


