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
<<<<<<< HEAD
        private string cadena = "Data Source=ANDRE\\SQLEXPRESS ; Initial Catalog=ProyectoGestorActividades; Integrated Security=True";
=======
        private string cadena = "Data Source=DESKTOP-7K75JTA\\SQLEXPRESS ; Initial Catalog=prueba; Integrated Security=True";
>>>>>>> 2780fb56d7716dc8e5b4a58c545e1648bed0d7d5
        public SqlConnection conn = new SqlConnection();

        public Conexion()
        {
            conn.ConnectionString = cadena;
<<<<<<< HEAD
            System.Diagnostics.Debug.WriteLine("Conexion abierta");
        }
=======
            }
>>>>>>> 2780fb56d7716dc8e5b4a58c545e1648bed0d7d5

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

        public void cerrar()
        {
            conn.Close();
        }

<<<<<<< HEAD
        /*public void agregarNombre(string nombre, int edad)
=======
        public void agregarNombre(string nombre, int edad)
>>>>>>> 2780fb56d7716dc8e5b4a58c545e1648bed0d7d5
        {
            SqlCommand cmd = new SqlCommand("insNombre", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add("@nombre",SqlDbType
                    .NChar).Value = nombre;
                cmd.Parameters.Add("@edad", SqlDbType.Int).Value = edad;
                Abrir();
                cmd.ExecuteNonQuery();
                cerrar();
            }
            catch
            {
                throw new System.Exception("Error insertando en la base");
            }
<<<<<<< HEAD
        }*/
=======
        }
>>>>>>> 2780fb56d7716dc8e5b4a58c545e1648bed0d7d5
    }
}