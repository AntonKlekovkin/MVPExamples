namespace TemperatureConverter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form1 myView = new Form1();            
            PresenterTemperatureConverter presenter = new PresenterTemperatureConverter(myView);
            Application.Run(myView);
        }
    }
}