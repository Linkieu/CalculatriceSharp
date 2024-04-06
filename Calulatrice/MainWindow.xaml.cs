using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calulatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        string nombreEntree = "";
        string operation = "C";
        public MainWindow()
        {
            InitializeComponent();
            nouvelleOperation("C");
        }

        private void Chiffre_Click(object sender, RoutedEventArgs e)
        {
            // Convertir le sender en Button
            if (sender is Button button)
            {
                // Ajoute à la suite des nombres entrés le contenu du bouton (chiffre)
                string chiffre = button.Content.ToString();

                if (! (chiffre == "0" && nombreEntree == "")){
                    // Si on essaye pas d'ajouter de 0 dès le départ, quand nombreEntree est vide
                    nombreEntree += chiffre;
                    numberDisplay.Text = nombreEntree;
                    nouvelleOperation("");
                }

            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e){
            // Convertir le sender en Button
            if (sender is Button button)
            {
                nombreEntree = "";
                numberDisplay.Text = "0";
                nouvelleOperation("C");
            }
        }

        private void nouvelleOperation(string nOperation){
            operation = nOperation;
            if (operation == "C") { boutonReset.IsEnabled = false; } else { boutonReset.IsEnabled = true; }
        }
    }
}
