using Microsoft.VisualStudio.TestTools.UnitTesting;
using P_OO_Thesaurus_Thomas_Alexandre;
using System.Collections.Generic;

namespace P_OO_Thesaurus_Thomas_Alexandre.Tests
{
    [TestClass]
    public class UnitTestControler
    {
        [TestMethod]
        public void GetAndShowHistory_Return_List()
        {
            // Arrange
            Controler controler = new Controler(new Indexing(), new ModelIndexingHistory());

            // Act
            var list = controler.GetAndShowHistory();

            // Assert
            // Assert.méthode(valeur attendu, valeur obtenu, déscription);
            Assert.IsInstanceOfType(list, typeof(List<Index>), "Retourne une liste d'index");
        }
    }
}
