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
        //private string cadena = "Data Source=DESKTOP-7K75JTA\\SQLEXPRESS ; Initial Catalog=ProyectoGestorActividades; Integrated Security=True";

        /*Cadena Katherina*/
        private string cadena = "Data Source = KATHERINA\\KATHERINABD;Initial Catalog = ProyectoGestorActividades; Integrated Security = True";
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

        //Agregar usuarios de staff a la BD 
        public void agregarStaff(Staff usuarioStaff)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("agregarStaff", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@nombre", usuarioStaff.getNombre()));
                command.Parameters.Add(new SqlParameter("@nombreUsuario", usuarioStaff.getUsuario()));
                command.Parameters.Add(new SqlParameter("@contrasenna", usuarioStaff.getContraseña()));
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
                command.Parameters.Add(new SqlParameter("@lugar", actividad.getLugar()));
                command.Parameters.Add(new SqlParameter("@Descripcion", actividad.getDescripcion()));
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

        public void editarActividad(Modelo.Actividad actividad, int id)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("editarActividad", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", id));
                command.Parameters.Add(new SqlParameter("@Fecha", actividad.getFecha()));
                command.Parameters.Add(new SqlParameter("@Nombre", actividad.getNombre()));
                command.Parameters.Add(new SqlParameter("@Horario", actividad.getHorario()));
                command.Parameters.Add(new SqlParameter("@Campus", actividad.getCampus()));
                command.Parameters.Add(new SqlParameter("@Restriccion", actividad.getRestriccion()));
                command.Parameters.Add(new SqlParameter("@Encargado", actividad.getEncargado()));
                command.Parameters.Add(new SqlParameter("@CantCupos", actividad.getCantCupos()));
                command.Parameters.Add(new SqlParameter("@lugar", actividad.getLugar()));
                command.Parameters.Add(new SqlParameter("@Descripcion", actividad.getDescripcion()));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Actividad editada correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al editar actividad");
            }
        }

        public void eliminarActividad(int id)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("eliminarActividad", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Actividad eliminada correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al eliminar actividad");
            }
        }

        public List<Modelo.Lista> llenarActividades()
        {
            List<Modelo.Lista> list = new List<Modelo.Lista>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select ActividadId, Nombre from Actividades", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Modelo.Lista {
                        id = rdr.GetInt32(0),
                        nombre = rdr.GetString(1) 
                        
                    });
                }
                rdr.Close();
                return list;
            }
            catch(Exception ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al obtener actividades");
                list.Add(new Modelo.Lista
                {
                    id = -1,
                    nombre = "Error"

                });
                return list;
                
            }
        }

        public void agregarEvento(Modelo.Evento evento)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("insertarEvento", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@idActividad", evento.getIdActividad()));
                command.Parameters.Add(new SqlParameter("@Nombre", evento.getNombre()));
                command.Parameters.Add(new SqlParameter("@Horario", evento.getHorario()));
                command.Parameters.Add(new SqlParameter("@Expositor", evento.getExpositor()));
                command.Parameters.Add(new SqlParameter("@Descripcion", evento.getDescripcion()));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Evento agregado correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al insertar evento DAODB");
            }
        }

        public void editarEvento(Modelo.Evento evento, int id)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("editarEvento", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", id));
                command.Parameters.Add(new SqlParameter("@idActividad", evento.getIdActividad()));
                command.Parameters.Add(new SqlParameter("@Nombre", evento.getNombre()));
                command.Parameters.Add(new SqlParameter("@Horario", evento.getHorario()));
                command.Parameters.Add(new SqlParameter("@Expositor", evento.getExpositor()));
                command.Parameters.Add(new SqlParameter("@Descripcion", evento.getDescripcion()));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Evento editado correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al editar evento");
            }
        }

        public void eliminarEvento(int id)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("eliminarEvento", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Evento eliminado correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al eliminar evento");
            }
        }
        public List<Modelo.Lista> llenarEventos(int idActividad)
        {
            List<Modelo.Lista> list = new List<Modelo.Lista>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select EventosId, Nombre from Eventos where ActividadId = "+ idActividad, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Modelo.Lista
                    {
                        id = rdr.GetInt32(0),
                        nombre = rdr.GetString(1)

                    });
                }
                rdr.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al obtener eventos");
                list.Add(new Modelo.Lista
                {
                    id = -1,
                    nombre = "Error"

                });
                return list;

            }
        }


        public int VerificarLogin(string pUsuario, string pContrasenna)
        {
            int resultado = 0;
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("verificarLoginUsuarios", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Usuario", pUsuario));
                command.Parameters.Add(new SqlParameter("@Pass", pContrasenna));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    resultado = 1;
                else
                    resultado = 0;                         
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return resultado;
        }


        public int verificarStaffUnico(string nombreUsuario)
        {
            int resultado = 0;
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("staffUnico", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@nombreUsuario", nombreUsuario));
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    resultado = 1;
                else
                    resultado = 0;
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return resultado;
        }



    }   

}