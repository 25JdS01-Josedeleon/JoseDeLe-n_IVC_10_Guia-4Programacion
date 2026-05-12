Algoritmo act1_inc1_lecc11
	Definir capacidadTotal, autosIngresados, cajonesLibres Como Entero
    capacidadTotal <- 200
    autosIngresados <- 0
    
    Repetir
        cajonesLibres <- capacidadTotal - autosIngresados
        
        Si cajonesLibres > 0 Entonces
            Escribir "Cajones disponibles: ", cajonesLibres
            Escribir "Ingrese 1 si entró un auto (o cualquier otro número para salir):"
            Leer entrada 
            autosIngresados <- autosIngresados + 1
        Fin Si
        
    Hasta Que autosIngresados >= capacidadTotal
    
    Escribir "Ya no hay cajones libres. Estacionamiento lleno."
	
	
FinProceso