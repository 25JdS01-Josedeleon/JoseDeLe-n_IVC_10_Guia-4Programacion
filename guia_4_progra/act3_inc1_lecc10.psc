Algoritmo act3_inc1_lecc10
	Definir suma, n, i, divisores Como Entero
    suma = 0
    
    Para n = 2 Hasta 22 Hacer
        divisores = 0
		
        Para i = 1 Hasta n Hacer
            Si n % i = 0 Entonces
                divisores = divisores + 1
            Fin Si
        Fin Para
        
		
        Si divisores = 2 Entonces
            suma = suma + n
            Escribir "Primo encontrado: ", n
        Fin Si
    Fin Para
    
    Escribir "La suma total de los números primos es: ", suma
	
	
FinAlgoritmo