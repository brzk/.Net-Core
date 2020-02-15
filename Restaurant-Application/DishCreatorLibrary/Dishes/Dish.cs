using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public abstract class Dish
    {
        public int MainRank { get; internal set; }
        public int SecondRank { get; internal set; }
        public int ThirdRank { get; internal set; }
        public int Price { get; internal set; }
        public int Quantity { get; internal set; }
        public string Name { get; }
        public int DinerSerialNumber { get; }

        public Dish(string name, int quantity, int dinerSerialNumber)
        {
            Name = name;
            Quantity = quantity;
            DinerSerialNumber = dinerSerialNumber;
        }
    }
}
