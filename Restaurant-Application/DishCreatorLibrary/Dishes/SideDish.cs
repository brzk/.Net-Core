using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary.Dishes
{
    public class SideDish :Dish
    {
        public eSideDishTypes Type { get; internal set; }
        public SideDish(string name, int quantity, int dinerSerialNumber, eSideDishTypes sideDishType) : base(name, quantity, dinerSerialNumber)
        {
            Type = sideDishType;
        }
    }
}
