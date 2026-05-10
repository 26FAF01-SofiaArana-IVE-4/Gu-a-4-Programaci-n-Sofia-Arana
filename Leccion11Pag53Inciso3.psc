Algoritmo Leccion11Pag53Inciso3
	Definir num1, num2, menor , mayor, contador Como Entero
	
	Escribir "Ingrese el primer numero:"
	Leer num1
	
	Escribir "Ingrse el segundo numero:"
	Leer num2
	
	Si num1 < num2 Entonces
		menor <- num1
		mayor <- num2
	SiNo
		menor <- num2
		mayor <-mun1
	FinSi
	Para contador <- menor Hasta  mayor Hacer
		
		Si contador MOD 4 = 0 Entonces
			Escribir contador
		FinSi
	FinPara
FinAlgoritmo