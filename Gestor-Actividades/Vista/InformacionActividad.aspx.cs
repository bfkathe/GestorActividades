using Gestor_Actividades.DTO1;
using Gestor_Actividades.Modelo;
using Gestor_Actividades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestor_Actividades.Vista
{
    public partial class InformacionActividad : System.Web.UI.Page
    {
        public DTO dto = new DTO();
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dto.setActividadId(singleton.getActividadId());
                List<Actividad> lista = controlador.datosActividades(dto);
                cargarInformacion(lista);
            }
        }

        protected void cargarInformacion(List<Actividad> lista)
        {
            string informacion = "";
            foreach (Actividad item in lista)
            {
                informacion += "Fecha: "+item.getFecha().ToString();
                informacion += "\nActividad: "+item.getNombre();
                informacion += "\nHorario: "+item.getHorario();
                informacion += "\nCampus/Centro Académico: "+item.getCampus();
                informacion += "\nEncargado: "+item.getEncargado();
                if (item.getCantCupos().ToString() == "-1")
                {
                    informacion += "\nCupo: ilimitado";
                }
                else
                {
                    informacion += "\nCupo: "+item.getCantCupos().ToString();
                }
                informacion += "\nLugar: "+item.getLugar();

                if (item.getDescripcion() == "Actividad sin descripcion")
                {
                    informacion += "\nDescripción: no description";
                }
                else
                {
                    informacion += "\nDescripción: "+item.getDescripcion();
                }
            }
            txt_informacion.Text = informacion;
        }

        protected void boton_inicioSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}