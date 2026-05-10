Algoritmo Leccion15Pag67Inciso2
	
	Definir i, billete, contador100 Como Entero
	Definir totalDinero Como Entero
	
	contador100 <- 0
	totalDinero <- 0
	
	Para i <- 1 Hasta 1000 Hacer
		Escribir "Ingrese el valor del billete (20, 50, 100):"
		Leer billete
		
		totalDinero <- totalDinero + billete
		
		Si billete = 100 Entonces
			contador100 <- contador100 + 1
		FinSi
	FinPara
	
	Escribir "Cantidad de billetes de $100: ", contador100
	Escribir "Total de dinero: $", totalDinero
FinAlgoritmo
