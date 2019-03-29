using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestor_Actividades.Vista
{
    public partial class CrearEvento : System.Web.UI.Page
    {
        public DTO.DTO dto = new DTO.DTO();
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void botonRegistrar_Click(object sender, EventArgs e)
        {
            String nombre = txtBox_nombre.Text;
            String horario = txtBox_horario.Text;
            String expo = txtBox_expositor.Text;

            DateTime fecha = Convert.ToDateTime(horario);

            String descrip = txtBox_descripcion.Text;

            dto.setEventoDescripcion(descrip);
            dto.setEventoExpositor(expo);
            dto.setEventoFecha(fecha);
            dto.setEventoNombre(nombre);


            MsgBox("Evento Registrado", this.Page, this);
        }

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}