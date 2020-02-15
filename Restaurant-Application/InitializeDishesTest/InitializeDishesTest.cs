using DishCreatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitializeDishesTest
{
    [TestClass]
    public class InitializeDishesTest
    {
        InitializeDishes initializeDishes = new InitializeDishes();
        DishesRank dishesRank = new DishesRank();
        DishesPrices dishesPrices = new DishesPrices();

        [TestMethod]
        public void InitializeAppetizer()
        {
            //Appetizer appetizer = initializeDishes.InitializeAppetizer("chicken", 2, 1, eAppetizerTypes.ChickenNuggets);
            //Assert.AreEqual(eAppetizerTypes.ChickenNuggets, appetizer.Type);


            string name = "Chicken Nuggets";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eAppetizerTypes appetizerType = eAppetizerTypes.ChickenNuggets;
            Appetizer appetizer = initializeDishes.InitializeAppetizer(name, quantity, dinerSerialNumber, appetizerType);

            Assert.AreEqual(appetizerType, appetizer.Type);
            Assert.AreEqual(dinerSerialNumber, appetizer.DinerSerialNumber);
            Assert.AreEqual(dishesRank.DishTypesRank[eDishTypes.Appetizer], appetizer.MainRank);
            Assert.AreEqual(name, appetizer.Name);
            Assert.AreEqual(dishesPrices.AppetizerPrices[appetizerType], appetizer.Price);
            Assert.AreEqual(quantity, appetizer.Quantity);
            Assert.AreEqual(1, appetizer.SecondRank);
            Assert.AreEqual(dishesRank.AppetizerRanks[appetizerType], appetizer.ThirdRank);


        }
    }
}
