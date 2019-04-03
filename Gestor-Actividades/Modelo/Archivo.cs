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
        private String ruta;

        public Archivo()
        {

        }

        public Archivo(string nom, string form, string path)
        {
            this.nombre = nom;
            this.formato = form;
            this.ruta = path;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getFormato()
        {
            return this.formato;
        }

        public String getRuta()
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

        public void setRuta(String rut)
        {
            this.ruta = rut;
        }

    }
}