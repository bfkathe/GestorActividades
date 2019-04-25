using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using Gestor_Actividades.Negocio;
using Gestor_Actividades.Modelo;

namespace Gestor_Actividades.Vista
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public DTO1.DTO dto = new DTO1.DTO();
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dto.setActividadId(singleton.getActividadId());
                List<Actividad> lista = controlador.datosActividades(dto);
                llenarCampos(lista);
            }
            
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

            String lugarActividad = txtBox_lugar.Text;
            String fechaString = txtBox_fecha.Text;
            String cantCupo = txtBox_cantCupos.Text;
            String encargado = txtEncargado.Text;

            //Expresiones regulares para validar
            String validaCaracteres = "[a-zA-ZñÑáéíóúÁÉÍÓÚ\\s]+";
            Match matchLugar = Regex.Match(lugarActividad, validaCaracteres);
            Match matchEncargado = Regex.Match(encargado, validaCaracteres);

            String validaFecha = @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$";
            Match matchFecha = Regex.Match(fechaString, validaFecha);

            String validaNumero = "^[0-9]*$";
            Match matchNumero = Regex.Match(cantCupo, validaNumero);

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
                MsgBox("Numero en cantidad de cupo inválido", this.Page, this);
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
                else
                {
                    cantCupo = "-1";
                }

                String descripcion = txtDescripcion.Text;
                if (descripcion == "")
                {
                    descripcion = "Actividad sin descripcion";
                }
                String nombreActividad = txtBox_nombre.Text;
                String horario = txtBox_horario.Text;

                //String file = FileUpload1.Text; OJOOOOO NO SE COMO JALAR EL ARCHIVO DE LA ACTIVIDAD

                dto.setActividadId(singleton.getActividadId());
                dto.setActividadNombre(nombreActividad);
                dto.setActividadCampus(campus);
                dto.setActividadFecha(fecha);
                dto.setActividadHorario(horario);
                dto.setActividadRestriccion(restriccion);
                dto.setActividadEncargado(encargado);
                dto.setActividadDescripcion(descripcion);
                dto.setActividadCupo(Convert.ToInt32(cantCupo));
                dto.setActividadLugar(lugarActividad);
                try
                {
                    controlador.editarActividad(dto);
                    Response.Redirect("VerActividades.aspx");
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error al editar" + ex.Message);
                }
                

                //String encargado = ListBox1.Text;
                //String descripcion = txtBox_descripcion.Text;

                //String file = FileUpload1.Text; OJOOOOO NO SE COMO JALAR EL ARCHIVO DE LA ACTIVIDAD


                MsgBox("Actividad Registrada", this.Page, this);
            }

        }

        public void llenarCampos(List<Actividad> lista)
        {
            foreach (Actividad item in lista)
            {
                txtBox_fecha.Text = item.getFecha().ToString();
                txtBox_nombre.Text = item.getNombre();
                txtBox_horario.Text = item.getHorario();
                DropDownList_Campus.Text = item.getCampus();
                if (item.getRestriccion())
                {
                    CheckBoxCupo.Checked = true;
                }

                txtEncargado.Text = item.getEncargado();
                if(item.getCantCupos().ToString() == "-1")
                {
                    txtBox_cantCupos.Text = "";
                }
                else
                {
                    txtBox_cantCupos.Text = item.getCantCupos().ToString();
                }
                txtBox_lugar.Text = item.getLugar();

                if(item.getDescripcion() == "Actividad sin descripcion")
                {
                    txtDescripcion.Text = "";
                }
                else
                {
                    txtDescripcion.Text = item.getDescripcion();
                }
                

      
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