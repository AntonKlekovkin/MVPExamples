using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    internal class ModelTemperatureConverter
    {
        private double valueFahrenheit = 32;
        private double valueCelsius = 0;
                
        public double ValueFahrenheit
        {
            get => valueFahrenheit; 
            set
            {
                valueFahrenheit = value;
                valueCelsius = (valueFahrenheit - 32) * 5 / 9;
            }
        }

        public double ValueCelsius
        {
            get => valueCelsius;
            set
            {
                valueCelsius = value;
                valueFahrenheit = valueCelsius * 9 / 5 + 32;
            }
        }
    }
}
