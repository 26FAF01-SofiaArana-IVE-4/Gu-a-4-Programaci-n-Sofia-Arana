Algoritmo Leccion11Pag54
	Definir num1, num2, menor , mayor, suma, contador Como Entero
	
	Escribir "Inrese el primer numero:"
	Leer num1
	
	Escribir "Ingrese el segundo numero:"
	Leer num2
	
	Si num1 < num2 Entonces
		menor <- num1
		mayor <- num2
	SiNo
		menor <- mun2 
		mayor <- num1
	FinSi
	
	suma <- 0
	
	Para contador <- menor Hasta mayor Hacer
		
		suma <- suma + contador
		
	FinPara
	
	Escribir "La suma es:", suma 
FinAlgoritmo