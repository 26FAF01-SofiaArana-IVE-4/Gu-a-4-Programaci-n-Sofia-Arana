Algoritmo Leccion10Pag50
	Definir num , divisor, sunma Como Entero
	
	suma <- 0
	
	Para num <- 2 Hasta 22 Hacer
		
		contador <- 0
		
		Para divisor <- 1 Hasta num Hacer
			
			Si num MOD divisor = 0 Entonces
				contador <- contador + 1
			FinSi
			
		FinPara
		
		Si contador = 2 Entonces
			suma <- suma + num
		FinSi
		
	FinPara
	
	Escribir "La suma de los numeros primos es :", suma 
	
FinAlgoritmo