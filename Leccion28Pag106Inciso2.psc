Algoritmo Leccion28Pag106Inciso2
	
    Definir billete, cantidad100, totalDinero, i Como Entero
	
    cantidad100 <- 0
    totalDinero <- 0
	
    Para i <- 1 Hasta 1000 Hacer
		
        Escribir "Ingrese el valor del billete:"
        Leer billete
		
        Si billete = 100 Entonces
			
            cantidad100 <- cantidad100 + 1
			
            totalDinero <- totalDinero + billete
			
        FinSi
		
    FinPara
	
    Escribir "Cantidad de billetes de 100: ", cantidad100
	
    Escribir "Total de dinero en billetes de 100: ", totalDinero
	
FinProceso