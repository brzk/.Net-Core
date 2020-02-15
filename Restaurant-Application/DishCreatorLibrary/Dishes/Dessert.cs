using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public class Dessert : Dish
    {
        public eDessertTypes Type { get; internal set; }
        public Dessert(string name, int quantity, int dinerSerialNumber, eDessertTypes dessertType) : base(name, quantity, dinerSerialNumber)
        {
            Type = dessertType;
        }
    }
}
