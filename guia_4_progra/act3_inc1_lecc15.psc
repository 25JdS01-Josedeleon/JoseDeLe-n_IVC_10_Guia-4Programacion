Algoritmo act3_inc1_lecc15
    Definir i, multiplo, sumaMultiplos, contadorPares Como Entero
    sumaMultiplos <- 0
    contadorPares <- 0
    
    Para i <- 1 Hasta 20 Hacer
        multiplo <- i * 7
        sumaMultiplos <- sumaMultiplos + multiplo
        
        Si multiplo % 2 == 0 Entonces
            contadorPares <- contadorPares + 1
        FinSi
    FinPara
    
    Escribir "La sumatoria de los primeros 20 múltiplos de 7 es: ", sumaMultiplos
    Escribir "Cantidad de esos múltiplos que son pares: ", contadorPares
FinAlgoritmo