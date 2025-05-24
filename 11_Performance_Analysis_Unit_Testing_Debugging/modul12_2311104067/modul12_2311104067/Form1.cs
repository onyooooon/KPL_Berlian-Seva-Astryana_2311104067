using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul12_2311104067
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CariNilaiPangkat(int a, int b)
        {
            if (b == 0)
                return 1;
            if (b < 0)
                return -1;
            if (b > 10 || a > 100)
                return -2;

            try
            {
                checked
                {
                    int result = 1;
                    for (int i = 0; i < b; i++)
                    {
                        result *= a;
                    }
                    return result;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                int hasil = CariNilaiPangkat(a, b);
                label1.Text = $"Hasil: {hasil}";
            }
            else
            {
                label1.Text = "Input tidak valid!";
            }
        }
    }
}
