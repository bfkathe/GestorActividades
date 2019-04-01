using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_Actividades.DTO1
{
    public class DTO
    {
        //usuario
        private String LogIngUser { get; set; }
        private String LogInPassword { get; set; }

        //actividades
        private DateTime ActividadFecha { get; set; }
        private String ActividadNomhbre { get; set; }
        private String ActividadHorario { get; set; }
        private String ActividadCampus { get; set; }
        private bool ActividadRestriccion { get; set; }
        private String ActividadEncargado { get; set; }
        private String ActividadDescripcion;
        private int ActividadCupo;

        //eventos
        private String EventoNombre { get; set; }
        private DateTime EventoFecha { get; set; }
        private String EventoExpositor { get; set; }
        private String EventoDescripcion;
        private int EventoIdActividad;

        //staff
        private String StaffNombre { get; set; }
        private String StaffUsuario { get; set; }
        private String StaffContraseña { get; set; }

        //archivos
        private String ArchivoPath { get; set; }


        //Gets --------------------------
        
        //Login
        public String getLogInUser()
        {
            return this.LogIngUser;
        }

        public String getLogInPassword()
        {
            return this.LogInPassword;
        }

        //Actividades
        public DateTime getActividadFecha()
        {
            return this.ActividadFecha;
        }

        public String getActividadNombre()
        {
            return this.ActividadNomhbre;
        }

        public String getActividadHorario()
        {
            return this.ActividadHorario;
        }

        public String getActividadCampus()
        {
            return this.ActividadCampus;
        }

        public bool getActividadRestriccion()
        {
            return this.ActividadRestriccion;
        }

        public String getActividadEncargado()
        {
            return this.ActividadEncargado;
        }

        public String getActividadDescripcion()
        {
            return this.ActividadDescripcion;
        }

        public int getActividadCupo()
        {
            return this.ActividadCupo;
        }

        //Eventos

        public String getEventoNombre()
        {
            return this.EventoNombre;
        }

        public DateTime getEventoFecha()
        {
            return this.EventoFecha;
        }

        public String getEventoExpositor()
        {
            return this.EventoExpositor ;
        }

        public String getEventoDescripcion()
        {
            return this.EventoDescripcion;
        }

        public int getEventoIdActividad()
        {
            return this.EventoIdActividad;
        }

        //staff

        public String getStaffUsuario()
        {
            return this.StaffUsuario ;
        }

        public String getStaffContraseña()
        {
            return this.StaffContraseña ;
        }

        public String getStaffNombre()
        {
            return this.StaffNombre ;
        }

        //Archivos

        public String getArchivoPath()
        {
            return this.ArchivoPath ;
        }

        //Sets-----------------

        //login

        public void setLogInUser(String User)
        {
            this.LogIngUser = User;
        }

        public void setLogInPassword(String pass)
        {
            this.LogInPassword = pass ;
        }

        //actividades

        public void setActividadFecha(DateTime fecha)
        {
            this.ActividadFecha = fecha ;
        }

        public void setActividadNombre(String nom)
        {
            this.ActividadNomhbre = nom;
        }

        public void setActividadCampus(String campus)
        {
            this.ActividadCampus = campus;
        }

        public void setActividadRestriccion(bool res)
        {
            this.ActividadRestriccion = res;
        }

        public void setActividadHorario(String horario)
        {
            this.ActividadHorario = horario;
        }

        public void setActividadEncargado(String encargado)
        {
            this.ActividadEncargado = encargado;
        }

        public void setActividadDescripcion(String des)
        {
            this.ActividadDescripcion = des;
        }

        public void setActividadCupo(int cupo)
        {
            this.ActividadCupo = cupo;
        }

        //eventos

        public void setEventoNombre(String nom)
        {
            this.EventoNombre = nom;
        }

        public void setEventoFecha(DateTime fecha)
        {
            this.EventoFecha = fecha;
        }

        public void setEventoExpositor(String expo)
        {
            this.EventoExpositor = expo;
        }

        public void setEventoDescripcion(String des)
        {
            this.EventoDescripcion = des;
        }

        public void setEventoIdActividad(int id)
        {
            this.EventoIdActividad = id;
        }

        //staff

        public void setStaffNombre(String nom)
        {
            this.StaffNombre = nom;
        }

        public void setStaffUsuario(String usu)
        {
            this.StaffUsuario = usu;
        }

        public void setStaffContraseña(String pass)
        {
            this.StaffContraseña = pass;
        }

        //archivos

        public void setArchivoPath(String path)
        {
            this.ArchivoPath = path;
        }

        public DTO() { }
    }

    
}