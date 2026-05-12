Algoritmo act3_inc2_lecc11
    Definir numero_ingresado, suma Como Entero
    
    suma <- 0
    
    Repetir
        Escribir "Ingrese un número (ingrese 9 para terminar y ver el resultado):"
        Leer numero_ingresado
        
        Si numero_ingresado <> 9 Entonces
            suma <- suma + numero_ingresado
        FinSi
        
    Hasta Que numero_ingresado = 9
    
    Escribir "La suma total de los números ingresados es: ", suma
FinAlgoritmo
