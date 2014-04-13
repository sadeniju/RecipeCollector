using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeCollector.Models{
    public class Ingredient{
        #region Properties
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public string Amount{get;set;}
        #endregion

        #region Construction
        public Ingredient(string name, string amount){
            Name = name;
            Amount = amount;
        }
        #endregion

        public override string ToString(){
            return Amount + " " + Name;
        }
    }
}
