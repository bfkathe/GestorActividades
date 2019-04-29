using Gestor_Actividades.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestor_Actividades.Vista
{
    public partial class PRUEBA : System.Web.UI.Page
    {
        public DTO1.DTO dto = new DTO1.DTO();
        Controlador controlador = new Controlador();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(FileUpload1.FileName);
            byte[] docContent = FileUpload1.FileBytes;

            string name = fi.Name;
            string extension = fi.Extension;

           /* dto.setContenidoDoc(docContent);
            dto.setNombreDoc(name);
            dto.setExtensionDoc(extension);
            controlador.agregarArchivo2(dto);*/

        }
    }
}