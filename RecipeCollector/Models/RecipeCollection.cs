using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace RecipeCollector.Models {
    public class RecipeCollection {
        public String Title { get; private set; }
        public ObservableCollection<Recipe> Recipes { get; private set; }
        public ObservableCollection<Ingredient> Ingredients { get; private set; }

        public RecipeCollection() {
            Title = "Recipes";
            Recipes = new ObservableCollection<Recipe>();
            Ingredients = new ObservableCollection<Ingredient>();
        }
    }
}
