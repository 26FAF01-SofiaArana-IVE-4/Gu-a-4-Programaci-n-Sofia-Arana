Algoritmo Leccion15Pag68Inciso1
	Definir i, multiplo, suma, contadorPares Como Entero
	
	suma <- 0
	contadorPares <- 0
	
	Escribir "Multiplos sumados y cantidad de pares de 7"
	
	Para i <- 1 Hasta 20 Hacer
		multiplo <- 7 * i
		
		suma <- suma + multiplo
		
		Si multiplo MOD 2 = 0 Entonces
			contadorPares <- contadorPares + 1
		FinSi
	FinPara
	
	Escribir "Sumatoria: ", suma
	Escribir "Cantidad de pares: ", contadorPares
FinAlgoritmo
