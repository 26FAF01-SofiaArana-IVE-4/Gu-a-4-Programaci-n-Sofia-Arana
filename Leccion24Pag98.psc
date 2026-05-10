Algoritmo Leccion24Pag98
	
	Definir n, i, divisores, suma Como Entero
	
    suma <- 0
	
    Para n <- 1 Hasta 50 Hacer
		
        divisores <- 0
		
        Para i <- 1 Hasta n Hacer
			
            Si n MOD i = 0 Entonces
				
                divisores <- divisores + 1
				
            FinSi
			
        FinPara
		
        Si divisores = 2 Entonces
			
            suma <- suma + n
			
        FinSi
		
    FinPara
	
    Escribir "La suma de los numeros primos es: ", suma
	
FinProceso
