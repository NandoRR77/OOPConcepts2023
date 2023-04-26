using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class HourlyEmployee : Employee
    {
        private float _workingHours;
        private decimal _hourValue;

        public float WorkingHours 
        
        { 
            get => _workingHours; 
            set => _workingHours = ValidateWorkingHours(value); 
        
        }

        public decimal HourValue

        {
            get => _hourValue;

            set => _hourValue = ValidateHourValue(value);

        }

        public override string ToString() 
        {
            return $"{base.ToString()}\n\t" + 
                $"Working hours........: {WorkingHours, 20:N2}\n\t" +
                $"Hour value...........: {HourValue, 20:C2}\n\t" +
                $"Value to pay.........: {GetValueToPay(), 20:C2}"; 

        }

        public override decimal GetValueToPay()
        {
            return (decimal)WorkingHours * HourValue * 0.88m;
        }

        private float ValidateWorkingHours(float value)
        {
            if (value < 0 || value > 240) 
            {
                throw new ArgumentOutOfRangeException("The working hours is not valid");
            }

            return value;
        }

        private decimal ValidateHourValue(decimal value)
        {
            if (value < 30000)
            {
                throw new ArgumentOutOfRangeException("The hour value is not valid");
            }

            return value;
        }

    }
}
