using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreatorLibrary
{
    class DishBuilderTest<T> : IDishBuilder<T> where T : Dish, new()
    {
        private T Dish;


        internal T Dish2 { get; private set; }

        public T Build(eDishTypes dishType)
        {
            Dish2 = new T();

            SetDishType(dishType)
                .SetMainDishRank()
                .SetSecondDishRank()
                .SetThirdDishRank()
                .SetDishPrice();

            return GetDish();
        }

        public T GetDish()
        {
            return Dish2;
        }

        public IDishBuilder<T> SetDishPrice()
        {
            throw new NotImplementedException();
        }

        public IDishBuilder<T> SetDishType(eDishTypes dishType)
        {
            throw new NotImplementedException();
        }

        public IDishBuilder<T> SetMainDishRank()
        {
            throw new NotImplementedException();
        }

        public IDishBuilder<T> SetSecondDishRank()
        {
            throw new NotImplementedException();
        }

        public IDishBuilder<T> SetSubDishType(object subDishType)
        {
            throw new NotImplementedException();
        }

        public IDishBuilder<T> SetThirdDishRank()
        {
            throw new NotImplementedException();
        }
    }
}
