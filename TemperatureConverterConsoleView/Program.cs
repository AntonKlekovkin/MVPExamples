using TemperatureConverter;

namespace TemperatureConverterConsoleView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleView cv = new ConsoleView();
            PresenterTemperatureConverter presenter = new PresenterTemperatureConverter(cv);

            while (cv.ReadConsole());
            
                        
        }
    }
}
