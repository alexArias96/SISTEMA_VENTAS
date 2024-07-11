using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Usuario
    {
        //Instancia
        private CD_Usuarios objcd_usuario = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar(); //Metodo de mi instancia
        }

    }
}
