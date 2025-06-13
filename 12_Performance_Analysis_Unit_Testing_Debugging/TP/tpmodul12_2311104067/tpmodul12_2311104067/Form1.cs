using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_2311104067
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int input))
            {
                string hasil = CariTandaBilangan(input);
                labelOutput.Text = hasil;
            }
            else
            {
                labelOutput.Text = "Input tidak valid!";
            }
        }
    }
}
