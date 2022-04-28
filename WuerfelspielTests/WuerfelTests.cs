using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_KannErstelltWerden()
        {
            //Act
            Wuerfel wuerfel = new Wuerfel();
        }

        [TestMethod]
        public void Wuerfel_AnzahlSeitenKannAngegebenWerden()
        {
            //Arrange
            int anzahlSeiten = 12;
            //Act
            Wuerfel wuerfel = new Wuerfel(anzahlSeiten);
            //Assert
            Assert.AreEqual(anzahlSeiten, wuerfel.AnzahlSeiten);

        }

    }
}
