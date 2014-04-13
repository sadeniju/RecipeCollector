using System.Windows;
using RecipeCollector.Models;
using System;
using System.Windows.Controls;

namespace RecipeCollector.View{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow() {
            InitializeComponent();
            RecipeManager recipeManager = new RecipeManager();
            this.DataContext = recipeManager.RecipeCollection;
        }

        private Random random = new Random();

        private void Button_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            Window newRecipeWindow = new AddNewRecipeWindow();
            newRecipeWindow.Owner = this;
            newRecipeWindow.DataContext = this.DataContext as RecipeCollection;
            newRecipeWindow.Show();
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e){
            (this.DataContext as RecipeCollection).SelectedRecipe = (sender as ListView).SelectedItem as Recipe;
        }
    }
}
