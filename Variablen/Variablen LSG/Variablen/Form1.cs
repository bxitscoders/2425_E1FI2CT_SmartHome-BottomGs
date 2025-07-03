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
        //Variablen werden ganz oben in der Klasse deklariert.
        //Damit sind sie in der ganzen Klassen verfügbar.
        //Der "_" kennzeichnet sie als Klassenvariablen (= Eigenschaften)
        string _vorname;
        string _nachname;
        string _gebJahr;
        string _ort;
        string _abteilung;
        double _gehaltAlt;
        double _gehaltNeu;

        public Personaldaten()
        {
            InitializeComponent();
        }

        private void btnVN_Click(object sender, EventArgs e)
        {
            
            _vorname = txtEingabe.Text;
            txtEingabe.Text = "";
        }
        
        private void btnNN_Click(object sender, EventArgs e)
        {
            _nachname = txtEingabe.Text;

        }

        private void btnGeb_Click(object sender, EventArgs e)
        {
            _gebJahr = txtEingabe.Text;
        }

        private void btnOrt_Click(object sender, EventArgs e)
        {
            _ort = txtEingabe.Text;
        }

        private void btnAbteilung_Click(object sender, EventArgs e)
        {
            _abteilung = txtEingabe.Text;
        }

        private void btnGehalt_Click(object sender, EventArgs e)
        {
            //double gehalt = Convert.ToDouble(txtEingabe.Text);
            //Die Eingabe in der Variable gehalt "merken".
            _gehaltAlt = Convert.ToDouble(txtEingabe.Text);
        }

        private void btnGenerieren_Click(object sender, EventArgs e)
        {
            //Ausgabestring zusammensetzen und ausgeben.
            //Geben Sie das alte und neue Gehalt aus, sowie das aktuelle Alter.
            int aktuellesAlter = DateTime.Now.Year - Convert.ToInt32(_gebJahr);
            
            lblAusgabe.Text =
                _vorname + ", " + _nachname + 
                ", Alter: " + aktuellesAlter + ", Ort" + _ort +
                ", Abt.:" + _abteilung + ", Gehalt alt:" + _gehaltAlt + ", neu: " +
                _gehaltNeu;
        }

        private void btnGehaltHoch_Click(object sender, EventArgs e)
        {
            _gehaltNeu = _gehaltAlt * 1.05;
        }
    }
}
