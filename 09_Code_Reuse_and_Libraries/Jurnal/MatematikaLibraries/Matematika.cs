using System;
using System.Text;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public string Turunan(int[] koefisien)
        {
            StringBuilder hasil = new StringBuilder();
            int pangkat = koefisien.Length - 1;

            for (int i = 0; i < koefisien.Length - 1; i++)
            {
                int coef = koefisien[i];
                int pangkatBaru = pangkat - 1;
                int hasilCoef = coef * pangkat;

                if (hasilCoef == 0) { pangkat--; continue; }

                if (hasil.Length > 0 && hasilCoef > 0)
                    hasil.Append(" + ");
                else if (hasilCoef < 0)
                    hasil.Append(" - ");

                hasil.Append(Math.Abs(hasilCoef));
                if (pangkatBaru > 0)
                    hasil.Append("x" + (pangkatBaru == 1 ? "" : pangkatBaru));
                pangkat--;
            }

            return hasil.ToString();
        }

        public string Integral(int[] koefisien)
        {
            StringBuilder hasil = new StringBuilder();
            int pangkat = koefisien.Length;

            for (int i = 0; i < koefisien.Length; i++)
            {
                double coef = (double)koefisien[i] / (pangkat - i);
                if (hasil.Length > 0 && coef > 0)
                    hasil.Append(" + ");
                else if (coef < 0)
                    hasil.Append(" - ");

                hasil.Append(Math.Abs(coef));
                hasil.Append("x" + (pangkat - i));
            }

            hasil.Append(" + C");
            return hasil.ToString();
        }
    }
}
