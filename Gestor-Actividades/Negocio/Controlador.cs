using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gestor_Actividades.DTO1;
using Gestor_Actividades.Modelo;
using System.Net;
using System.Net.Mail;

namespace Gestor_Actividades.Negocio
{
    public class Controlador
    {
        public DAOBD conexion = new DAOBD();
        
        public Controlador(){}


        public void agregarStaff(DTO dto)
        {
            Staff usuarioStaff = new Staff(dto.getStaffNombre(), dto.getStaffUsuario(), dto.getStaffContraseña());
            conexion.agregarStaff(usuarioStaff);
        }

        public void agregarActividad(DTO dto)
        {
            Modelo.Actividad actividad = new Modelo.Actividad(dto.getActividadFecha(), dto.getActividadNombre(), dto.getActividadHorario(), dto.getActividadCampus(), dto.getActividadRestriccion(), dto.getActividadEncargado(), dto.getActividadCupo(), dto.getActividadLugar(), dto.getActividadDescripcion());
            try
            {
                conexion.agregarActividad(actividad);
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al insertar actividad",ex);
            }      
        }

        public void editarActividad(DTO dto)
        {
            Modelo.Actividad actividad = new Modelo.Actividad(dto.getActividadFecha(), dto.getActividadNombre(), dto.getActividadHorario(), dto.getActividadCampus(), dto.getActividadRestriccion(), dto.getActividadEncargado(), dto.getActividadCupo(), dto.getActividadLugar(), dto.getActividadDescripcion());
            try
            {
                conexion.editarActividad(actividad, dto.getActividadId());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al editar actividad", ex);
            }

        }

        public void eliminarActividad(DTO dto)
        {
            
            try
            {
                conexion.eliminarActividad(dto.getActividadId());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al eliminar actividad", ex);
            }

        }
        public void agregarEvento(DTO dto)
        {
            Modelo.Evento evento = new Modelo.Evento(dto.getEventoIdActividad(), dto.getEventoNombre(), dto.getEventoHorario(), dto.getEventoExpositor(), dto.getEventoDescripcion());
            try
            {
                conexion.agregarEvento(evento);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al insertar evento CONTROLADOR", ex);
            }

        }

        public void editarEvento(DTO dto)
        {
            Modelo.Evento evento = new Modelo.Evento(dto.getEventoIdActividad(), dto.getEventoNombre(), dto.getEventoHorario(), dto.getEventoExpositor(), dto.getEventoDescripcion());
            try
            {
                conexion.editarEvento(evento, dto.getEventoId());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al editar evento CONTROLADOR", ex);
            }

        }

        public void eliminarEvento(DTO dto)
        {
            try
            {
                conexion.eliminarEvento(dto.getEventoId());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al eliminar evento", ex);
            }

        }

        public List<Modelo.Lista> llenarActividades()
        {
            List<Modelo.Lista> lista = new List<Modelo.Lista>();
            try
            {
                lista = conexion.llenarActividades();
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener actividades", ex);
                return lista;
            }
            
        }

        public List<Modelo.Actividad> datosActividades(DTO dto)
        {
            List<Modelo.Actividad> lista = new List<Modelo.Actividad>();
            try
            {
                lista = conexion.datosActividades(dto.getActividadId());
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener actividades", ex);
                return lista;
            }

        }

        public List<Modelo.Evento> datosEventos(DTO dto)
        {
            List<Modelo.Evento> lista = new List<Modelo.Evento>();
            try
            {
                lista = conexion.datosEventos(dto.getEventoId());
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener eventos", ex);
                return lista;
            }

        }

        public List<Modelo.Lista> llenarEventos(int idActividad)
        {
            List<Modelo.Lista> lista = new List<Modelo.Lista>();
            try
            {
                lista = conexion.llenarEventos(idActividad);
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener eventos", ex);
                return lista;
            }

        }

        // PARTICIPAANTES

        public List<Modelo.Lista> llenarParticipantes(int idActividad)
        {
            List<Modelo.Lista> lista = new List<Modelo.Lista>();
            try
            {
                lista = conexion.llenarParticipantes(idActividad);
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener participantes", ex);
                return lista;
            }

        }

