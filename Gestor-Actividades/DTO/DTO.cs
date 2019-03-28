using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestor_Actividades.DTO
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

        //eventos
        private String EventoNombre { get; set; }
        private DateTime EventoFecha { get; set; }
        private String EventoExpositor { get; set; }

        //staff
        private String StaffNombre { get; set; }
        private String StaffUsuario { get; set; }
        private String StaffContraseña { get; set; }

        //archivos
        private String ArchivoPath { get; set; }

        }



        public DTO()
        {

        }
}