using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class CommisionEmployee : Employee
    {
        private float _commisionPercentaje;
        private decimal _sales;

        public float CommisionPercentage

        {
            get => _commisionPercentaje;
            set => _commisionPercentaje = ValidateCommisionPercentaje(value);

        }

        public decimal Sales

        {
            get => _sales;

            set => _sales = ValidateSales(value);

        }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentage * 0.88m;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Commision percentage.: {CommisionPercentage,20:P2}\n\t" +
                $"Sales................: {Sales,20:C2}\n\t" +
                $"Value to pay.........: {GetValueToPay(),20:C2}";

        }

        private float ValidateCommisionPercentaje(float value)
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentOutOfRangeException("The commision percentaje is not valid");
            }

            return value;
        }

        private decimal ValidateSales(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The sales value is not valid");
            }

            return value;
        }

    }
}
