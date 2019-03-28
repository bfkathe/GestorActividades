﻿using System;
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
        public DTO.DTO dto = new DTO.DTO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonLoggear_Click(object sender, EventArgs e)
        {

            String usuario = txtBox_username.Text;
            String contraseña = txtBox_password.Text;

            dto.setLogInUser(usuario);
            dto.setLogInPassword(contraseña);

            //System.Diagnostics.Debug.WriteLine(dtoLogin.getLogInUser());
            Response.Redirect("VerActividades.aspx");
        }
    }
}