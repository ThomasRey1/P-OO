using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace X_P_OO_Test_Unitaires_Thomas_Alexandre
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsResearchGood()
        {
            //arrange (déclaration des variables)
            const int filesPathLength = 2;
            string[] filesPath = new string[filesPathLength] { @"F:\oui.txt", @"F:\06-Temp" };


            //act (code de test)
            for (int i = 0; i < filesPathLength; i++)
            {

            }


            //assert (renvoi du résultat)
            Assert.AreEqual(/*résultat attendu*/, /*résultat actuel*/, /*string expliquant le résultat attendu*/);
        }
    }
}
