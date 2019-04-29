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
        private String ActividadLugar;
        private int ActividadId;

        //eventos
        private String EventoNombre { get; set; }
        private String EventoHorario{ get; set; }
        private String EventoExpositor { get; set; }
        private String EventoDescripcion;
        private int EventoIdActividad;
        private int EventoId;

        //staff
        private String StaffNombre { get; set; }
        private String StaffUsuario { get; set; }
        private String StaffContraseña { get; set; }
        private List<int> listaStaff { get; set; }

        //archivos
        private byte[] ArchivoRuta;
        private string ArchivoNombre;
        private string ArchivoFormato;
        private int ArchivoActividadId;
        private int ArchivoId;

        //busqueda de actividadesXparticipante
        private int idParticipante;


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

        public String getActividadLugar()
        {
            return this.ActividadLugar;
        }

        public int getActividadId()
        {
            return this.ActividadId;
        }
        //Eventos

        public String getEventoNombre()
        {
            return this.EventoNombre;
        }

        public String getEventoHorario()
        {
            return this.EventoHorario;
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

        public int getEventoId()
        {
            return this.EventoId;
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


        public List<int> getListaStaff()
        {
            return this.listaStaff;
        }


        //Archivos

        /*public String getArchivoPath()
        {
            return this.ArchivoPath ;
        }*/

        //busqueda de actividadesXparticipante
        public int getIdParticipante()
        {
            return this.idParticipante;
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

        public void setActividadLugar(String lugar)
        {
            this.ActividadLugar = lugar;
        }

        public void setActividadId(int id)
        {
            this.ActividadId = id;
        }

        //eventos

        public void setEventoNombre(String nom)
        {
            this.EventoNombre = nom;
        }

        public void setEventoHorario(String fecha)
        {
            this.EventoHorario = fecha;
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

        public void setEventoId(int id)
        {
            this.EventoId = id;
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

        public void setListaStaff(List<int> listaStaff)
        {
            this.listaStaff = listaStaff;
        }

        //busqueda de actividadesXparticipante
        public void setIdParticipante(int id)
        {
            this.idParticipante = id;
        }




        //archivos

        public void setArchivoPath(Byte[] path)
        {
            this.ArchivoRuta = path;
        }

        public Byte[] getArchivoPath()
        {
            return this.ArchivoRuta;
        } 

        public void setArchivoNombre(String nombre)
        {
            this.ArchivoNombre = nombre;
        }

        public String getArchivoNombre()
        {
            return this.ArchivoNombre;
        }

        public void setArchivoFormato(String formato)
        {
            this.ArchivoFormato = formato;
        }

        public String getArchivoFormato()
        {
            return this.ArchivoFormato;
        }

        public void setArchivoActividadId(int id)
        {
            this.ArchivoActividadId = id;
        }

        public int getArchivoActividadId()
        {
            return this.ArchivoActividadId;
        }

        public void setArchivoId(int id)
        {
            this.ArchivoId = id;
        }

        public int getArchivoId()
        {
            return this.ArchivoId;
        }

        public DTO() { }
    }

    
}