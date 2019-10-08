using System.Collections.Generic;

namespace chefsdishes.Models

{
    public class ChefDishBundle
    {
        public Dish dish { get; set; }
        public List<Chef> AllChefs { get; set; }
    }
}