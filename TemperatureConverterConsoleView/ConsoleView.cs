using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureConverter;

namespace TemperatureConverterConsoleView
{
    internal class ConsoleView : IView
    {
        public event Action<double> SetFarenheit;
        public event Action<double> SetCelsius;

        public ConsoleView() 
        {
            SetFarenheit += delegate { };
            SetCelsius += delegate { };

            
        }

        public bool ReadConsole()
        {
            var str = Console.ReadLine();

            if (str == null) return true;

            if (str.Contains('c'))
            {
                var tC = Convert.ToDouble(str.Replace('c', ' ').Trim());
                SetCelsius(tC);
            }
            else if (str.Contains('f'))
            {
                var tF = Convert.ToDouble(str.Replace('f', ' ').Trim());
                SetFarenheit(tF);
            }            
            else if(str.Contains('x'))
            {
                return false;
            }
            else
            {
                try
                {
                    var tC = Convert.ToDouble(str.Replace('c', ' ').Trim());
                    SetCelsius(tC);
                }
                catch { }
            }
            
            return true;
            
        }

        public void DisplayCelsius(double value)
        {
            Console.WriteLine($"Celsius: {value}");
        }

        public void DisplayFarenheit(double value)
        {
            Console.WriteLine($"Farenheit: {value}");
        }
    }
}
