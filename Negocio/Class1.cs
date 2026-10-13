using Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Usuario
    {
        public static E_Usuario Login(string strUsuario, string strPassword)
        {
            return D_Usuario.Login(strUsuario, strPassword);
        }
    }
}
