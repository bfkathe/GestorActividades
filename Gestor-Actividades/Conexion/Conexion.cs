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
        private string cadena = "Data Source=ANDRE\\SQLEXPRESS ; Initial Catalog=ProyectoGestorActividades; Integrated Security=True";
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

        public void cerrar()
        {
            conn.Close();
        }

        /*public void agregarNombre(string nombre, int edad)
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
        }*/
    }
}