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

namespace ExerciceDockPanel_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChoisirCouleur_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = sender as Button;
            string nomCouleur = bouton.Content.ToString();
            tbCouleur.Background = (Brush)new BrushConverter().ConvertFromString(nomCouleur);
            btnAqua.FontWeight = btnCrimson.FontWeight = btnLime.FontWeight = btnPeru.FontWeight = FontWeights.Normal;
            bouton.FontWeight = FontWeights.Bold;
        }
    }
}
