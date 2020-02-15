using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public abstract class Dish
    {
        public int MainRank { get;  set; }
        public int SecondRank { get; set; }
        public int ThirdRank { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
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
