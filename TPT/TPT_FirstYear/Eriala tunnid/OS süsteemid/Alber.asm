
;Lahendada võrrand y=a*b-c*d (lähtearvud programmis)

	CLO		; Close unwanted windows.
	MOV AL,2	; Copy a 2 into the AL register.
	MOV BL,4	; Copy a 4 into the BL register.
	MOV CL,1
	MOV DL,3
	
	MUL AL,BL	;Korrutab AL BL-iga
	MUL CL,DL	;Korrutab CL DL-iga
	SUB AL,CL	;Lahutab 
	END		;Program ends
; ===== Program Ends ===========================================
