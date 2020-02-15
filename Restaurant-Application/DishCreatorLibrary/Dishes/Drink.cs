using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary.Dishes
{
    public class Drink : Dish
    {
        public eDrinkTypes Type { get; internal set; }
        public Drink(string name, int quantity, int dinerSerialNumber, eDrinkTypes drinkType) : base(name, quantity, dinerSerialNumber)
        {
            Type = drinkType;
        }
    }
}
