using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gestor_Actividades.DTO1;
using Gestor_Actividades.Negocio;
using System.Text.RegularExpressions;

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

            //Expresiones regulares para validar
            String validaCaracteres = "[a-zA-ZñÑáéíóúÁÉÍÓÚ\\s]+";
            Match matchNombre = Regex.Match(validaCaracteres, validaCaracteres);

            if (!matchNombre.Success)
            {
                MsgBox("Nombre Invalido",this.Page,this);
            }
            else
            {
                String contra = txtBox_contrasenna.Text;
                String usu = txtBox_nombreUsuario.Text;

                if (txtBox_nombre.Text.Equals("") | txtBox_nombreUsuario.Text.Equals("")
                    | txtBox_contrasenna.Text.Equals(""))
                {
                    Response.Write("<script>alert('Todos los campos son requeridos');</script>");

                }
                else
                {

                    dtoStaff.setStaffNombre(nombre);
                    dtoStaff.setStaffUsuario(usu);
                    dtoStaff.setStaffContraseña(contra);

                    Boolean existe = controlador.verificarStaff(dtoStaff);

                    if (existe) {
                        MsgBox("Nombre de usuario ya existente", this.Page, this);
                    }
                    else
                    {
                        //Enviar el dto al controlador
                        controlador.agregarStaff(dtoStaff);
                        Response.Write("<script>alert('Usuario creado exitosamente');</script>");
                    }
                        
                }
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