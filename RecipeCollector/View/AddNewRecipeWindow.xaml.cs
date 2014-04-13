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
using System.Windows.Shapes;

namespace RecipeCollector.View
{
    /// <summary>
    /// Interaktionslogik für AddNewRecipeWindow.xaml
    /// </summary>
    public partial class AddNewRecipeWindow : Window
    {
        public AddNewRecipeWindow()
        {
            InitializeComponent();
        }

        private void Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e){
            // TODO Create new Recipe and save XML
            this.Close();
        }
    }
}
