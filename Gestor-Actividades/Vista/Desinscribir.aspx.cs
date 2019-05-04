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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonDesinscribir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Desinscribir.aspx");
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
    }
}