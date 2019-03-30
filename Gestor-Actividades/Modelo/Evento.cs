using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_Actividades.Modelo
{
    public class Evento
    {

        private String nombre;
        private String horario;
        private String expositor;
        private String descripcion;

        public Evento()
        {

        }

        public Evento(String nom, String hor, String expo, String descrip)
        {
            this.nombre = nom;
            this.horario = hor;
            this.expositor = expo;
            this.descripcion = descrip;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getHorario()
        {
            return this.horario;
        }

        public String getExpositor()
        {
            return this.expositor;
        }

        public String getDescripcion()
        {
            return this.descripcion;
        }

        public void setNombre(String nom)
        {
            this.nombre = nom;
        }

        public void setHorario(String hora)
        {
            this.horario = hora;
        }

        public void setExpositor(String expo)
        {
            this.expositor = expo;
        }

        public void setDescripcion(String descrip)
        {
            this.descripcion = descrip;
        }
    }
}