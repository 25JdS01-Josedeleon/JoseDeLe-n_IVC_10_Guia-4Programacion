Algoritmo act2_inc1_lecc11
	Definir n, i Como Entero
    Definir factorial Como Real 
    
    Escribir "Ingrese un número entero para calcular su factorial:"
    Leer n
    
    Si n < 0 Entonces
        Escribir "El factorial no está definido para números negativos."
    Sino
        factorial <- 1
        i <- 1
        
        Si n > 0 Entonces
            Repetir
                factorial <- factorial * i
                i <- i + 1
            Hasta Que i > n
        Fin Si
        
        Escribir "El factorial de ", n, " es: ", factorial
    Fin Si
	
FinAlgoritmo
