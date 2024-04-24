using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter;

namespace TemperatureConverter
{
    public class PresenterTemperatureConverter
    {
        private ModelTemperatureConverter model = new ModelTemperatureConverter();
        private IView view;

        public PresenterTemperatureConverter(IView view)
        {
            this.view = view;
            view.SetCelsius += OnSetCelsius;
            view.SetFarenheit += OnSetFarenheit;
            RefreshView();
        }
                
        private void OnSetFarenheit(double val)
        {
            model.ValueFahrenheit = val;
            RefreshView();
        }
                
        private void OnSetCelsius(double val)
        {
            model.ValueCelsius = val;
            RefreshView();
        }

        
        private void RefreshView()
        {
            view.DisplayCelsius(model.ValueCelsius);
            view.DisplayFarenheit(model.ValueFahrenheit);
        }
    }
}
