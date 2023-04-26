using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public abstract class Employee //es abstracta en este modelo porque nos va a servir de plantilla para crear las demás clases
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!; //Ignore el nulo

        public string? LastName { get; set; } //poner ? al tipo de dato hace que se ignoren los nulos
        public Date? BornDate { get; set; }

        public Date? HireDate { get; set; }

        public bool IsActive { get; set; }


        public override string ToString()
        {
            return $"{Id}\t{FirstName} {LastName}\n\t" + 
                    $"Hired................: {HireDate}";
        }

        public abstract decimal GetValueToPay(); //Una clase abstracta tiene que tener un método abstracto


    }
}
