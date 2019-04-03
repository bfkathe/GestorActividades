using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gestor_Actividades.DTO1;
using Gestor_Actividades.Modelo;

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


        ///NUEVOOO////  

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


        public void agregarStaffXActividad(DTO dto)
        {
            int idAct = dto.getActividadId();
            List<int> listaStaff = dto.getListaStaff();

            conexion.agregarStaffXActividad(idAct,listaStaff);
        }






    }
}