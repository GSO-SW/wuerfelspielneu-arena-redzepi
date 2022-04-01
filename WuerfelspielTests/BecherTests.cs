using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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



       
    }
}
