using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestor_Actividades.Vista
{
    public partial class VerArchivos : System.Web.UI.Page
    {
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

        protected void btn_EliminarArchivo_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath(FileUpload_VerArchivos.PostedFile.FileName);
           System.Diagnostics.Debug.WriteLine(path);
           System.Diagnostics.Debug.WriteLine(databaseFilePut(path));
        }

        public byte[] databaseFilePut(string varFilePath)
        {
            
            using (FileStream fs = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] file = File.ReadAllBytes(varFilePath);
                fs.Read(file, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                return file;

            }
            
        }

        protected void FileUpload_VerArchivos_DataBinding(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("escogí un archivo");
        }
        /*

   // Read the file and convert it to Byte Array
   byte[] data;
   //get file extension
   string extension = FileName.Substring(FileName.LastIndexOf(".") + 1);
   string fileType = "";
   //set the file type based on File Extension
   switch (extension)
   {
       case "doc":
           fileType = "application/vnd.ms-word";
           break;
       case "docx":
           fileType = "application/vnd.ms-word";
           break;
       case "xls":
           fileType = "application/vnd.ms-excel";
           break;
       case "xlsx":
           fileType = "application/vnd.ms-excel";
           break;
       case "jpg":
           fileType = "image/jpg";
           break;
       case "png":
           fileType = "image/png";
           break;
       case "gif":
           fileType = "image/gif";
           break;
       case "pdf":
           fileType = "application/pdf";
           break;
   }
*/
    }
}