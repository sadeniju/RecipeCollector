using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCollector.Models{
    public class Ingredient{
        private string name;
        private float amount;

        #region Properties
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public Unit Unit { get; set; }

        public IngredientType IngredientType { get; set; }

        public float Amount {
            get { return amount; }
            set { amount = value; }
        }
        #endregion

        #region Construction
        public Ingredient(string name, float amount, IngredientType ingredientType, Unit unit):this(name, ingredientType, unit){
            Amount = amount;
        }

        public Ingredient(string name, IngredientType ingredientType, Unit unit) {
            Name = name;
            IngredientType = ingredientType;
            Unit = unit;
        }
        #endregion
    }
}
