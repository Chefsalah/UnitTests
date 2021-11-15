using System;
using Bankdaten;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankdatenTests
{
    [TestClass]
    public class RechenwerkTests
    {
        [TestMethod]
        public void Berechenpruefsumme_Ergebniss_Fall1()
        {
            //arrange 
            Rechenwerk R1 = new Rechenwerk();


            // act

           int a =  R1.BerechnePruefsumme(5, 17);

            // assert
            Assert.AreEqual(40, a);



        }
        [TestMethod]
        public void Berechnepruefsumme_Ergebniss_fall2()
        {

            //arrange 
            Rechenwerk R2 = new Rechenwerk();


            // act

            int b = R2.BerechnePruefsumme(5, 17);

            // assert
            Assert.AreEqual(40, b);

            //arrange 
            Rechenwerk R3 = new Rechenwerk();


            // act

            int c = R3.BerechnePruefsumme(5, 17);

            // assert
            Assert.AreEqual(40, c);

            //arrange 
            Rechenwerk R4 = new Rechenwerk();


            // act

            int d = R4.BerechnePruefsumme(5, 17);

            // assert
            Assert.AreEqual(40, d);




        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Berechenpruefsummer_pruefsummeberechnen_fall1Negativ()
        {
            //arrange
            Rechenwerk r = new Rechenwerk();

            //act
            r.BerechnePruefsumme(0, 0);

          


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Berechenpruefsummer_pruefsummeberechnen_fall2Negativ()
        {
            //arrange
            Rechenwerk r = new Rechenwerk();

            //act
            r.BerechnePruefsumme(-1, -1);




        }

        [TestMethod]
        public void Mitarbeiter_hinzufügen()
        {
            //assert
            Rechenwerk R = new Rechenwerk();
            //
            


        }



    }
}
