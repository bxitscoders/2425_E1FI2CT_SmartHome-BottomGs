using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace MaxTemp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Diese Routine (EventHandler des Buttons Auswerten) liest die Werte
        /// zeilenweise aus der Datei temps.csv aus, merkt sich den höchsten Wert
        /// und gibt diesen auf der Oberfläche aus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAuswerten_Click(object sender, RoutedEventArgs e)
        {

            //Anfangswert setzen, um sinnvoll vergleichen zu können.
            double maxTemp = 0.0;

            //Zugriff auf Datei erstellen.
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            try
            {
                //Aussehen des File Dialogs anpassen
                openFileDialog.InitialDirectory = "C:\\Users\\Ge\\Downloads\\MaxTemp\\MaxTemp";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == true)
                {
                    var fileStream = openFileDialog.OpenFile();

                    StreamReader reader = new StreamReader(fileStream);
                    try
                    {
                        //In einer Schleife die Werte holen und auswerten. Den größten Wert "merken".
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string _aktTemp = line.Split(',')[2];
                            double aktTemp = Double.Parse(line.Split(',')[2], CultureInfo.InvariantCulture);
                            if (aktTemp > maxTemp)
                            {
                                maxTemp = aktTemp;
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Datei kann nicht gelesen werden");
                    }

                    //Datei wieder freigeben.
                    reader.Close();

                    //Höchstwert auf Oberfläche ausgeben.
                    lblAusgabe.Content = $"Die maximale Temperatur beträgt {maxTemp}°C";

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Datei kann nicht geladen werden.");
            }
        }
    }
}
