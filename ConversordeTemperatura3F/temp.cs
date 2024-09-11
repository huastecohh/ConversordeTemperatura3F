using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversordeTemperatura3F
{
    public partial class temp : Form
    {
        public temp()
        {
            InitializeComponent();
        }

        private void cbtemp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedUnit = cbtemp.SelectedItem.ToString();
            double temperatureValue = double.Parse(txttemp.Text);

            switch (selectedUnit)
            {
                case "Celsius":
                    // Convertir Celsius a Fahrenheit y Kelvin
                    double fahrenheitValue = temperatureValue * 9 / 5 + 32;
                    double kelvinValue = temperatureValue + 273.15;
                    lblresultado.Text = $"Fahrenheit: {fahrenheitValue:F2}°F, Kelvin: {kelvinValue:F2}K";
                    break;
                case "Fahrenheit":
                    // Convertir Fahrenheit a Celsius y Kelvin
                    double celsiusValue = (temperatureValue - 32) * 5 / 9;
                    kelvinValue = celsiusValue + 273.15;
                    lblresultado.Text = $"Celsius: {celsiusValue:F2}°C, Kelvin: {kelvinValue:F2}K";
                    break;
                case "Kelvin":
                    // Convertir Kelvin a Celsius y Fahrenheit
                    celsiusValue = temperatureValue - 273.15;
                    fahrenheitValue = celsiusValue * 9 / 5 + 32;
                    lblresultado.Text = $"Celsius: {celsiusValue:F2}°C, Fahrenheit: {fahrenheitValue:F2}°F";
                    break;
            }
        }

        private void temp_Load(object sender, EventArgs e)
        {

            cbtemp.Items.Clear();
            cbtemp.Items.Add("Celsius");
            cbtemp.Items.Add("Fahrenheit");
            cbtemp.Items.Add("Kelvin");
        }
    }
}
    