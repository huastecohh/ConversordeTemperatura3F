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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            temp temp = new temp();
            temp.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            masa masa = new masa();
            masa.ShowDialog();
        }
    }
}
