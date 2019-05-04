using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gestor_Actividades.Negocio;
using Gestor_Actividades.Modelo;
using Gestor_Actividades.DTO1;

namespace Gestor_Actividades.Vista
{
    public partial class VerEventos : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;
        DTO dto = new DTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                System.Diagnostics.Debug.WriteLine(singleton.getActividadId());
                List<Lista> lista = controlador.llenarEventos(singleton.getActividadId());
                CheckBoxList_Eventos.DataTextField = "nombre";
                CheckBoxList_Eventos.DataValueField = "id";
                CheckBoxList_Eventos.DataSource = lista;
                CheckBoxList_Eventos.DataBind();
            }
        }

        protected void botonCrearAct_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearActividad.aspx");
        }

        protected void botonVerAct_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerActividades.aspx");
        }

        protected void botonCrearStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }

        protected void botonAgregarEvento_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearEvento.aspx");
        }

        protected void botonEditarEvento_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Eventos.Items)
            {
                if (item.Selected)
                {
                    singleton.setEventoId(Convert.ToInt32(item.Value));
                }
            }
            Response.Redirect("EditarEvento.aspx");
        }

        protected void botonEliminarEvento_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Eventos.Items)
            {
                if (item.Selected)
                {
                    singleton.setEventoId(Convert.ToInt32(item.Value));
                }
            }

            dto.setEventoId(singleton.getEventoId());
            
            try
            {
                controlador.eliminarEvento(dto);
                System.Diagnostics.Debug.WriteLine("Evento eliminado");
                Response.Redirect("VerEventos.aspx");
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al eliminar evento", ex);
            }
        }

        protected void CheckBoxList_Eventos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void botonDesinscribir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Desinscribir.aspx");
        }
    }
}