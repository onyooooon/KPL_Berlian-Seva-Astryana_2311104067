// Helper.cs
namespace tpmodul12_2311104067
{
    public static class Helper
    {
        public static string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }
    }
}
