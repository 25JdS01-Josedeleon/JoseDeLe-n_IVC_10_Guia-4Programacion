Algoritmo act1_inc1_lecc9
    Definir peso, total Como Real
    
    total = 0
    
    Mientras total < 1 Hacer
        Escribir "Coloca una manzana en la bascula"
        Escribir "Ingrese el peso en kg:"
        Leer peso
        
        total = total + peso
        
        Escribir "Peso acumulado: ", total, " kg"
    FinMientras
    
    Escribir "Ya tienes 1 kilogramo o mas de manzanas"
FinAlgoritmo