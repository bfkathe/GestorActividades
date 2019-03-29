using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gestor_Actividades.Controlador;

namespace Gestor_Actividades.Vista
{
    public partial class Login : System.Web.UI.Page
    {
        public Controlador.Controlador controlador = new Controlador.Controlador();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonLoggear_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerActividades.aspx");

        }
    }
}