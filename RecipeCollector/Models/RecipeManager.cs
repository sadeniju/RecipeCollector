using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace RecipeCollector.Models {
    public class RecipeManager {
        public RecipeCollection RecipeCollection { get; private set; }

        public RecipeManager() {
            Load();
            Save();
        }

        public void Load() {
            RecipeCollection = new RecipeCollection();
        }

        public void Save() {
            XmlWriter.WriteDocument(RecipeCollection);
        }
    }
}
