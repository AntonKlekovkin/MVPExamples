namespace TemperatureConverter
{
    public partial class Form1 : Form, IView
    {
        public event Action<double> SetFarenheit;
        public event Action<double> SetCelsius;

        public Form1()
        {
            InitializeComponent();
            SetFarenheit += delegate { };
            SetCelsius += delegate { };
        }

        public void DisplayCelsius(double value)
        {
            tbCelsius.Text = Math.Round(value, 3).ToString();
        }

        public void DisplayFarenheit(double value)
        {
            tbFarenheit.Text = Math.Round(value, 3).ToString();
        }

        private void tbCelsius_TextChanged(object sender, EventArgs e)
        {
            SetCelsius(ConvertToDouble(tbCelsius, 0));
        }

        private void tbFarenheit_TextChanged(object sender, EventArgs e)
        {
            SetFarenheit(ConvertToDouble(tbFarenheit, 32));
        }

        private double ConvertToDouble(Control c, double defaultValue)
        {
            double ret = defaultValue;

            try
            {
                ret = Convert.ToDouble(c.Text);
            }
            catch
            {
                try
                {
                    ret = Convert.ToDouble(c.Text.Replace('.', ','));
                }
                catch
                {
                    c.Text = Convert.ToString(defaultValue);
                    ret = defaultValue;
                }
            }

            return ret;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCelsius.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
