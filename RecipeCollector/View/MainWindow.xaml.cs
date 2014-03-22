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
            // @TODO Click behaviour
            int i = random.Next(6);
            
            switch(i) {
                case 0:
                    FunnyBlock.Text += "Ouch! ";
                    break;
                case 1:
                    FunnyBlock.Text += "Hit me harder! ";
                    break;
                case 2:
                    FunnyBlock.Text += "Push me. ";
                    break;
                case 3:
                    FunnyBlock.Text += "Push me real good. ";
                    break;
                case 4:
                    FunnyBlock.Text += "Uuuh, that hurt a litte... ";
                    break;
                case 5:
                    FunnyBlock.Text += "Why are you so mean to me? ";
                    break;
            }
            
        }
    }
}
