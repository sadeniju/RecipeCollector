using System.Windows;
using RecipeCollector.Models;
using System;

namespace RecipeCollector.View{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow() {
            InitializeComponent();
            RecipeManager recipeManager = new RecipeManager();

            Recipe SuperSuppe = new Recipe("Bärlauchsuppe");
            recipeManager.RecipeCollection.Recipes.Add(SuperSuppe);

            this.DataContext = recipeManager.RecipeCollection;
        }

        private Random random = new Random();

        private void Button_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            Window newRecipeWindow = new AddNewRecipeWindow();
            newRecipeWindow.DataContext = this.DataContext as RecipeCollection;
            newRecipeWindow.Show();
        }
    }
}
