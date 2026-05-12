Algoritmo act2_inc1_lecc9
		Definir monedas Como Entero
		
		Escribir "Bienvenido al juego."
		Escribir "¿Cuántas monedas tienes actualmente?"
		Leer monedas
		
		Mientras monedas < 350 Hacer
			Escribir "Nivel 5 BLOQUEADO. Tienes ", monedas, " monedas."
			Escribir "Necesitas al menos 350 monedas para desbloquearlo."
			Escribir ""
			
			// Simulamos que el jugador recolecta más monedas
			Escribir "¿Cuántas monedas tienes ahora después de jugar?"
			Leer monedas
			Si monedas >= 350 Entonces
				Escribir "Puedes ingresar al nivel 5"
			SiNo
				Escribir "Nivel 5 bloqueado, necesitas mas monedas"
			FinSi
		FinMientras
		
		Escribir "--------------------------------------------------"
		Escribir "¡FELICIDADES! Tienes ", monedas, " monedas."
		Escribir "¡El Nivel 5 ha sido DESBLOQUEADO con éxito! Bienvenido."
FinAlgoritmo