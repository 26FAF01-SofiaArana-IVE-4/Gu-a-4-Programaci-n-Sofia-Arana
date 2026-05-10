Algoritmo Leccion9_Acti1_Inc1
	Definir pesoAcumulado , pesoManzana , contarManzanas Como Real
	pesoAcumul=0;
	contarManzanas=0;
	
	Escribir "==========Báscula del Mercado=========="
	
	Mientras pesoAcumulado<1000 Hacer
		Escribir "Ingrese el peso de la manzana en gramos (100-300)"
		Leer pesoManzana
		
		Si pesoManzana>=100 y pesoManzana<=300 Entonces
			pesoAcumulado=pesoAcumulado+pesoManzana
			Escribir "Peso actuial: ",pesoAcumulado,"gramos"
			contarManzanas=contarManzanas+1
		SiNo
			Escribir "Error: Esa manzan a no cumple con el peso solicitado"
		Fin Si
	FinMientras
	
	Escribir "¡Meta Alcanzasa! Ya tiene",pesoAcumulado/1000,"kilo en la bolsa"
	Escribir "Usted acumulo ",contarManzanas, "el total de Manzanas"
FinAlgoritmo