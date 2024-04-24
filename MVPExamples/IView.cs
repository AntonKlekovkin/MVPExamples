using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public interface IView
    {
        void DisplayFarenheit(double value);

        void DisplayCelsius(double value);

        event Action<double> SetFarenheit;

        event Action<double> SetCelsius;
    }
}
