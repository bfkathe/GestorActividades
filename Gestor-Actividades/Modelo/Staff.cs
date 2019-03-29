using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_Actividades.Modelo
{
    public class Staff
    {
        private String nombre;
        private String usuario;
        private String contraseña;

        public Staff()
        {

        }

        public Staff(string nom, string usu, string contra)
        {
            this.nombre = nom;
            this.usuario = usu;
            this.contraseña = contra;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getUsuario()
        {
            return this.usuario;
        }

        public String getContraseña()
        {
            return this.contraseña;
        }

        public void setNombre(String nom)
        {
            this.nombre = nom;
        }

        public void setUsuario(String usu)
        {
            this.usuario = usu;
        }

        public void setContraseña(String contra)
        {
            this.contraseña = contra;
        }

    }
}