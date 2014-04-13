using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RecipeCollector.Models {
    //public enum Category{
    //    [Description("Fleisch")]
    //    Meat,
    //    [Description("Fisch")]
    //    Fish,
    //    [Description("Gemüse")]
    //    Vegetable,
    //    [Description("Obst")]
    //    Fruit,
    //    [Description("Vegetarisch")]
    //    Vegie,
    //    [Description("Fruestueck")]
    //    Breakfast,
    //    [Description("Mittagessen")]
    //    Lunch,
    //    [Description("Abendessen")]
    //    Diner,
    //    [Description("Sommer")]
    //    Summer,
    //    [Description("Winter")]
    //    Winter
    //}
    public class Recipe: NotifyableClass {
        string name;
        #region Properties
        public string Name { 
            get { return name; }
            set{
                if (value != name){
                    name = value;
                    RaiseNamePropertyChanged();
                }
            }
        }
        public ObservableCollection<Ingredient> Ingredients {get; set;}
        public ObservableCollection<string> Instructions { get; set; }
       
        /*
        public List<Categorie> categories;
        

        public int PenguinRating {
            get { return penguinRating; }
            set {
                if(value > -1 && value < 6) {
                    penguinRating = value;
                }
                else {
                    
                }
            }
        }

        public int OnionRating {
            get { return onionRating; }
            set { if (value > -1 && value < 6){
                    onionRating = value;
                  }
                  else {
                    
                  }
                }
        }
        */
        #endregion

        public Recipe(string name, ObservableCollection<Ingredient> ingredients, ObservableCollection<string> instructions){
            Name = name;
            Ingredients = ingredients;
            Instructions = instructions;
        }

        public override String ToString() {
            return Name;
        }

        public void RaiseNamePropertyChanged(){
            RaisePropertyChanged("Name");
        }
    }
}
