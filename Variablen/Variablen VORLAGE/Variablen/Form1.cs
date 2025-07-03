using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Variablen
{
    public partial class Personaldaten : Form
    {

        //Klassenvariable steht allen Methoden 
        //zur Verfügung.
        //(=Eigenschaft, Property, Member, Attribut)
        double _gehalt;
        string _vorname;
        string _nachname;
        string _ort;
        string _gebJahr;
        string _abteilung;


        public Personaldaten()
        {
            InitializeComponent();
        }

        private void btnVN_Click(object sender, EventArgs e)
        {
            UebernehmeDaten(_vorname);

        }

        private void btnNN_Click(object sender, EventArgs e)
        {
            UebernehmeDaten(_nachname);
            
        }

        private void btnGeb_Click(object sender, EventArgs e)
        {
            UebernehmeDaten(_gebJahr);
          

        }

        private void btnOrt_Click(object sender, EventArgs e)
        {
            UebernehmeDaten(_ort);
           
           

        }

        private void UebernehmeDaten(object var)
        {
            if (txtEingabe.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie das Textfeld jetzt aus.");
            }
            else
            {
                if (var is Double)
                {
                    var = Convert.ToDouble(txtEingabe.Text);
                }
                else
                {
                    var = txtEingabe.Text;
                }
                txtEingabe.Text = "";
            }
        }

        private void btnAbteilung_Click(object sender, EventArgs e)
        {
            UebernehmeDaten(_abteilung);
           

        }

        private void btnGehalt_Click(object sender, EventArgs e)
        {
            //double gehalt; //deklarieren
            //gehalt = 0.0;  //initialisieren

            ////Deklaration und Initialisierung in einem:
            //double gehalt = 0.0;

            //Deklaraion und Initialisierung gleich mit dem 
            //richtigen Wert
            //Der Gültigkeitsbereich (Scope) ist diese Methode.
            //lokale (Hilfs-)Variable.
            UebernehmeDaten(_gehalt);
           
            

            //Geht auch.
            //gehalt = double.Parse(txtEingabe.Text);
            //unsauber, aber geht
            //Vorteil: stürzt nicht ab...
            //bool hatGeklappt = double.TryParse(txtEingabe.Text, out gehalt);

            //Die Eingabe in der Variable gehalt "merken".
            //decimal gehalt_d;
            //float gehalt_f;
        }

        private void btnGenerieren_Click(object sender, EventArgs e)
        {
            //Ausgabestring zusammensetzen und ausgeben.
            //Geben Sie das alte und neue Gehalt aus, sowie das aktuelle Alter.
            //int aktuellesAlter = DateTime.Now.Year - Convert.ToInt32(_gebJahr);

            lblAusgabe.Text = $"" +
                $"Vorname: {_vorname}" + Environment.NewLine +
                $"Nachname: {_nachname}" + Environment.NewLine +
                $"GebJahr: {_gebJahr}" + Environment.NewLine +
                $"Ort: {_ort}" + Environment.NewLine +
                $"Abteilung: {_abteilung}" + Environment.NewLine +
                $"Gehalt: {_gehalt}";
        }

        private void btnGehaltHoch_Click(object sender, EventArgs e)
        {
            _gehalt = _gehalt * 1.05;

        }
    }
}
