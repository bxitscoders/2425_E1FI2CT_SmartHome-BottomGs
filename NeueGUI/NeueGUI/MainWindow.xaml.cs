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

namespace NeueGUI
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

        private void btn_Name_Click(object sender, RoutedEventArgs e)
        {
            lbl_Name.Content = "Hallo " + txb_Name.Text;
            string textTextbox = "Florian,Matthias";
            int ganzzahl = 0;
            float gleitkommazahl = 0;
            double gleitkomma = 0;
            bool istWahr = false;
            char charakter = ',';
            long großeGanzzahl = 0;

            string[] stringArray = textTextbox.Split(charakter);
            lbl_Name.Content = stringArray[1];
        }

        private void txb_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!(txb_Name.Text.Length > 2))
            {
                lbl_Name.Content = "Bitte mindestens 3 Zeichen eingeben";
                btn_Name.IsEnabled = false;
            } else
            {
                lbl_Name.Content = "";
                btn_Name.IsEnabled = true;
            }
        }
    }
}