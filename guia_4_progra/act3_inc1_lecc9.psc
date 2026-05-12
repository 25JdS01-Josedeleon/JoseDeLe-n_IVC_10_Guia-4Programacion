Algoritmo act3_inc1_lecc9
    Definir num, actual Como Entero
    
    Escribir "Ingresa un número entero:"
    Leer num
    
    actual <- 20
    
    Escribir "Los números impares entre 20 y ", num, " son:"
    
    Si num < 20 Entonces
        Mientras actual >= num Hacer
            Si actual Mod 2 <> 0 Entonces
                Escribir actual
            FinSi
            actual <- actual - 1
        FinMientras
    Sino
        Mientras actual <= limiteUsuario Hacer
            Si actual Mod 2 <> 0 Entonces
                Escribir actual
            FinSi
            actual <- actual + 1
        FinMientras
    FinSi
FinAlgoritmo