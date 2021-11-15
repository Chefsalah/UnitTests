
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bankdaten;
using System;

namespace BankdatenTests
{
    [TestClass]
    public class Mitarbeitertests
    {
        [TestMethod]
        public void MitarbeiterHinzufügen()
        {
            //arrange
           
            Mitarbeiter M = new Mitarbeiter("bernd", "elbel",new DateTime(1999,12,22));

            //act
            M.Mitarbeiter



        }
    }
}
