using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Gestor_Actividades.Vista
{
    public partial class EditarEvento : System.Web.UI.Page
    {
        public DTO1.DTO dto = new DTO1.DTO();
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

        protected void botonGuardarCambios_Click(object sender, EventArgs e)
        {
            String nombre = txtBox_nombre.Text;
            String expo = txtBox_expositor.Text;

            //Expresiones regulares para validar
            String validaCaracteres = "^[a-zA-Z\\s]+$";
            Match matchNombre = Regex.Match(nombre, validaCaracteres);
            Match matchExpo = Regex.Match(expo, validaCaracteres);

            if (!matchExpo.Success || !matchNombre.Success)
            {
                MsgBox("Nombre o Expositor inválido", this.Page, this);
            }

            String horario = txtBox_horario.Text;
            String descrip = txtBox_descripcion.Text;

            dto.setEventoDescripcion(descrip);
            dto.setEventoExpositor(expo);
            dto.setEventoHorario(horario);
            dto.setEventoNombre(nombre);


            MsgBox("Evento Registrado", this.Page, this);
        }
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