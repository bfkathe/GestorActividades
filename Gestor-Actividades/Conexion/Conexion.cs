using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Gestor_Actividades.Conexion
{
    public class Conexion
    {
        /*Cadena André*/
        //private string cadena = "Data Source=ANDRE\\SQLEXPRESS ; Initial Catalog=ProyectoGestorActividades; Integrated Security=True";

        /*Cadena Audra*/
        private string cadena = "Data Source=DESKTOP-7K75JTA\\SQLEXPRESS ; Initial Catalog=ProyectoGestorActividades; Integrated Security=True";

        /*Cadena Katherina*/
        //private string cadena = "Data Source= PONERAQUISTRING; Initial Catalog=ProyectoGestorActividades; Integrated Security=True";

        public SqlConnection conn = new SqlConnection();

        public Conexion()
        {
            conn.ConnectionString = cadena;

            System.Diagnostics.Debug.WriteLine("Conexion abierta");
        }

      

        public void Abrir()
        {
            try
            {
                conn.Open();
                System.Diagnostics.Debug.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Conexion fallida" + ex.Message);
            }
        }

        public void Cerrar()
        {
            conn.Close();
        }

     }   

}