using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104067;

namespace TestProject1
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void Test_Positive()
        {
            string result = Helper.CariTandaBilangan(5);
            Assert.AreEqual("Positif", result);
        }

        [TestMethod]
        public void Test_Negative()
        {
            string result = Helper.CariTandaBilangan(-3);
            Assert.AreEqual("Negatif", result);
        }

        [TestMethod]
        public void Test_Zero()
        {
            string result = Helper.CariTandaBilangan(0);
            Assert.AreEqual("Nol", result);
        }
    }
}
