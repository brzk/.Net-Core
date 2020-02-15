using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    class AppetizerBuilder : DishBuilder
    {

        public Appetizer BuildDish(string name, int quantity, int dinerSerialNumber, eAppetizerTypes appetizerType)
        {
            Dish = new Appetizer(name, quantity, dinerSerialNumber, appetizerType);

            return base.BuildDish(eDishTypes.Appetizer) as Appetizer;
        }        

        protected override void SetDishPrice()
        {
            if (dishesPrices.AppetizerPrices.TryGetValue(((Appetizer)Dish).Type, out int price))
            {
                Dish.Price = price;
            }
        }

        protected override void SetSecondDishRank()
        {
            Dish.SecondRank = 1;
        }

        protected override void SetThirdDishRank()
        {
            if (dishesTypesRank.AppetizerRanks.TryGetValue(((Appetizer)Dish).Type, out int rank))
            {
                Dish.ThirdRank = rank;
            }
        }
    }
}
