using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RecipeCollector.Models {
    public enum Category{
        [Description("Fleisch")]
        Meat,
        [Description("Fisch")]
        Fish,
        [Description("Gemüse")]
        Vegetable,
        [Description("Obst")]
        Fruit,
        [Description("Vegetarisch")]
        Vegie,
        [Description("Fruestueck")]
        Breakfast,
        [Description("Mittagessen")]
        Lunch,
        [Description("Abendessen")]
        Diner,
        [Description("Sommer")]
        Summer,
        [Description("Winter")]
        Winter
    }
    public class Recipe {
        private string name;
        //private List<Ingredient> ingredients;
        //private List<string> instructions;
        //private List<Category> categories; /* auslagern?*/
        private int penguinRating;
        private int onionRating;

        #region Properties
        public string Name {
            get { return name; }
            set { name = value; }
        }
       
        public List<Ingredient> Ingredients {
            get;
            set;
        }
         /*TODO
        public List<string> instructions;
       
        public List<Categorie> categories;
        */

        public int PenguinRating {
            get { return penguinRating; }
            set {
                if(value > -1 && value < 6) {
                    penguinRating = value;
                }
                else {
                    /*TODO Error propagieren?*/
                }
            }
        }

        public int OnionRating {
            get { return onionRating; }
            set { if (value > -1 && value < 6){
                    onionRating = value;
                  }
                  else {
                    /*TODO Error propagieren?*/ 
                  }
                }
        }
        #endregion
        /* bekommt man listen übergeben oder machen wir die hier iwo und adden?*/
        #region Construction 

        public Recipe(string name, int penguinRating, int onionRating) {
            Ingredients = new List<Ingredient>(); 
        }

        public Recipe() {
            // TODO: Complete member initialization
        }

        public Recipe(string name) {
            // TODO: Complete member initialization
            this.Name = name;
        }

        #endregion

        public override String ToString() {
            Console.WriteLine(Name);
            return "Recipe: "+Name;
        }
    }
}
