using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace LottoStatistik
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] _strichliste = new int[49]; //49 Stück zu erreichen über [0]...[48]
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEinlesen_Click(object sender, RoutedEventArgs e)
        {
            int lineCounter = 0;


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            string fileAndPath = ofd.FileName;

            FileStream fs = new FileStream(fileAndPath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] teile = line.Split(',');

                string mittlererTeil = teile[1];
                string[] zahlen = mittlererTeil.Split('-'); //1-2-16-20-22-32

                for (int i = 0; i < 6; i++)
                {
                    _strichliste[Convert.ToInt32(zahlen[i])-1]++;
                }

            }



            //1,54,349867
            //deklariere
            int[] dieZahlen = new int[3];

            //greife ich zu
            dieZahlen[0] = 1;
            dieZahlen[2] = 349867;
            dieZahlen[1] = 54;

            int eineZahl = dieZahlen[2];
            eineZahl = dieZahlen[3];

            //ein Array of 45 strings
            string[] zahlen = new string[45];

            zahlen[17] = Convert.ToString(dieZahlen[2]);


























                //while ()
                //{
                //    ...
                //}

                //Ausgabe
                //.Length gibt die aktuelle Länge des Arrays an. Hier also 50.
                for (int lz = 1; lz < _lottozahlen.Length; lz++)
            {
                txbAusgabe.Text += $"Lottozahl: {lz} -> Häufigkeit: {_lottozahlen[lz]}" + Environment.NewLine;
            }


        }
    }
}
