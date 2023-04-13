using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class Date //se cambia internal por public
    {
        #region Orden de un programa
        /* 
        * Atributos
         * Constructores
         * Propiedades
         * Métodos públicos
         * Métodos privados
         * */
        #endregion 

        #region Atributos privados para manipular las fechas
        private int _year;
        private int _month;
        private int _day;

        #endregion 

        #region Constructores
        public Date() //Constructor sin parametros
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }
        public Date(int year, int month, int day) //constructor con parámetros. Es con sobrecarga porque tengo el mismo método con diferentes parámetros
        {
            _year = ValidateYear(year); //al atributo privado _year le llevo lo que llegue por el parámetro year del constructor y a su vez, voy a validar con un metodo ese parametro
            _month = ValidateMonth(month);
            _day = ValidateDay(day); //al atributo privado _day le llevo lo que llegue por el parámetro day del constructor
        }
        #endregion

        #region Propiedades
        public int Year //al nombrar el atributo con mayúscula ya es una propiedad y además porque tiene el Getter y el Setter 
        {
            //estamos ligando la propiedad pública Year con el atributo privado _year
            get { return _year; } //retorne lo que hay en el atributo privado _year
            set { _year = ValidateYear(value); } //lo que se asigna al atributo privado _year
        }

        public int Month //Mismo Getter y Setter con notación flecha
        {
            get => _month;
            set => _month = ValidateMonth(value); //con esto hacemos la validación en el valor que pasan en el set al atributo privado
        }

        public int Day
        {
            get => _day;
            set => _day = ValidateDay(value);
        }

        #endregion

        #region Métodos públicos
        public override string ToString() //vamos a sobre escribir el método override del método ToString() para imprimir lo que yo quiero que imprima
        {
            return $"{Year,4:0000}/{Month,2:00}/{Day,2:00}"; //Formato de 4 digitos el año, 2 el mes y el dia
        }
        #endregion 

        #region Métodos privados
        private int ValidateYear(int year) //Método validar año/ValidateYear()
        {
            if (year < 0)
            {
                throw new ArgumentException("The year is not valid"); //clases base no se imprime en pantalla, se lanza la excepción
            }

            return year;

        }
        private int ValidateMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("The month is not valid");
            }

            return month;
        }
        private int ValidateDay(int day)
        {
            if (day == 29 && _month == 2 && IsLeapYear(_year))
            {
                return day;
            }

            if ((day >= 1 && day <= 28 && _month == 2) ||
               (day >= 1 && day <= 30 && (_month == 4 || _month == 6 || _month == 9 || _month == 11)) ||
               (day >= 1 && day <= 31 && (_month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)))
            {
                return day;
            }

            throw new ArgumentException("The day is not valid");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }
        #endregion

    }
}
