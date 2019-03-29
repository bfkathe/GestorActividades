using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gestor_Actividades.DTO1;

namespace Gestor_Actividades.Negocio
{
    public class Controlador
    {
        public DAOBD conexion = new DAOBD();
        public Controlador(){}

        //Agregar staff (Prueba)
        public void agregarStaff(DTO dto)
        {
            conexion.agregarStaff(
                dto.getStaffNombre(),
                dto.getStaffUsuario(),
                dto.getStaffContraseña());
        }

    }
}