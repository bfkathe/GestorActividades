using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gestor_Actividades.Negocio;
using Gestor_Actividades.Modelo;

namespace Gestor_Actividades.Vista
{
    public partial class VerActividades : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Lista> lista = controlador.llenarActividades();
            CheckBoxList_Actividades.DataTextField = "nombre";
            CheckBoxList_Actividades.DataValueField = "id";
            CheckBoxList_Actividades.DataSource = lista;
            CheckBoxList_Actividades.DataBind();
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
            Response.Redirect("EditarActividades.aspx");
        }

        protected void botonEliminarActividad_Click(object sender, EventArgs e)
        {
            MsgBox("Actividad Eliminada", this.Page, this);
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
            Response.Redirect("VerEventos.aspx");
        }
    }
}