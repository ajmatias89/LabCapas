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
        private static readonly IHashService hashService =
                    new HashService();

        private static readonly IVerificarHashService verificarService =
            new HashService();

        public static E_Usuario Login(string strUsuario, string strPassword)
        {
            return D_Usuario.Login(strUsuario, strPassword);
        }

        public static string GenerarHash(string password)
        {
            return hashService.GenerarHash(password);
        }

        public static bool VerificarHash(string password, string hashAlmacenado)
        {
            return verificarService.VerificarHash(password, hashAlmacenado);
        }
    }
}
