using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class SalaryEmployee : Employee
    {
        private decimal _salary;

        public decimal Salary // si tengo un atributo privado, tento que tener una propiedad para "amarrarlas"
        { 
            get=> _salary; 
            set=> _salary = ValidateSalary(value); //Toma el valor de la validación del salario
        }

        public override decimal GetValueToPay() //Como hereda de una clase abstracta, tengo que implementar hacerle override al método abstracto de la clase heredada
        {
            return Salary * (decimal)0.88; // como estoy multiplicando el Salario que es decimal, por un double (0.88) debo "castear" el doble, anteponiendole (decimal) o al final del valor, solo ponerle 0.88M
        }

        public override string ToString() //Voy a hacerle override al metodo ToString de la clase empleado (a este también se le hizo override de la clase base). Es como personalizar lo que imprimo
        {
            return $"{base.ToString()}\n\t" + //Agrego salto de linea y tabulador a lo que ya me imprime el ToString() de Employee
                $"Salary...............: {Salary, 20:C2}\n\t" +  //Agrego esta linea para imprimir el salario
                $"Value to pay.........: {GetValueToPay(), 20:C2}"; //Agrego esta linea para imprimir el método GetValue to pay que calcula el 12% de las prestaciones del empleado
                
        }

        private decimal ValidateSalary(decimal value)
        {
            if (value < 1160000) 
            {
                throw new ArgumentException("The salary is less than minimun"); //Lanzamos excepción si el salario es menor al mínimo
            }

            return value;
        }
    }
}
