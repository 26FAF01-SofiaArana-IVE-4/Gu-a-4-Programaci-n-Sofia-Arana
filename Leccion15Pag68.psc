Algoritmo Leccion15Pag68
	Definir i, j, divisores, contadorPrimos, sumaPares Como Entero
	
	contadorPrimos <- 0
	sumaPares <- 0
	
	Para i <- 300 Hasta 1 Con Paso -1 Hacer
		
		divisores <- 0
		Para j <- 1 Hasta i Hacer
			Si i MOD j = 0 Entonces
				divisores <- divisores + 1
			FinSi
		FinPara
		
		Si divisores = 2 Entonces
			contadorPrimos <- contadorPrimos + 1
		FinSi
		
		// Verificar si es par
		Si i MOD 2 = 0 Entonces
			sumaPares <- sumaPares + i
		FinSi
		
	FinPara
	
	Escribir "Cantidad de números primos: ", contadorPrimos
	Escribir "Suma de números pares: ", sumaPares
FinAlgoritmo