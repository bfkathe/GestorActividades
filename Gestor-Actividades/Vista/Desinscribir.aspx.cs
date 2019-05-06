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
    public partial class Desinscribir : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;
        DTO dto = new DTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Lista> lista = controlador.llenarParticipantes(singleton.getActividadId());
                CheckBoxList_Participantes.DataTextField = "nombre";
                CheckBoxList_Participantes.DataValueField = "id";
                CheckBoxList_Participantes.DataSource = lista;
                CheckBoxList_Participantes.DataBind();
            }
        }

        protected void botonCrearStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }

        protected void botonVerAct_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerActividades.aspx");
        }

        protected void botonCrearAct_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearActividad.aspx");
        }

        protected void botonDesinscribirParticipante_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Participantes.Items)
            {
                if (item.Selected)
                {
                    dto.setIdParticipante(Convert.ToInt32(item.Value));
                }
            }

            dto.setActividadId(singleton.getActividadId());
            try
            {
                controlador.desinscribirParticipante(dto);
                Response.Redirect("Desinscribir.aspx");

            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al desinscribir participante", ex);
            }
        }
    }
}