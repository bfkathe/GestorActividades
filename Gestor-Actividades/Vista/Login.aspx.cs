using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gestor_Actividades.Negocio;
using Gestor_Actividades.DTO1;

namespace Gestor_Actividades.Vista
{
    public partial class Login : System.Web.UI.Page
    {
        public Controlador controlador = new Controlador();
        public DTO dto = new DTO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonLoggear_Click(object sender, EventArgs e)
        {

            String usuario = txtBox_username.Text;
            String contraseña = txtBox_password.Text;

            dto.setLogInUser(usuario);
            dto.setLogInPassword(contraseña);

            Boolean autenticado = controlador.verificarLogin(dto);

            if(autenticado)
                Response.Redirect("VerActividades.aspx");
            else
                MsgBox("Usuario incorrecto", this.Page, this);
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