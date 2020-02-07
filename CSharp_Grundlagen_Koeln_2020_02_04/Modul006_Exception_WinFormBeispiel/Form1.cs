using Modul006_Exception_WinFormBeispiel_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul006_Exception_WinFormBeispiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textEingabe = textBox1.Text;

            MeineKlasse meineKlasse = new MeineKlasse();

            int retValue = 0;
            try
            {
                retValue = meineKlasse.GebeEineZahlZurueck(textEingabe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("Hey liebe PC-Maus, du hast den Button-Bereich verlassen");
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("KeyPress: Es wurde eine Taste gedrückt");
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("KeyDown: Es wurde eine Taste gedrückt");
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("KeyUp: Es wurde eine Taste gedrückt");
        }
    }
}