        public void desinscribirParticipante(DTO dto)
        {
            try
            {
                conexion.desinscribirParticipante(dto.getActividadId(), dto.getIdParticipante());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al desinscribir participante", ex);
            }

        }


        public Boolean verificarLogin(DTO dto)
        {
            string usuario = dto.getLogInUser();
            string contrasenna = dto.getLogInPassword();
            int resultado = conexion.VerificarLogin(usuario, contrasenna);
            if (resultado == 0)
                return false;
            else
                return true;
        }


        public Boolean verificarStaff(DTO dto)
        {
            string usuario = dto.getStaffUsuario();
            int resultado = conexion.verificarStaffUnico(usuario);
            if (resultado == 0)
                return false;
            else
                return true;
        }

       public void agregarArchivo(DTO dto)
        {
            Archivo archivo = new Archivo(dto.getArchivoNombre(), dto.getArchivoFormato(), dto.getArchivoContenido(),dto.getArchivoActividadId());
            try
            {
                conexion.agregarArchivo(archivo);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al insertar archivo CONTROLADOR", ex);
            }

        }


        public List<Modelo.Lista> llenarArchivos(int idActividad)
        {
            List<Modelo.Lista> lista = new List<Modelo.Lista>();
            try
            {
                lista = conexion.llenarArchivos(idActividad);
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener archivos", ex);
                return lista;
            }

        }

        public List<Lista> llenarStaff()
        {
            List<Lista> lista = new List<Lista>();
            try
            {
                lista = conexion.llenarStaff();
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener usuarios de Staff", ex);
                return lista;
            }

        }

        public List<Lista> llenarCursos()
        {
            List<Lista> lista = new List<Lista>();
            try
            {
                lista = conexion.llenarCursos();
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener cursos", ex);
                return lista;
            }

        }


        public List<Lista> llenarTiposParticipantes()
        {
            List<Lista> lista = new List<Lista>();
            try
            {
                lista = conexion.llenarTipoParticipante();
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener tipos de participantes", ex);
                return lista;
            }

        }


        public void agregarStaffXActividad(DTO dto)
        {
            int idAct = dto.getActividadId();
            List<int> listaStaff = dto.getListaStaff();

            conexion.agregarStaffXActividad(idAct,listaStaff);
        }


        public void eliminarArchivo(DTO dto)
        {
            try
            {
                conexion.eliminarArchivo(dto.getArchivoId());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al eliminar archivo", ex);
            }

        }

        public List<string> actividadesXparticipante(DTO dto)
        {
            List<string> lista = new List<string>();
            int idParticipante = dto.getIdParticipante();
            try
            {
                lista = conexion.actividadesXParticipante(idParticipante);
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener actividades", ex);
                return lista;
            }
        }

        //Cargar imagen de una actividad
        public List<byte []> cargarImagen(DTO dto)
        {
            List<byte[]> lista = new List<byte[]>();
            int idActividad = dto.getActividadId();
            lista = conexion.cargarImagen(idActividad);
            return lista;
        }

        public void email_send(DTO dto)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("proyectogestoractividades@gmail.com");
            mail.To.Add(dto.getCorreo());
            mail.Subject = "Confirmación de Inscripción";
            mail.Body = "Hola " + dto.getStaffNombre() +"!\nTu inscripción fue exitosa para la Actividad: " + dto.getActividadNombre() + ". Si querés conocer más información acerca de la actividad"+
                "podés visitar la página web del Gestor de Actividades. \nRecordá que en caso de querer desinscribirte de esta actividad contactá al administrador.\nTe esperamos";
            /*
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            mail.Attachments.Add(attachment);
            */
            SmtpServer.Port = 587;
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("proyectogestoractividades@gmail.com", "proyectoGA");

            try
            {
                SmtpServer.Send(mail);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al enviar correo con", ex);
            }
            

        }

        public void agregarParticipante(DTO dto)
        {
            Participante participante = new Participante(dto.getActividadId(), dto.getIdTipoParticipante(), dto.getIdCurso(),dto.getIdentificacion(),dto.getCampus(),dto.getNombreP(),dto.getPrimerApellidoP(),dto.getSegundoApellidoP(), dto.getCorreo());
            try
            {
                conexion.agregarParticipante(participante);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al insertar participante", ex);
            }

        }
    }
}