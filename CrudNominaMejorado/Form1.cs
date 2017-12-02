using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrudNominaMejorado
{
    public partial class Form1 : Form
    {
        coneccion con = new coneccion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btcre_Click(object sender, EventArgs e)
        {

        }

        private void btcrear_Click(object sender, EventArgs e)
        {
            if (con.personaregistrada(Convert.ToInt32(tbcodigo.Text))==0)
            {
                
                MessageBox.Show(con.insertar(Convert.ToInt32(tbcodigo.Text), tbnombre.Text, tbapellido.Text, dtpfchnc.Text));
            }
            else
            {
                MessageBox.Show("No insertado");
            }
        }
    }
}
