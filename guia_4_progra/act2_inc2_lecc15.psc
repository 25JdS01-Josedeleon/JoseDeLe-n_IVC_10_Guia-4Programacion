Algoritmo act2_inc2_lecc15
    Definir i, billete, contadorCien, sumaTotalCien Como Entero
    contadorCien <- 0
    sumaTotalCien <- 0
    
    Escribir "Simulación de conteo de 1000 billetes."
    
    Para i <- 1 Hasta 1000 Hacer
        Escribir "Ingrese la denominación del billete ", i, " ($20, $50, $100):"
        Leer billete 
        
        Si billete == 100 Entonces
            contadorCien <- contadorCien + 1
            sumaTotalCien <- sumaTotalCien + 100
        FinSi
    FinPara
    
    Escribir "Cantidad de billetes de $100 encontrados: ", contadorCien
    Escribir "Monto total en billetes de $100: $", sumaTotalCien
FinAlgoritmo
