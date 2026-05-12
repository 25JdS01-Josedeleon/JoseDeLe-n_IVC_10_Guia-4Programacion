Algoritmo act2_inc1_lecc15
    Definir num, i, divisores, contadorPrimos, sumaPrimos Como Entero
    contadorPrimos <- 0
    sumaPrimos <- 0
    
    Para num <- 1 Hasta 100 Hacer
        divisores <- 0
        Para i <- 1 Hasta num Hacer
            Si num % i == 0 Entonces
                divisores <- divisores + 1
            FinSi
        FinPara
        Si divisores == 2 Entonces
            contadorPrimos <- contadorPrimos + 1
            sumaPrimos <- sumaPrimos + num
        FinSi
    FinPara
    
    Escribir "Cantidad de números primos: ", contadorPrimos
    Escribir "La suma de los números primos es: ", sumaPrimos
FinAlgoritmo