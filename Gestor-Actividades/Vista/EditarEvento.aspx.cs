using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using Gestor_Actividades.Modelo;
using Gestor_Actividades.Negocio;
using Gestor_Actividades.DTO1;


namespace Gestor_Actividades.Vista
{
    public partial class EditarEvento : System.Web.UI.Page
    {
        DTO dto = new DTO();
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dto.setEventoId(singleton.getEventoId());
                List<Evento> lista = controlador.datosEventos(dto);
                llenarCampos(lista);
            }
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

        public void llenarCampos(List<Evento> lista)
        {
            foreach (Evento item in lista)
            {
                txtBox_nombre.Text = item.getNombre();
                txtBox_horario.Text = item.getHorario();
                txtBox_descripcion.Text = item.getDescripcion();
                txtBox_expositor.Text = item.getExpositor();
            }
        }
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        protected void botonGuardarCambios_Click1(object sender, EventArgs e)
        {
            String nombre = txtBox_nombre.Text;
            String expo = txtBox_expositor.Text;

            //Expresiones regulares para validar
            String validaCaracteres = "[a-zA-ZñÑáéíóúÁÉÍÓÚ\\s]+";
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
            dto.setEventoId(singleton.getEventoId());



            try
            {
                controlador.editarEvento(dto);
                Response.Redirect("VerActividades.aspx");
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al editar evento GUI" + ex.Message);
            }
            


            MsgBox("Evento Registrado", this.Page, this);
        }

        protected void botonDesinscribir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Desinscribir.aspx");
        }
    }

        
    
}