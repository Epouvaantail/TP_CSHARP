using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Classes;

namespace TestApp
{
    [TestClass]
    public class UnitTest
    {

          static List<Vehicule> listVehicules = new List<Vehicule>() {};
        

        [TestMethod]
        public void createVehicule()
        {
            // Arrange
            Camion testVehicule = new Camion ( "Scania" , "FUTZ" , 2340 , 33000);

            // Act
            listVehicules.Add(testVehicule);

            // Assert
            var vehicule = listVehicules;
            CollectionAssert.Contains(vehicule, testVehicule);
        }
    }
}