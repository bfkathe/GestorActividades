using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_Actividades.Modelo
{
    public class Actividad
    {
        private DateTime fecha; 
        private String nombre;
        private String horario;
        private String campus;
        private Boolean restriccion;
        private String encargado;
        private int cantCupos;
        private String lugar;
        private String descripcion;

        public Actividad(DateTime Fecha,String Nombre,String Horario,String Campus,Boolean Restriccion, String Encargado, int CantCupos, String Lugar, String Descripcion)
        {
            fecha = Fecha;
            nombre = Nombre;
            horario = Horario;
            campus = Campus;
            restriccion = Restriccion;
            encargado = Encargado;
            cantCupos = CantCupos;
            lugar = Lugar;
            descripcion = Descripcion;

        }

        public DateTime getFecha() {
            return fecha;
        }

        public void setFecha(DateTime fecha1)
        {
            fecha = fecha1;
        }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre1)
        {
            nombre = nombre1;
        }

        public String getHorario()
        {
            return horario;
        }

        public void setHorario(String horario1)
        {
            horario = horario1;
        }

        public String getCampus()
        {
            return campus;
        }

        public void setCampus(String campus1)
        {
            campus = campus1;
        }

        public Boolean getRestriccion()
        {
            return restriccion;
        }

        public void setRestriccion(Boolean restriccion1)
        {
            restriccion = restriccion1;
        }

        public String getEncargado()
        {
            return encargado;
        }

        public void setEncargado(String encargado1)
        {
            encargado = encargado1;
        }

        public int getCantCupos()
        {
            return cantCupos;
        }

        public void setCantCupos(int cantCupos1)
        {
            cantCupos = cantCupos1;
        }

        public String getLugar()
        {
            return lugar;
        }

        public void setLugar(String lugar1)
        {
            lugar = lugar1;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(String Descripcion1)
        {
            descripcion = Descripcion1;
        }








    }
}