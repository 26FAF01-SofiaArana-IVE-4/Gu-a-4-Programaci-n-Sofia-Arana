Algoritmo Leccion9Pag45
	
	Definir monedad, ganar, faltan Como Entero
	
	Escribir "************* VIDEO JUEGO ****************"
	
	
	Escribir "Ingrese la cantidad de monedas del jugador:"
	Leer monedas
	
	Mientras monedas < 350 Hacer
		
		Escribir "El nivel 5 esta bloqueado"
		
		fatan <- 350 - monedas
		Escribir "Te faltan ", faltan ," monedas para desbloquealo,"
		
		Escribir "¿Cuantas monedas ganastes?"
		Leer ganar 
		monedas = monedas + ganar 
		
	FinMientras
	
	Escribir "¡FELICIDADES! Ya puedes ingresar al nivel 5"
	Escribir "Total de monedas:",monedas
	
FinAlgoritmo