Algoritmo act2_inc2_lecc28
	totalBoletos <- 0
	totalDinero <- 0
	opcionContinuar <- "S"
	
	Escribir "--- SISTEMA DE CONTROL DE LA RUEDA DE LA FORTUNA ---"
	
	Repetir
		Escribir ""
		Escribir "Seleccione el tipo de boleto:"
		Escribir "1. Niño ($10)"
		Escribir "2. Adulto ($15)"
		Escribir "Ingrese su opción (1 o 2):"
		Leer tipoBoleto
		
		Si tipoBoleto = "1" Entonces
			totalBoletos <- totalBoletos + 1 
			totalDinero <- totalDinero + 10 
			Escribir "Boleto de niño registrado."
		Sino
			Si tipoBoleto = "2" Entonces
				totalBoletos <- totalBoletos + 1  
				totalDinero <- totalDinero + 15   
				Escribir "Boleto de adulto registrado."
			Sino
				Escribir "Opción no válida. No se registró ningún boleto."
			FinSi
		FinSi
		
		Escribir ""
		Escribir "--- ESTADO ACTUAL ---"
		Escribir "Número de boletos vendidos: ", totalBoletos
		Escribir "Total de dinero cobrado: $", totalDinero
		Escribir "----------------------"
		
		Escribir ""
		Escribir "¿Desea registrar otro boleto? (S para Sí / N para No):"
		Leer opcionContinuar
		
	Hasta Que opcionContinuar = "N" O opcionContinuar = "n"
	
	Escribir ""
	Escribir "¡Cierre de caja exitoso! Que tenga un buen día."
FinAlgoritmo