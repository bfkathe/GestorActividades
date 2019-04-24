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
    public partial class Inicio : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
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

        protected void boton_inicioSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}