using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RecipeCollector.Models {
    public static class XmlWriter {
        public static void WriteDocument(RecipeCollection recipeCollection) {
            // Create an xml document
            XDocument doc = new XDocument(new XDeclaration("1.0", "UTF-8", "no"));

            // Define the root element
            XElement root = new XElement("recipe_collection", new XAttribute("version", 1.0f));
            doc.Add(root);

            // Add recipe elements for each recipe
            foreach(Recipe recipe in recipeCollection.Recipes) {
                XElement recipeElement = new XElement("recipe",
                    new XElement("title", recipe.Name)
                    /* @TODO add other recipe attributes */);
                
                // Define the recipe's list of ingredients
                XElement ingredientsElement = new XElement("ingredients");

                // Add an ingredient element for each ingredient
                foreach(Ingredient ingredient in recipe.Ingredients) {
                    ingredientsElement.Add(new XElement("ingredient"),
                        new XElement("name", ingredient.Name)
                        /* @TODO add other ingredient attributes */);
                }

                recipeElement.Add(ingredientsElement);
                root.Add(recipeElement);
            }

            doc.Save("recipe_collection.xml");    // save the xml document (to ../projectname/bin/debug/)
        }
    }
}
