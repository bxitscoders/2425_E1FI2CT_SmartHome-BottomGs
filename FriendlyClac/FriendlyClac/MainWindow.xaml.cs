using System;
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

namespace FriendlyClac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //C#-Befehle/Schlüsselworte
            int a = 2500;
            int b = 17;
            int ergebnis = a + b;

            //Console.WriteLine(ergebnis);
            //lblAusgabe.Content = $"Das Ergebnis ist: {ergebnis}";
            lblAusgabe.Content = "Das Ergebnis ist: " + ergebnis;

            //Hallo Computer, was ist 2500 plus 17.Bitte eine schöne Anrede beim Ergebnis.
        }
    }
}