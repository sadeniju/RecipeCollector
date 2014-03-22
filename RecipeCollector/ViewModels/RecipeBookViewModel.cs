using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using RecipeCollector.Models;
namespace RecipeCollector.ViewModels {
    
    public class RecipeBookViewModel {
        public ObservableCollection<Recipe> Recipes { get; set; }
        public RecipeBookViewModel(){
            Recipes = new ObservableCollection<Recipe>();
            Recipes.Add(new Recipe("blaa"));
        }
        
    }
}
