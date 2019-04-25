using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_Actividades.Negocio
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }
        private int idActividad;
        private int idEvento;
        private int idArchivo;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void setEventoId(int id)
        {
            this.idEvento = id;
        }

        public void setActividadId(int id)
        {
            this.idActividad = id;
        }

        public void setArchivoId(int id)
        {
            this.idArchivo = id;
        }

        public int getActividadId()
        {
            return idActividad;
        }

        public int getEventoId()
        {
            return idEvento;
        }

        public int getArchivoId()
        {
            return idArchivo;
        }
    }
}