using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Gestor_Actividades.Modelo;

namespace Gestor_Actividades.Negocio
{
    public class DAOBD
    {
        /*Cadena André*/
        //private string cadena = "Data Source=ANDRE\\SQLEXPRESS ; Initial Catalog=ProyectoGestorActividades; Integrated Security=True";

        /*Cadena Audra*/
        private string cadena = "Data Source=DESKTOP-7K75JTA\\SQLEXPRESS ; Initial Catalog=ProyectoGestorActividades; Integrated Security=True";

        /*Cadena Katherina*/
        //private string cadena = "Data Source = KATHERINA\\KATHERINABD;Initial Catalog = ProyectoGestorActividades; Integrated Security = True";
        public SqlConnection conn = new SqlConnection();

        public DAOBD()
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


        // -- CONSULTAS --

        //Agregar usuarios de staff a la BD (Prueba)
        public void agregarStaff(string nombre, string nombreUsuario, string contrasenna)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("agregarStaff", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@nombre", nombre));
                command.Parameters.Add(new SqlParameter("@nombreUsuario", nombreUsuario));
                command.Parameters.Add(new SqlParameter("@contrasenna", contrasenna));
                command.ExecuteNonQuery();
                if(conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Usuario Staff agregado");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al insertar usuario Staff");
            }
        }

        public void agregarActividad(Modelo.Actividad actividad)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("insertarActividad", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Fecha", actividad.getFecha()));
                command.Parameters.Add(new SqlParameter("@Nombre", actividad.getNombre()));
                command.Parameters.Add(new SqlParameter("@Horario", actividad.getHorario()));
                command.Parameters.Add(new SqlParameter("@Campus", actividad.getCampus()));
                command.Parameters.Add(new SqlParameter("@Restriccion", actividad.getRestriccion()));
                command.Parameters.Add(new SqlParameter("@Encargado", actividad.getEncargado()));
                command.Parameters.Add(new SqlParameter("@CantCupos", actividad.getCantCupos()));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Actividad agregada correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al insertar actividad");
            }
        }


    }   

}