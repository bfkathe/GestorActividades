using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            String nombreActividad = txtBox_nombre.Text;
            String campus = DropDownList_Campus.Text;
            String fechaString = txtBox_fecha.Text;

            DateTime fecha = Convert.ToDateTime(fechaString);

            //bool cupo
            String horario = txtBox_horario.Text;
            //String encargado = ListBox1.Text;
            //String descripcion = txtBox_descripcion.Text;
            //String file = FileUpload1.Text; OJOOOOO NO SE COMO JALAR EL ARCHIVO DE LA ACTIVIDAD

            dto.setActividadNombre(nombreActividad);
            dto.setActividadCampus(campus);
            dto.setActividadFecha(fecha);
            dto.setActividadHorario(horario);
           // dto.setActividadEncargado(encargado);
           // dto.setActividadDescripcion(descripcion);


            MsgBox("Actividad Registrada", this.Page, this);

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