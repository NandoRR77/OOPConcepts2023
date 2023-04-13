using OOPConcepts.Logic;

/* Recorderis
//Para enteros
int myInt = 12;

//Para valores decimales
float myFloat = 0.08488488f; //Tiene que tener f al final, para valores porcentuales
double myDouble = 493646.9797987987;
decimal myDecimal = 12888000; //Decimal para valores monetarios

//Para string
string myString = "Fernando Ramirez";

//Para booleanos
bool myBool = true;

Console.WriteLine("El valor entero es.....: " + myInt ); //Impresión concatenada
Console.WriteLine($"El valor entero es....: {myInt,20} "); //Impresión interpolada, el 20 signfica los espacios a la izquierda
Console.WriteLine($"El valor flotante es..: {myFloat, 20:P2}"); //Impresión interpolada, P2 indica que solo 2 posiciones decimales y porcentaje
Console.WriteLine($"El valor flotante es..: {myDouble, 20:N2}"); //Impresión interpolada, N2 indica que solo 2 posiciones decimales
Console.WriteLine($"El valor flotante es..: {myDecimal, 20:C2}"); //Impresión interpolada, C2 indica que solo 2 posiciones decimales
Console.WriteLine($"El valor del string es: {myString}");
Console.WriteLine($"El valor del booleano es: {(myBool ? "SI" : "NO")}"); //Condicional de una linea el primer valor es si es verdadero, el segundo para si es falso
*/

try
{
    //Forma 3 - con var y ahí si obligatoriamente tengo que indicar después de new que es de la clase Date
    //No se define explicitamente
    var date1 = new Date(); //creación objeto sin parametros como está definido su constructor en la clase
    var date2 = new Date(year: 2023, month: 02, day: 10); //creación objeto con parametros como está definido su constructor en la clase
    var date3 = new Date() //creación objeto asignando las propiedades directamente, sin pasar por los constructores definidos en la clase
    {
        Year = 1983,
        Month = 5,
        Day = 15
    };

    date1.Year = date2.Year + 20;
    date1.Month = date3.Month + 1;
    date1.Day = 15;

    Console.WriteLine($"Date 1 : {date1}");
    Console.WriteLine($"Date 2 : {date2}");
    Console.WriteLine($"Date 3 : {date3}");
}

catch (Exception ex) //si captura la excepción imprime el mensaje definido en el método que valida las propiedades
{
    Console.WriteLine(ex.Message);
}

