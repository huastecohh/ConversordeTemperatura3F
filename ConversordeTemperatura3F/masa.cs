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
    public partial class masa : Form
    {
        public masa()
        {
            InitializeComponent();
        }

        private void masa_Load(object sender, EventArgs e)
        {
            cmbMaxUnits.Items.Clear();
            cmbMaxUnits.Items.Add("Gramos");
            cmbMaxUnits.Items.Add("Kilogramos");
            cmbMaxUnits.Items.Add("Libras");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedUnit = cmbMaxUnits.SelectedItem.ToString();
            double massValue = double.Parse(txtmasa.Text);

            switch (selectedUnit)
            {
                case "Gramos":
                    // Convertir Gramos a Kilogramos y Libras
                    double kilogramValue = massValue / 1000;
                    double poundValue = massValue / 453.592;
                    MessageBox.Show($"Kilogramos: {kilogramValue:F2} kg, Libras: {poundValue:F2} lb");
                    break;
                case "Kilogramos":
                    // Convertir Kilogramos a Gramos y Libras
                    double gramValue = massValue * 1000;
                    poundValue = massValue * 2.20462;
                    MessageBox.Show($"Gramos: {gramValue:F2} g, Libras: {poundValue:F2} lb");
                    break;
                case "Libras":
                    // Convertir Libras a Gramos y Kilogramos
                    gramValue = massValue * 453.592;
                    kilogramValue = gramValue / 1000;
                    MessageBox.Show($"Gramos: {gramValue:F2} g, Kilogramos: {kilogramValue:F2} kg");
                    break;
            }
        }
    }
}
