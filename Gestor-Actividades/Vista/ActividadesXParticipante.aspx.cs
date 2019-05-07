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
    public partial class ActividadesXParticipante : System.Web.UI.Page
    {
        Controlador controlador = new Controlador();
        DTO dto = new DTO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void botonBuscar_Click(object sender, EventArgs e)
        {
            ListBox_Actividades.Items.Clear();
            List<string> listaActividades = new List<string>();
            dto.setIdParticipante(Convert.ToInt32(txt_ID.Text));
            listaActividades = controlador.actividadesXparticipante(dto);
            //Llenar lista
            foreach (var item in listaActividades)
                ListBox_Actividades.Items.Add(item);
        }
    }
}