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

namespace MaPremiereApplicationWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void MonPremierDelegate(String str);

        event MonPremierDelegate MonPremierEvenement;

        Button MonSecondBouton;

        public MainWindow()
        {
            InitializeComponent();

            MonSecondBouton = new Button();
            MonSecondBouton.Content = "Ceci est un deuxième bouton";
            MonSecondBouton.Click += MonSecondBouton_Click;

            MonPremierStackPanel.Children.Add(MonSecondBouton);

            MonPremierEvenement += (str) =>
            {
                MonPremierLabel.Content = str;
            };
        }

        private void MonPremierBouton_Click(object sender, RoutedEventArgs e)
        {
            MonPremierEvenement("Premier Bouton");
        }

        private void MonSecondBouton_Click(object sender, RoutedEventArgs e)
        {
            MonPremierEvenement("Second Bouton");
        }
        
    }
}
