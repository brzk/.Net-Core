using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    internal interface IDishBuilder<T>
    {
        IDishBuilder<T> SetDishType(eDishTypes dishType);        
        IDishBuilder<T> SetMainDishRank();
        IDishBuilder<T> SetSecondDishRank();
        IDishBuilder<T> SetThirdDishRank();
        IDishBuilder<T> SetDishPrice();
        T GetDish();
    }
}
