using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gestor_Actividades.DTO1;
using Gestor_Actividades.Modelo;
using Gestor_Actividades.Negocio;

namespace Gestor_Actividades.Vista
{
    public partial class VerArchivos : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        Singleton singleton = Singleton.Instance;
        DTO dto = new DTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                System.Diagnostics.Debug.WriteLine(singleton.getActividadId());
                List<Lista> lista = controlador.llenarArchivos(singleton.getActividadId());
                CheckBoxList_Archivos.DataTextField = "nombre";
                CheckBoxList_Archivos.DataValueField = "id";
                CheckBoxList_Archivos.DataSource = lista;
                CheckBoxList_Archivos.DataBind();
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

        public byte[] databaseFilePut(string varFilePath)
        {
           
            byte[] file = File.ReadAllBytes(varFilePath);
            return file;
        }

        protected void FileUpload_VerArchivos_DataBinding(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("escogí un archivo");
        }

        protected void btn_UploadArchivo_Click(object sender, EventArgs e)
        {
            var fileName = "";
            var fileSavePath = "";
            string extension = "";
            byte[] contenido;
            var uploadedFile = Request.Files[0];
            fileName = Path.GetFileName(uploadedFile.FileName);
            extension = Path.GetExtension(uploadedFile.FileName);
            fileSavePath = Server.MapPath("~//UploadedFiles//" + fileName);
            uploadedFile.SaveAs(fileSavePath);
            contenido = databaseFilePut(fileSavePath);
            System.Diagnostics.Debug.WriteLine(fileName);
            System.Diagnostics.Debug.WriteLine(extension);
            System.Diagnostics.Debug.WriteLine(contenido.ToString());
            dto.setArchivoActividadId(singleton.getActividadId());
            dto.setArchivoNombre(fileName);
            dto.setArchivoContenido(contenido);
            dto.setArchivoFormato(extension);
            controlador.agregarArchivo(dto);
            Response.Redirect("VerArchivos.aspx");

        }

        protected void btn_EliminarArchivo_Click(object sender, EventArgs e)
        {
            foreach (ListItem item in CheckBoxList_Archivos.Items)
            {
                if (item.Selected)
                {
                    singleton.setArchivoId(Convert.ToInt32(item.Value));
                }
            }

            dto.setArchivoId(singleton.getArchivoId());

            try
            {
                controlador.eliminarArchivo(dto);
                System.Diagnostics.Debug.WriteLine("Archivo eliminado");
                Response.Redirect("VerArchivos.aspx");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al eliminar archivo", ex);
            }
        }




    }
}