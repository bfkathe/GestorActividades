using Gestor_Actividades.DTO1;
using Gestor_Actividades.Modelo;
using Gestor_Actividades.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
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
                String correo = txtBox_correo.Text.Trim(charsToTrim);
                String nombreCompleto = txtBox_nombreParticipante.Text.Trim(charsToTrim) + " " + txtBox_primerAParticipante.Text.Trim(charsToTrim);
                String nombreActividad = singleton.getNombreActividad();
                dto.setActividadId(singleton.getActividadId());
                dto.setIdTipoParticipante(Convert.ToInt32(DropDownList_TipoParticipante.SelectedValue));
                dto.setIdCurso(Convert.ToInt32(DropDownList_Curso.SelectedValue));
                dto.setCampus(DropDownList_Campus.SelectedValue.ToString());
                dto.setIdentificacion(Convert.ToInt32(txtBox_identificacion.Text.Trim(charsToTrim)));
                dto.setNombreP(txtBox_nombreParticipante.Text.Trim(charsToTrim));
                dto.setPrimerApellidoP(txtBox_primerAParticipante.Text.Trim(charsToTrim));
                dto.setSegundoApellidoP(txtBox_segundoAParticipante.Text.Trim(charsToTrim));
                dto.setCorreo(correo);
                dto.setStaffNombre(nombreCompleto);
                dto.setActividadNombre(nombreActividad);

                controlador.agregarParticipante(dto);
                controlador.email_send(dto);

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
    }
}