using Microsoft.Win32;
using System.IO;
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

namespace SkiPass
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

        private void btn_berechne_Click(object sender, RoutedEventArgs e)
        {
            /*Aufgabe 1 (17P)
            An jedem Skilift muss die Gültigkeit der Liftkarte überprüft werden. Dazu wird die Skipassnummer der
            Liftkarte ausgelesen, auf Gültigkeit überprüft und ein entsprechender Eintrag in die Logdatei
            ,,LogSkipass.txt" erstellt. Die Datei ist wie folgt aufgebaut:
            Datum | Uhrzeit | Skipassnummer | Passart | Liftnr. | Liftlänge
            
            Erstellen Sie ein Programm das die Log-Datei ausliest und für einen bestimmten
            Skipass die aufsummierten Liftlängen ermittelt und am Bildschirm ausgibt.

            Gehen Sie folgendermaßen vor:
            - Öffnen Sie die Datei mittels FileStream und StreamReader.
                 Achten Sie auf korrektes Öffnen UND Schließen!
            - Lesen Sie die Zeilen der Datei einzeln ein!!!
            - Berechnen Sie die
                # aufsummierten Liftkilometer
                Verwenden Sie geeignete Programmkonstrukte und vermeiden Sie redundanten Code.
            - Geben Sie den Wert, wie in der GUI gezeigt, aus.
               
              
            Bepunktung: Sauberer Dateizugriff 5P, Codeformatierung 2P, Logik 8P, Ausgabe 2P
            */
            string passNumber = txb_passnummer.Text;
            int gefahreneKm = 0;
            FileStream fileStream = new FileStream("SkiPass.csv", FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Split('|')[2] == passNumber)
                {
                    gefahreneKm += Int32.Parse(line.Split('|')[5]);
                }
            }
            reader.Close();
            fileStream.Close();

            lbl_Ergebnis.Content = $"Der Skifahrer ist {gefahreneKm} Liftkm gefahren.";

        }

        /*Aufgabe 2 (4P) - SCRUM
         * Welche "Termine" gibt es in einem Scrum Prozess?
         * 
         * Ihre Antwort:
         * 
         * Sprintplanung: Planung der Aufgaben für den Sprint
         * Dailies: tägliches Abstimmen
         * Sprint-Review: Vorstellen der Ergebnisse
         * Sprint-Retrospektive: Rückblick auf den Ablauf des Sprints
         *
         Aufgabe 3 (4P) - SCRUM
         * Welche Rollen gibt es bei Scrum?
         * 
         * Ihre Antwort:
         *
         * Stakeholder: Kunden, Abteilungen, Geldgeber
         * Objekt Owner: Verantwortlicher für dieses "Produkt"
         * Entwickler: Team, das an dem Produkt arbeitet
         * Scrum-Master: Verantwortlich für den Prozess
         *
         */
    }
}