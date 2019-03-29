﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gestor_Actividades.DTO1;
using Gestor_Actividades.Negocio;

namespace Gestor_Actividades.Vista
{
    public partial class Staff : System.Web.UI.Page
    {
        
        public DTO dtoStaff = new DTO();
        public Controlador controlador = new Controlador();

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

        protected void botonStaffNuevo_Click(object sender, EventArgs e)
        {
            String nombre = txtBox_nombre.Text;
            String contra = txtBox_contrasenna.Text;
            String usu = txtBox_nombreUsuario.Text;

            if(txtBox_nombre.Text.Equals("") | txtBox_nombreUsuario.Text.Equals("") 
                | txtBox_contrasenna.Text.Equals(""))
            {
                Response.Write("<script>alert('Todos los campos son requeridos');</script>");
                
            }
            else
            {
                dtoStaff.setStaffNombre(nombre);
                dtoStaff.setStaffUsuario(usu);
                dtoStaff.setStaffContraseña(contra);

                //Enviar el dto al controlador
                controlador.agregarStaff(dtoStaff);

                //MsgBox("Staff Creado", this.Page, this);
                Response.Write("<script>alert('Usuario creado exitosamente');</script>");
                //Hay dos maneras de mandar el mensaje
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