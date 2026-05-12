Algoritmo act2_inc3_lecc11
	Definir n1, n2, menor, mayor, i Como Entero
    
    Escribir "Ingrese el primer número:"
    Leer n1
    Escribir "Ingrese el segundo número:"
    Leer n2
    
	
    Si n1 < n2 Entonces
        menor <- n1
        mayor <- n2
    Sino
        menor <- n2
        mayor <- n1
    Fin Si
    
    Escribir "Múltiplos de 4 entre ", menor, " y ", mayor, ":"
    
    Para i <- menor Hasta mayor Hacer
        
        Si i % 4 = 0 Entonces
            Escribir i
        Fin Si
    Fin Para
	
FinAlgoritmo
