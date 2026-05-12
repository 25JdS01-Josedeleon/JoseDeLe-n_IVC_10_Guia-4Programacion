Algoritmo act3_inc2_lecc9
	Definir num, i, contador Como Entero
    
    Escribir "Ingrese un numero:"
    Leer num
    
    contador = 0
    
    Para i = 1 Hasta num Hacer
        Si num % i = 0 Entonces
            contador = contador + 1
        FinSi
    FinPara
    
    Si contador = 2 Entonces
        Escribir "Es numero primo"
    SiNo
        Escribir "No es numero primo"
    FinSi
FinAlgoritmo
	