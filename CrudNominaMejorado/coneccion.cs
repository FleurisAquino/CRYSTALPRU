using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms;




namespace CrudNominaMejorado
{
    class coneccion
    {
        SQLiteConnection cnx;
        SQLiteCommand cmd;
        SQLiteDataReader dt;

        public coneccion()
        {
            try
            {
                cnx = new SQLiteConnection("Data Source = C:\\SQLite\\cnxpruva.db;Vercion=3;");
                cnx.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No establesida:" + ex.ToString());
            }
        
        }
        public string insertar(int codigo, string nombre, string apellido, string fecha)
        {
            string salida = "Se Guardo";
            try
            {
                cmd = new SQLiteCommand("insert into empleado (codigo_emp,nombre,apellido,fecha_nacimiento)values(" + codigo + ",'" + nombre + "','" + apellido + "','" + fecha + "')");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "NO GUARDADO:" + ex.ToString();
            }
            return salida;
        }
        public int personaregistrada (int codigo)
        {
            int contador = 0;
            try
            {
                cmd = new SQLiteCommand("select * from empleado where codigo =(" + codigo + ")");
                dt = cmd.ExecuteReader();
                while (dt.Read()) 
                {
                    contador++;
                }
                dt.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No Registrado" + ex.ToString());
            }
            return contador;
        }
        
       
    }
   
}   
