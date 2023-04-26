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

/* Creando objetos de la clase Date de diferentes maneras e imprimiendo de acuerdo a los métodos y validaciones detallados en la clase Date
 
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
*/

try
{
    var employee1 = new SalaryEmployee
    {
        Id = 1010,
        FirstName = "Sandra",
        LastName = "Grajales",
        BornDate = new(2000, 12, 3), //Este constructor de Date tiene dos constructores, uno sin y otro con parámetros
        HireDate = new(2020, 2, 14),
        IsActive = true,
        Salary = 1700000
    };

    var employee2 = new HourlyEmployee
    {
        Id = 2020,
        FirstName = "Franklin",
        LastName = "Restrepo",
        BornDate = new(1983, 5, 15), 
        HireDate = new(2012, 11, 20),
        IsActive = true,
        WorkingHours = 123.5f,
        HourValue = 85000
    };

    var employee3 = new CommisionEmployee
    {
        Id = 3030,
        FirstName = "Juan",
        LastName = "Sierra",
        BornDate = new(2000, 6, 9), 
        HireDate = new(2021, 12, 20),
        IsActive = true,
        CommisionPercentage = 0.05f,
        Sales = 150000000
    };

    var employee4 = new BaseCommisionEmployee
    {
        Id = 4040,
        FirstName = "Felipe",
        LastName = "Ramirez",
        BornDate = new(2000, 2, 29),
        HireDate = new(2021, 5, 15),
        IsActive = true,
        CommisionPercentage = 0.025f,
        Sales = 25000000,
        Salary = 700000
    };

    //con este ciclo imprimimos todos los empleados que están en un arreglo y el total de la nómina
    decimal payRoll = 0;
    Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4 };

    foreach(var employee in employees)
    {
        Console.WriteLine(employee);
        payRoll += employee.GetValueToPay();
    }

    Console.WriteLine($"                              =====================");
    Console.WriteLine($"Pay Roll                 {payRoll, 20:C2}");
}
catch (Exception)
{

    throw;
}
