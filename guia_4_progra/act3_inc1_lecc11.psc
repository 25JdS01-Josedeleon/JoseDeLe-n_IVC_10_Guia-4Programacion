Algoritmo act3_inc1_lecc11
    Definir num1, num2, menor, mayor, suma, contador Como Entero
    
    Escribir "Ingrese el primer número entero:"
    Leer num1
    Escribir "Ingrese el segundo número entero:"
    Leer num2
    
    Si num1 < num2 Entonces
        menor <- num1
        mayor <- num2
    Sino
        menor <- num2
        mayor <- num1
    FinSi
    
    suma <- 0
    contador <- menor 
    
    Repetir
        suma <- suma + contador
        contador <- contador + 1
    Hasta Que contador > mayor
    
    Escribir "La suma de los enteros entre ", menor, " y ", mayor, " es: ", suma
FinAlgoritmo