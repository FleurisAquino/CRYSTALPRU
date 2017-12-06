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
    public partial class DGVEmpleados : Form
    {
        public DGVEmpleados()
        {
            InitializeComponent();
        }

        private void DGVEmpleados_Load(object sender, EventArgs e)
        {
            coneccion conec = new coneccion();
            DataSet ds = conec.MostrarData(" select e.codigo_emp, e.nombre, e.apellido, c.nombre, d.nombre from empleado e, cargo c, departamento d where e.fkcod_cargo=c.codigo and e.fkcod_depart=d.codigo");
            DGVempleado.DataSource = ds.Tables[0];
        }

        private void DGVempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 frm = new Form1(DGVempleado.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }
    }
}
