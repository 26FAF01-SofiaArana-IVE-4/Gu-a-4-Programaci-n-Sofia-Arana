Algoritmo Leccion15Pag67
	Definir i, j, divisores, contador, suma Como Entero
	
	contador <- 0
	suma <- 0
	
	Para i <- 1 Hasta 100 Hacer
		divisores <- 0
		
		Para j <- 1 Hasta i Hacer
			Si i MOD j = 0 Entonces
				divisores <- divisores + 1
			FinSi
		FinPara
		
		Si divisores = 2 Entonces
			contador <- contador + 1
			suma <- suma + i
		FinSi
	FinPara
	
	Escribir "Cantidad de números primos: ", contador
	Escribir "Suma de los números primos: ", suma
FinAlgoritmo