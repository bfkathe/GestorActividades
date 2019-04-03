using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_Actividades.Modelo
{
    public class Archivo
    {

        private String nombre;
        private String formato;
        private byte[] ruta;
        private int ActividadId;

        public Archivo()
        {

        }

        public Archivo(string nom, string form, byte[] path,int actividadId)
        {
            this.nombre = nom;
            this.formato = form;
            this.ruta = path;
            this.ActividadId = actividadId;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getFormato()
        {
            return this.formato;
        }

        public byte[] getRuta()
        {
            return this.ruta;
        }

        public void setNombre(String nom)
        {
            this.nombre = nom;
        }

        public void setFormato(String form)
        {
            this.formato = form;
        }

        public void setRuta(byte[] rut)
        {
            this.ruta = rut;
        }

        public int getIdActividad()
        {
            return this.ActividadId;
        }

        public void setIdActividad(int idActividad)
        {
            this.ActividadId = idActividad;
        }
    }
}