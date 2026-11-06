
using System;
using Entidades;
using Negocio;

namespace Presentacion.MVP
{
    public class LoginPresenter
    {
        private readonly ILoginView vista;

        public LoginPresenter(ILoginView vista)
        {
            this.vista = vista;
        }

        public void IniciarSesion()
        {
            string usuario = vista.Usuario;
            string password = vista.Password;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(password))
            {
                vista.MostrarError(
                    "Debe ingresar usuario y contraseña.");
                return;
            }

            try
            {
                E_Usuario usuarioAutenticado =
                    N_Usuario.Login(usuario, password);

                if (usuarioAutenticado != null)
                {
                    vista.MostrarLoginExitoso(usuarioAutenticado);
                }
                else
                {
                    vista.MostrarError(
                        "Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception)
            {
                vista.MostrarError(
                    "No fue posible iniciar sesión. Verifique la conexión.");
            }
        }
    }
}
