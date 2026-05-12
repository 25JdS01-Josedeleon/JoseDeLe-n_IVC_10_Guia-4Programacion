Algoritmo act1_inc1_lecc15
	
	Definir opcio, totalBoletos Como Entero
    Definir totalDinero Como Real
    
    totalBoletos <- 0
    totalDinero <- 0
    opcio = 1
    
    Escribir "--- Sistema de Ventas: Rueda de la Fortuna ---"
    
    Mientras opcio <> 0 Hacer
        Escribir "Seleccione tipo de boleto:"
        Escribir "1. Adulto ($15)"
        Escribir "2. Niño ($10)"
        Escribir "0. Cerrar caja y ver totales"
        Leer opcio
        
        Segun opcio Hacer
            1:
                totalBoletos <- totalBoletos + 1
                totalDinero <- totalDinero + 15
                Escribir "Boleto de adulto registrado."
            2:
                totalBoletos <- totalBoletos + 1
                totalDinero <- totalDinero + 10
                Escribir "Boleto de niño registrado."
            0:
                Escribir "Cerrando sistema..."
            De Otro Modo:
                Escribir "Opción no válida."
        Fin Segun
        
        Escribir "Estado actual: ", totalBoletos, " boletos vendidos. Total: $", totalDinero
        Escribir "--------------------------------------------"
    Fin Mientras
    
    Escribir "REPORTE FINAL:"
    Escribir "Total de boletos vendidos: ", totalBoletos
    Escribir "Total de dinero cobrado: ", totalDinero
	
FinAlgoritmo
