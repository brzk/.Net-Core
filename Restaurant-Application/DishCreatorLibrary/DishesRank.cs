using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    public class DishesRank
    {
        public Dictionary<eDishTypes, int> DishesTypesRank = new Dictionary<eDishTypes, int>()
        {
            { eDishTypes.Appetizer, 1 },
            { eDishTypes.MainDish, 2 }
        };

        public Dictionary<eAppetizerTypes, int> AppetizerRanks = new Dictionary<eAppetizerTypes, int>()
        {
            { eAppetizerTypes.ChickenNuggets, 1 },
            { eAppetizerTypes.ChickenSkewers, 2 },
            { eAppetizerTypes.ChickenWings, 3 }
        };

        public Dictionary<eMainDishTypes, int> MainDishRanks = new Dictionary<eMainDishTypes, int>()
        {
            { eMainDishTypes.ChickenBreast, 1 },
            { eMainDishTypes.Schnitzel, 2 },
            { eMainDishTypes.SpringChicken, 3 }
        };
    }
}
