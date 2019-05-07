using Gestor_Actividades.DTO1;
using Gestor_Actividades.Modelo;
using Gestor_Actividades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestor_Actividades.Vista
{
    public partial class Inscripcion : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;
        DTO dto = new DTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Lista> lista = controlador.llenarCursos();
                DropDownList_Curso.DataTextField = "nombre";
                DropDownList_Curso.DataValueField = "id";
                DropDownList_Curso.DataSource = lista;
                DropDownList_Curso.DataBind();

                List<Lista> lista2 = controlador.llenarTiposParticipantes();
                DropDownList_TipoParticipante.DataTextField = "nombre";
                DropDownList_TipoParticipante.DataValueField = "id";
                DropDownList_TipoParticipante.DataSource = lista2;
                DropDownList_TipoParticipante.DataBind();
            }
        }

        protected void botonInscribirParticipante_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = {' '};
            try
            {
                //Expresiones regulares
                String validaCaracteres = "[a-zA-ZñÑáéíóúÁÉÍÓÚ\\s]+";
                String validaNumero = "^[0-9]*$";
                String validaCorreo = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$";

                //Datos a verificar
                String correo = txtBox_correo.Text.Trim(charsToTrim);
                String nombreCompleto = txtBox_nombreParticipante.Text.Trim(charsToTrim) + " " + txtBox_primerAParticipante.Text.Trim(charsToTrim);
                String nombreActividad = singleton.getNombreActividad();
                String nombre = txtBox_nombreParticipante.Text.Trim(charsToTrim);
                String primerApellido = txtBox_primerAParticipante.Text.Trim(charsToTrim);
                String segundoApellido = txtBox_segundoAParticipante.Text.Trim(charsToTrim);
                String identificacion = txtBox_identificacion.Text.Trim(charsToTrim);
                
                //Matches
                Match matchNombre = Regex.Match(nombre, validaCaracteres);
                Match matchApellido1 = Regex.Match(primerApellido, validaCaracteres);
                Match matchApellido2 = Regex.Match(segundoApellido, validaCaracteres);
                Match matchIdentificacion = Regex.Match(identificacion,validaNumero);
                Match matchCorreo = Regex.Match(correo,validaCorreo);

                //Validaciones
                if(!matchNombre.Success || !matchApellido1.Success || !matchApellido2.Success)
                {
                    MsgBox("El nombre y apellidos no pueden contener carácteres especiales o números", this.Page, this);
                }else if (!matchIdentificacion.Success)
                {
                    MsgBox("La identificacion puede contener unicamente números", this.Page, this);
                }
                else if (!matchCorreo.Success)
                {
                    MsgBox("Formato de correo inválido", this.Page, this);
                }
                else
                {
                    //Datos del participante
                    dto.setActividadId(singleton.getActividadId());
                    dto.setIdTipoParticipante(Convert.ToInt32(DropDownList_TipoParticipante.SelectedValue));
                    dto.setIdCurso(Convert.ToInt32(DropDownList_Curso.SelectedValue));
                    dto.setCampus(DropDownList_Campus.SelectedValue.ToString());
                    dto.setIdentificacion(Convert.ToInt32(identificacion));
                    dto.setNombreP(nombre);
                    dto.setPrimerApellidoP(primerApellido);
                    dto.setSegundoApellidoP(segundoApellido);
                    dto.setCorreo(correo);

                    //Datos para el correo
                    dto.setStaffNombre(nombreCompleto);
                    dto.setActividadNombre(nombreActividad);

                    if (controlador.verificarRegistro(dto))
                    {
                        MsgBox("Usted ya se encuentra inscrito en esta actividad", this.Page, this);
                        txtBox_correo.Text = "";
                        txtBox_identificacion.Text = "";
                        txtBox_nombreParticipante.Text = "";
                        txtBox_primerAParticipante.Text = "";
                        txtBox_segundoAParticipante.Text = "";
                    }
                    else
                    {
                        if (controlador.cantCuposDisponibles(dto) > 0)
                        {
                            controlador.agregarParticipante(dto);
                            controlador.disminuirCupo(dto);
                            controlador.email_send(dto);
                            MsgBox("Inscripción exitosa", this.Page, this);
                        }
                        else if(controlador.cantCuposDisponibles(dto) == -1)
                        {
                            controlador.agregarParticipante(dto);
                            controlador.email_send(dto);
                            MsgBox("Inscripción exitosa", this.Page, this);
                        }
                        else
                        {
                            MsgBox("No hay cupo disponible", this.Page, this);
                        }
                    }
                    
                }

                

            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al registrar participante", ex);
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

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}