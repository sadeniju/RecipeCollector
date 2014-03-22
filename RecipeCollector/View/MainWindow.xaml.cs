using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RecipeCollector.Models;
using RecipeCollector.ViewModels;


namespace RecipeCollector.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            RecipeBookViewModel book = new RecipeBookViewModel();
            

            Recipe SuperSuppe = new Recipe("Suppe");
            book.Recipes.Add(SuperSuppe);

            this.DataContext = book;
        }
    }
}
