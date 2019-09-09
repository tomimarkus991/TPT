
         CLO            ; Closes all windows for the beginning
         MOV BL, A0     ; Move value to top left
Rep:
         
         IN 00          ; Wait for key press - Store in AL.
         MOV [BL], AL   ; Move value held in BL memory location into Display location
         INC BL         ; Increment BL
         CMP AL, 0D     ; Compare -- was the Enter key pressed? 
         JNZ Rep        ; If No then Jump back IF Yes then end.
         MOV CL, C0      ; start of Virtual Display
         MOV AL, A0      ; stored character pointer to AL

Rep01:   MOV DL, [AL]    ; get stored character
         MOV [CL], DL    ; put on Virtual Display
         INC CL          ; next char. on Virtual Display
         INC AL          ; next stored character
         CMP CL, 00      ; end of Virtual Display memory?
	 JNZ Rep01       ; no, loop

 END

