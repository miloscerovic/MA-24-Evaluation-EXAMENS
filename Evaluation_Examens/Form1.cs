using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Milos Cerovic
   Evaluation Examens
   04.04.2019
   
   Ce programme permet a l'utilisateur d'afficher la date et l'heure en temps reel
   A l'aide du button pause il arrete le timer et avec play il relance le timer
   Ce programme est fait dans le but du Module MA-24 "Appui de programmation et outil de developpement"
   Il sera pusher sur github et ce grace aux informations donnees durant le cours MA-24*/
namespace Evaluation_Examens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeTimer()
        {
            //Initialisation du timer a 1000 ms soit 1 seconde
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;

            //Changement du label button1 en "Stop"
            button1.Text = "Stop";
            button1.Click += new EventHandler(button1_Click);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Stop")
            {
                //Changement du label Stop en "Start"
                button1.Text = "Start";
                //Mise en pause du timer
                timer1.Enabled = false;
            }
            else
            {
                //Changement du label Start en "Stop"
                button1.Text = "Stop";
                //Activation du timer
                timer1.Enabled = true;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {   
            //Utilisation du Timer "DateTime" permettant de donner l'heure et la date exacte
            label1.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
