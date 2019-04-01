using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Gestor_Actividades.Vista
{
    public partial class CrearActividad : System.Web.UI.Page
    {
        public DTO1.DTO dto = new DTO1.DTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void botonCrearAct_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearActividad.aspx");
        }

        protected void botonCrearStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }

        protected void botonVerAct_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerActividades.aspx");
        }

        protected void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (CheckBoxCupo.Checked)
            {
                //MsgBox("Hola",this.Page,this);
                //Codigo del check
            }

            
            String lugarActividad = txtBox_lugar.Text;
            String fechaString = txtBox_fecha.Text;
            String cantCupo = txtBox_cantCupos.Text;
            String encargado = txtEncargado.Text;

            //Expresiones regulares para validar
            String validaCaracteres = "[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+";
            Match matchLugar = Regex.Match(lugarActividad, validaCaracteres);
            Match matchEncargado = Regex.Match(encargado,validaCaracteres);

            String validaFecha = @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$";
            Match matchFecha = Regex.Match(fechaString,validaFecha);

            String validaNumero = "^[0-9]+$";
            Match matchNumero = Regex.Match(cantCupo,validaNumero);

            if (!matchLugar.Success || !matchEncargado.Success)
            {
                MsgBox("El nombre de la actividad, encargado o lugar es inválido.", this.Page, this);

            }
            else if (!matchFecha.Success)
            {
                MsgBox("Fecha inválida, siga formato dd/mm/yyyy.", this.Page, this);
            }
            else if (!matchNumero.Success)
            {
                MsgBox("Numero en cantidad de cupo inválido", this.Page,this);
            }
            else
            {


                DateTime fecha = Convert.ToDateTime(fechaString);
                String campus = DropDownList_Campus.Text;
                bool restriccion = false;
                if (CheckBoxCupo.Checked == true)
                {
                    restriccion = true;
                }

                String descripcion = txtDescripcion.Text;
                String nombreActividad = txtBox_nombre.Text;
                String horario = txtBox_horario.Text;

                //String file = FileUpload1.Text; OJOOOOO NO SE COMO JALAR EL ARCHIVO DE LA ACTIVIDAD

                dto.setActividadNombre(nombreActividad);
                dto.setActividadCampus(campus);
                dto.setActividadFecha(fecha);
                dto.setActividadHorario(horario);
                dto.setActividadRestriccion(restriccion);
                dto.setActividadEncargado(encargado);
                dto.setActividadDescripcion(descripcion);

                //String encargado = ListBox1.Text;
                //String descripcion = txtBox_descripcion.Text;

                //String file = FileUpload1.Text; OJOOOOO NO SE COMO JALAR EL ARCHIVO DE LA ACTIVIDAD


                MsgBox("Actividad Registrada", this.Page, this);
            }

        }

        protected void CheckBoxCupo_Check(object sender, EventArgs e)
        {
            if (CheckBoxCupo.Checked == true)
            {
                //codigo de check
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