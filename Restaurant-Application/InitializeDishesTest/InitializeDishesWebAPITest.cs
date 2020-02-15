using DishCreatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InitializeDishesTest
{
    [TestClass]
    public class InitializeDishesWebAPITest
    {
        InitializeDishes initializeDishes = new InitializeDishes();
        DishesRank dishesRank = new DishesRank();
        DishesPrices dishesPrices = new DishesPrices();
        DishParameters DishParameters = null;

        Appetizer appetizer = null;

        [TestMethod]
        public void InitializeAppetizerByAPIQuery()
        {




            string name = "Chicken Nuggets";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eAppetizerTypes appetizerType = eAppetizerTypes.ChickenSkewers;

            DishParameters = new DishParameters(){ Name = name, Quantity = quantity ,DinerSerialNumber = dinerSerialNumber};



            RunAsync().Wait();

            //Appetizer appetizer = initializeDishes.InitializeAppetizer(name, quantity, dinerSerialNumber, appetizerType);

            Assert.AreEqual(appetizerType, appetizer.Type);
            Assert.AreEqual(dinerSerialNumber, appetizer.DinerSerialNumber);
            Assert.AreEqual(dishesRank.DishTypesRank[eDishTypes.Appetizer], appetizer.MainRank);
            Assert.AreEqual(name, appetizer.Name);
            Assert.AreEqual(dishesPrices.AppetizerPrices[appetizerType], appetizer.Price);
            Assert.AreEqual(quantity, appetizer.Quantity);
            Assert.AreEqual(1, appetizer.SecondRank);
            Assert.AreEqual(dishesRank.AppetizerRanks[appetizerType], appetizer.ThirdRank);
        }

        async Task RunAsync()
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44332/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = null;

                // way 1
                //Task<string> stringTask = client.GetStringAsync("api/Dish");
                //Task<string> stringTask = client.GetStringAsync("api/Dish/3");
                string content = JsonConvert.SerializeObject(DishParameters);



                //Task<HttpResponseMessage> stringTask = client.GetAsync("api/Dish/3",new StringContent( content,Encoding.UTF8));
                Task<HttpResponseMessage> stringTask = client.PostAsync("api/Dish", new StringContent(content, Encoding.UTF8, "application/json"));
                response = await stringTask;
                Console.WriteLine(response);

                var appetizer1 = await response.Content.ReadAsStringAsync();

                appetizer = JsonConvert.DeserializeObject<Appetizer>(appetizer1);
                //appetizer = JsonConvert.DeserializeObject<Appetizer>( response.Content.ToString());
            }
        }
    }
}
