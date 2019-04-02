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

        //Agregar staff (Prueba)
        public void agregarStaff(DTO dto)
        {
            conexion.agregarStaff(
                dto.getStaffNombre(),
                dto.getStaffUsuario(),
                dto.getStaffContraseña());
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
                System.Diagnostics.Debug.WriteLine("Error al insertar evento", ex);
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
                System.Diagnostics.Debug.WriteLine("Error al editar evento", ex);
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

        public List<Modelo.Lista> llenarEventos()
        {
            List<Modelo.Lista> lista = new List<Modelo.Lista>();
            try
            {
                lista = conexion.llenarEventos();
                return lista;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al obtener eventos", ex);
                return lista;
            }

        }
    }
}