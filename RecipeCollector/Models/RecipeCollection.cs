using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RecipeCollector.Models {
    public class RecipeCollection: NotifyableClass {
        public String Title { get; private set; }
        public ObservableCollection<Recipe> Recipes { get; private set; }
        private Recipe selectedRecipe = null;
        public Recipe SelectedRecipe {
            get { return selectedRecipe; }
            set{
                if (value != selectedRecipe){
                    selectedRecipe = value;
                    RaisePropertyChanged("SelectedRecipe");
                    selectedRecipe.RaiseNamePropertyChanged();
                }
            }
        }
        /// <summary>
        /// Fuer Auswahl beim Erstellen neuer Rezepte - verfuegbare Zutatenbezeichnungen.
        /// </summary>
        public ObservableCollection<string> IngredientNames { get; set; }

        public RecipeCollection() {
            Title = "Recipes";
            Recipes = new ObservableCollection<Recipe>();
            ObservableCollection<Ingredient> ingredients = new ObservableCollection<Ingredient>();
            ingredients.Add(new Ingredient("Zwiebeln", "3 Stück"));
            ObservableCollection<string> instructions = new ObservableCollection<string>();
            instructions.Add("1. Zwiebeln dünsten");
            instructions.Add("2. Zwiebeln essen");
            Recipes.Add(new Recipe("Gedünstete Zwiebeln", ingredients, instructions));
        }
    }
}
