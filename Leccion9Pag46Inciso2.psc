Algoritmo Leccion9Pag46Inciso2
	Definir num , i, contador Como Entero
	
	Escribir "INGRESE UN NUMERO ENTERO:"
	Leer num 
	
	contador <- 0
	
	Para i <-1 Hasta num Hacer
		
		Si num MOD i = 0 Entonces
			Escribir "El numero es primo "
			
		FinSi
		
	FinPara
	
	Si contador = 2 Entonces
		Escribir num, 'Es un numero primo "
	SiNo
		Escribir num , " No es un numero primo"
	FinSi
	
FinAlgoritmo