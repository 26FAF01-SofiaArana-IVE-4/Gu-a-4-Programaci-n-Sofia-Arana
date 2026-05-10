Algoritmo Leccion15Pag65
	Definir tipo, ttllBoletos Como Entero
	Definir ttllDinero Como Real
	
	ttllBoletos <- 0
	ttllDinero <- 0
	
	Repetir
		Escribir "1=Adulto ($15), 2=Niño ($10), 0=Salir"
		Leer tipo
		
		Si tipo = 1 Entonces
			ttllBoletos <- ttllBoletos + 1
			ttllDinero <- ttllDinero + 15
		Sino
			Si tipo = 2 Entonces
				ttllBoletos <- ttllBoletos + 1
				ttllDinero <- ttllDinero + 10
			Sino
				Si tipo <> 0 Entonces
					Escribir "Opción inválida"
				FinSi
			FinSi
		FinSi
		
	Hasta Que tipo = 0
	
	Escribir "Total de boletos: ", ttllBoletos
	Escribir "Total recaudado: $", ttllDinero
FinAlgoritmo
