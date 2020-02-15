using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    abstract class DishBuilder
    {
        protected DishesRank dishesTypesRank = new DishesRank();
        protected DishesPrices dishesPrices = new DishesPrices();

        private eDishTypes DishType;
        protected Dish Dish;

        public Dish BuildDish(eDishTypes dishType)
        {
            SetDishType(dishType);
            SetMainDishRank();
            SetSecondDishRank();
            SetThirdDishRank();
            SetDishPrice();
            return GetDish();
        }

        void SetDishType(eDishTypes dishType) => DishType = dishType;

        void SetMainDishRank()
        {
            if (dishesTypesRank.DishesTypesRank.TryGetValue(DishType, out int rank))
            {
                Dish.MainRank = rank;
            }
        }

        protected abstract void SetSecondDishRank();
        protected abstract void SetThirdDishRank();
        protected abstract void SetDishPrice();
        public Dish GetDish() => Dish;
    }
}
