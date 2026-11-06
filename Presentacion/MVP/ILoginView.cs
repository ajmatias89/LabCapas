using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.MVP
{
    public interface ILoginView
    {
        string Usuario { get; }
        string Password { get; }

        void MostrarError(string mensaje);
        void MostrarLoginExitoso(Entidades.E_Usuario usuario);
    }
}
