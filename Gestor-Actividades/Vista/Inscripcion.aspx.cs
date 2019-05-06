using Gestor_Actividades.DTO1;
using Gestor_Actividades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestor_Actividades.Vista
{
    public partial class Inscripcion : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;
        DTO dto = new DTO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonInscribirParticipante_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.email_send("audrarm1997@gmail.com", "Simposio Ciberseguridad", "Audra Rodríguez");

            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al enviar correo", ex);
            }
            
        }

        protected void botonCrearAct_Click(object sender, EventArgs e)
        {

        }

        protected void botonVerAct_Click(object sender, EventArgs e)
        {

        }

        protected void botonCrearStaff_Click(object sender, EventArgs e)
        {

        }
    }
}