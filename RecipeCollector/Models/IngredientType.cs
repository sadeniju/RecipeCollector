using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RecipeCollector.Models {
    public enum IngredientType {
        [Description("Fleisch")]
        Meat,
        [Description("Fisch")]
        Fish,
        [Description("Gemüse")]
        Vegetable,
        [Description("Obst")]
        Fruit,
        [Description("Gewürz")]
        Spice,
        [Description("Nuss")]
        Nut
    }
}
