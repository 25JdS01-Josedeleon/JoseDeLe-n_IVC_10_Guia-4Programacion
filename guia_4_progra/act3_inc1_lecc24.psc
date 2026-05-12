Algoritmo act3_inc1_lecc24
		Definir i, j, suma Como Entero
		Definir a Como Logico
		
		suma = 0
		
		Para i = 1 Hasta 50 Hacer
			a = Verdadero
			
			Si i <= 1 Entonces
				a = Falso
			SiNo
				Para j = 2 Hasta i - 1 Hacer
					Si i MOD j = 0 Entonces
						a = Falso
					FinSi
				FinPara
			FinSi
			
			Si a Entonces
				suma = suma + i
			FinSi
		FinPara
		
		Escribir "La suma de los primos es: ", suma
	
FinAlgoritmo
