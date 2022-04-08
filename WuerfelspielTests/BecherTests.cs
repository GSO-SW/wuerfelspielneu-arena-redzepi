using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class BecherTests
    {
        [TestMethod]
        public void BecherErstellen()
        {

            //arrange
            int anzahlWuerfel = 2;

            //act
            Becher becher = new Becher(anzahlWuerfel);


            //Assert

            Assert.IsInstanceOfType(becher, Becher);
            
        }
        [TestMethod]
        public void Becher_Hat_Wuerfel()
        {
            //arrange 
            int anzahlWuerfel = 1;

            //act
            Becher becher = new Becher(anzahlWuerfel);

            //assert
            Assert.AreEqual(becher.Wuerfel.length, anzahlwuerfel);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        private void Becher_Hat_Null_Wuerfel()
        {
            //arrange
            int anzahlWuerfel = 0;
            //act
            Becher becher = new Becher(anzahlWuerfel);

        }
    }
}
