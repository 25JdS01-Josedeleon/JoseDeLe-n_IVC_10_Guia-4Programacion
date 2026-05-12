Algoritmo act3_inc2_lecc15
    Definir num, i, divisores, contadorPrimos, sumaPares Como Entero
    contadorPrimos <- 0
    sumaPares <- 0
    
    Para num <- 300 Hasta 1 Con Paso -1 Hacer
        
        Si num % 2 == 0 Entonces
            sumaPares <- sumaPares + num
        FinSi

        divisores <- 0
        Para i <- 1 Hasta num Hacer
            Si num % i == 0 Entonces
                divisores <- divisores + 1
            FinSi
        FinPara
        
        Si divisores == 2 Entonces
            contadorPrimos <- contadorPrimos + 1
        FinSi
        
    FinPara
    
    Escribir "Cantidad de números primos entre 300 y 1: ", contadorPrimos
    Escribir "La suma de los números pares es: ", sumaPares
FinAlgoritmo