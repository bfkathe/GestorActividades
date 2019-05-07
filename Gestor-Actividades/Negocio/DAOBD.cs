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
        }

        public void Abrir()
        {
            try
            {
                conn.Open();
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
                System.Diagnostics.Debug.WriteLine("Error al insertar usuario Staff DAODB");
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
                command.Parameters.Add(new SqlParameter("@cantCupos", actividad.getCantCupos()));
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
                System.Diagnostics.Debug.WriteLine("Error al editar actividad",ex);
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

        public List<Actividad> datosActividades(int id)
        {
            List<Actividad> list = new List<Actividad>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select Fecha, Nombre, Horario, Campus, Restriccion, Encargado, CantCupos, Lugar, Descripcion from Actividades where ActividadId = " + id, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Actividad
                        (
                        rdr.GetDateTime(0),
                        rdr.GetString(1),
                        rdr.GetString(2),
                        rdr.GetString(3),
                        rdr.GetBoolean(4),
                        rdr.GetString(5),
                        rdr.GetInt32(6),
                        rdr.GetString(7),
                        rdr.GetString(8)
                        ));
                }
                rdr.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al obtener actividades");
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
                System.Diagnostics.Debug.WriteLine("Error al editar evento DAODB");
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

        public List<Evento> datosEventos(int id)
        {
            List<Evento> list = new List<Evento>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select ActividadId,Nombre, Horario, Expositor, Descripcion from Eventos where EventosId = " + id, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Evento
                        (
                        rdr.GetInt32(0),
                        rdr.GetString(1),
                        rdr.GetString(2),
                        rdr.GetString(3),
                        rdr.GetString(4)
                        ));
                }
                rdr.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al obtener eventos");
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

        public void agregarArchivo(Modelo.Archivo archivo)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("agregarArchivo", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Name", archivo.getNombre()));
                command.Parameters.Add(new SqlParameter("@FileType", archivo.getFormato()));
                command.Parameters.Add(new SqlParameter("@Data", archivo.getRuta()));
                command.Parameters.Add(new SqlParameter("@ActividadId", archivo.getIdActividad()));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Archivo agregado correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al insertar archivo");
            }
        }

        public void agregarArchivo2(byte[] contenido,string nombre,string extension)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("agregarArchivo", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Name",nombre));
                command.Parameters.Add(new SqlParameter("@FileType", extension));
                command.Parameters.Add(new SqlParameter("@Data", contenido));
                command.Parameters.Add(new SqlParameter("@ActividadId",2));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Archivo agregado correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al insertar archivo");
            }
        }





        public void eliminarArchivo(int id)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("eliminarArchivo", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", id));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Archivo eliminado correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al eliminar archivo");
            }
        }

        public List<Modelo.Lista> llenarArchivos(int idActividad)
        {
            List<Modelo.Lista> list = new List<Modelo.Lista>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select ArchivoId, Name from Archivos where ActividadId = " + idActividad, conn);
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
                System.Diagnostics.Debug.WriteLine("Error al obtener archivos");
                list.Add(new Modelo.Lista
                {
                    id = -1,
                    nombre = "Error"

                });
                return list;

            }
        }


        public List<Modelo.Lista> llenarStaff()
        {
            List<Lista> list = new List<Lista>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select StaffId,Nombre from Staff", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Lista
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
                System.Diagnostics.Debug.WriteLine("Error al obtener usuarios de Staff");
                list.Add(new Lista
                {
                    id = -1,
                    nombre = "Error"

                });
                return list;

            }
        }



        public void agregarStaffXActividad(int idActividad,List<int> listaStaff)
        {
            foreach (int idStaff in listaStaff)
            {
                try
                {
                    Abrir();
                    SqlCommand command = new SqlCommand("staffXActividadProc", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@idActividad", idActividad));
                    command.Parameters.Add(new SqlParameter("@idStaff", idStaff));
                    command.ExecuteNonQuery();


                    if (conn.State != ConnectionState.Closed)
                    {
                        Cerrar();
                    }
                    //Response.Write("<script>alert('correcto');</script>");
                    System.Diagnostics.Debug.WriteLine("Staff agregado a la actividad");
                }
                catch (SqlException ex)
                {
                    Console.Write(ex);
                    System.Diagnostics.Debug.WriteLine("Error al agregar staff a actividad DAO");
                }
            }
                
        }



        public List<string> actividadesXParticipante(int idParticipante)
        {
            List<string> list = new List<string>();
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("actividadesXparticipante", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id", idParticipante));
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(rdr.GetString(0));
                }
                rdr.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al obtener actividades");
                list.Add("Error");
                return list;
            }
        }


        public List<byte[]> cargarImagen(int idActividad)
        {
            List<byte[]> list = new List<byte[]>();
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("cargarImagen", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@idActividad", idActividad));
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add((byte[])rdr["Data"]);
                }
                rdr.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al obtener actividades");
                return list;
            }
        }


        public List<Modelo.Lista> llenarParticipantes(int idActividad)
        {
            List<Modelo.Lista> list = new List<Modelo.Lista>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select Identificacion, Nombre, Apellido1, Apellido2 from ParticipantesxActividad where ActividadId = " + idActividad, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Modelo.Lista
                    {
                        id = rdr.GetInt32(0),
                        nombre = rdr.GetString(1) + " " + rdr.GetString(2) + " "+ rdr.GetString(3)

                    });
                }
                rdr.Close();
                return list;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al obtener Participantes");
                list.Add(new Modelo.Lista
                {
                    id = -1,
                    nombre = "Error"

                });
                return list;

            }
        }


        public void desinscribirParticipante(int idActividad, int identificacion)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("desinscribirParticipante", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@idActividad", idActividad));
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Se desinscribió correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al desinscribir participante");
            }
        }

        public List<Modelo.Lista> llenarCursos()
        {
            List<Modelo.Lista> list = new List<Modelo.Lista>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select CursoId, Nombre from Curso", conn);
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
                System.Diagnostics.Debug.WriteLine("Error al obtener Cursos");
                list.Add(new Modelo.Lista
                {id = -1,nombre = "Error"});
                return list;
            }
        }

        public List<Modelo.Lista> llenarTipoParticipante()
        {
            List<Modelo.Lista> list = new List<Modelo.Lista>();
            try
            {
                Abrir();
                SqlCommand cmd = new SqlCommand("select TipoId, Nombre from TipoParticipante", conn);
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
                System.Diagnostics.Debug.WriteLine("Error al obtener tipo de participante");
                list.Add(new Modelo.Lista
                { id = -1, nombre = "Error" });
                return list;
            }
        }

        public void agregarParticipante(Modelo.Participante participante)
        {
            try
            {
                Abrir();
                SqlCommand command = new SqlCommand("agregarParticipante", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ActividadId", participante.getIdActividad()));
                command.Parameters.Add(new SqlParameter("@CursoId", participante.getIdCurso()));
                command.Parameters.Add(new SqlParameter("@TipoPId", participante.getIdTipoParticipante()));
                command.Parameters.Add(new SqlParameter("@Apellido1", participante.getPrimerApellidoP()));
                command.Parameters.Add(new SqlParameter("@Apellido2", participante.getSegundoApellidoP()));
                command.Parameters.Add(new SqlParameter("@Nombre", participante.getNombreP()));
                command.Parameters.Add(new SqlParameter("@Identificacion", participante.getIdentificacion()));
                command.Parameters.Add(new SqlParameter("@Correo", participante.getCorreo()));
                command.Parameters.Add(new SqlParameter("@Campus", participante.getCampus()));
                command.ExecuteNonQuery();
                if (conn.State != ConnectionState.Closed)
                {
                    Cerrar();
                }
                System.Diagnostics.Debug.WriteLine("Participante agregado correctamente");
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al insertar participante");
            }
        }

        public bool verificarRegistro(int idActividad, int identificacion)
        {
            try
            {
                Abrir();
                bool resultado = false; 
                SqlCommand command = new SqlCommand("verificarRegistro", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@idActividad", idActividad));
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                command.ExecuteNonQuery();
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    resultado = rdr.GetBoolean(0);
                }
                rdr.Close();
                return resultado;
            }
            catch (SqlException ex)
            {
                Console.Write(ex);
                System.Diagnostics.Debug.WriteLine("Error al obtener verificacion");
                return false;
            }
        }


    }   

}