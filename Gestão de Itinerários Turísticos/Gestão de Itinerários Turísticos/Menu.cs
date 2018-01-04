using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Itinerários_Turísticos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Abrir o Login
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
        }

        //Abrir o Registo
        private void registoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registo = new Registo();
            registo.Show();
        }

        //Sair da Aplicação
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verItineráriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form itinerarios = new Itinerarios();
            itinerarios.Show();
        }
    }
}
