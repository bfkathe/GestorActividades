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
    public partial class VerActividades : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;
        DTO dto = new DTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Lista> lista = controlador.llenarActividades();
                CheckBoxList_Actividades.DataTextField = "nombre";
                CheckBoxList_Actividades.DataValueField = "id";
                CheckBoxList_Actividades.DataSource = lista;
                CheckBoxList_Actividades.DataBind();
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

        protected void botonEditarActividad_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Actividades.Items)
            {
                if (item.Selected)
                {
                    singleton.setActividadId(Convert.ToInt32(item.Value));
                }
            }
            System.Diagnostics.Debug.WriteLine(singleton.getActividadId());
            Response.Redirect("EditarActividades.aspx");
        }

        protected void botonEliminarActividad_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Actividades.Items)
            {
                if (item.Selected)
                {
                    singleton.setActividadId(Convert.ToInt32(item.Value));
                }
            }
            dto.setActividadId(singleton.getActividadId());
            try
            {
                controlador.eliminarActividad(dto);
                MsgBox("Actividad Eliminada", this.Page, this);
                Response.Redirect("VerActividades.aspx");
            }
            catch (Exception ex)
            {
                MsgBox("La actividad contiene eventos", this.Page, this);
                System.Diagnostics.Debug.WriteLine("Error al eliminar Actividad", ex);
            }
            
        }

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        protected void botonVerEventos_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Actividades.Items)
            {
                if (item.Selected)
                {
                    singleton.setActividadId(Convert.ToInt32(item.Value));
                }
            }
            Response.Redirect("VerEventos.aspx");
        }

        protected void botonArchivos_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Actividades.Items)
            {
                if (item.Selected)
                {
                    singleton.setActividadId(Convert.ToInt32(item.Value));
                }
            }
            Response.Redirect("VerArchivos.aspx");
        }

        protected void botonParticipantes_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Actividades.Items)
            {
                if (item.Selected)
                {
                    singleton.setActividadId(Convert.ToInt32(item.Value));
                }
            }
            Response.Redirect("Desinscribir.aspx");
        }

        protected void botonLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}