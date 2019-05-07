using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_Actividades.Modelo
{
    public class Participante
    {
        private int idActividad;
        private int idTipoParticipante;
        private int idCurso;
        private int identificacion;
        private String campus;
        private String nombreParticipante;
        private String primerApellidoP;
        private String segundoApellidoP;
        private String correo;

        public Participante(int idAct, int idTP, int idCur, int id, String camp, String nombre, String Apellido1, String Apellido2, String email)
        {
            idActividad = idAct;
            idTipoParticipante = idTP;
            idCurso = idCur;
            identificacion = id;
            campus = camp;
            nombreParticipante = nombre;
            primerApellidoP = Apellido1;
            segundoApellidoP = Apellido2;
            correo = email;
        }


        public int getIdActividad()
        {
            return this.idActividad;
        }
        public int getIdCurso()
        {
            return this.idCurso;
        }

        public int getIdTipoParticipante()
        {
            return this.idTipoParticipante;
        }

        public int getIdentificacion()
        {
            return this.identificacion;
        }

        public String getCampus()
        {
            return this.campus;
        }

        public String getNombreP()
        {
            return this.nombreParticipante;
        }

        public String getPrimerApellidoP()
        {
            return this.primerApellidoP;
        }

        public String getSegundoApellidoP()
        {
            return this.segundoApellidoP;
        }

        public String getCorreo()
        {
            return this.correo;
        }

        /*-------------------SETTERS------------------------------*/

        public void setIdActividad(int id)
        {
            this.idActividad = id;
        }

        public void setIdCurso(int id)
        {
            this.idCurso = id;
        }

        public void setIdTipoParticipante(int id)
        {
            this.idTipoParticipante = id;
        }

        public void setIdentificacion(int id)
        {
            this.identificacion = id;
        }

        public void setCampus(String id)
        {
            this.campus = id;
        }

        public void setNombreP(String id)
        {
            this.nombreParticipante = id;
        }

        public void setPrimerApellidoP(String id)
        {
            this.primerApellidoP = id;
        }

        public void setSegundoApellidoP(String id)
        {
            this.segundoApellidoP = id;
        }

        public void setCorreo(String id)
        {
            this.correo = id;
        }
    }
}