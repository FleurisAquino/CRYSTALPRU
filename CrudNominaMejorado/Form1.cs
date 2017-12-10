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
        private string v;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("user.png");
        }

        public Form1(string v)
        {
            this.v = v;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btcre_Click(object sender, EventArgs e)
        {
            Form forma = new frmcargo();
            forma.Show();
        }

        private void btcrear_Click(object sender, EventArgs e)
        {
           
            coneccion oper = new coneccion();
            oper.insertar(" INSERT INTO empleado (nombre, apellido, sexo, fecha_nacimiento, fcha_ingreso, fkcod_cargo, fkcod_depart )VALUES('" + tbnombre.Text.ToString() + "','" + tbapellido.Text.ToString() + "','"+cbsexo.Text.ToString()+"','"+dtpfchnc.Text.ToString()+"','"+dtpingreso.Text.ToString()+"','"+tbcargo.Text.ToString()+"','"+tbdepart.Text.ToString()+"')");

                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coneccion oper = new coneccion();
            oper.insertar(" UPDATE empleado SET nombre='" + tbnombre.Text.ToString() + "', apellido='" + tbapellido.Text.ToString() + "' WHERE codigo_emp='" + tbcodigo.Text + "'");
        }

        private void btconsulta_Click(object sender, EventArgs e)
        {
            coneccion oper = new coneccion();
            DataSet ds = new DataSet();
            ds = oper.MostrarData("SELECT nombre, apellido, codigo_emp FROM empleado WHERE codigo_emp='"+tbcodigo.Text.ToString()+"'");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                tbcodigo.Text = fila["codigo_emp"].ToString();
                tbnombre.Text = fila["nombre"].ToString();
                tbapellido.Text = fila["apellido"].ToString();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form forma = new DGVEmpleados();
            forma.Show();
        }

        private void todosLosEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new DGVEmpleados();
            forma.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            
           coneccion oper = new coneccion();
           DataSet ds = oper.MostrarData(" select codigo_emp, nombre, apellido from empleado   ");
           ds.WriteXml("c:\\SQLite\\SQLite\\cnxpruva.xml");

           reportes f = new reportes("CrystalReport2.rpt");
           f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form forma = new frmDepart();
            forma.Show();
        }
    }
}
