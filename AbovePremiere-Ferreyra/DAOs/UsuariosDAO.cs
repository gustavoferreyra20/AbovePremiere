using AbovePremiere_Ferreyra.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbovePremiere_Ferreyra.DAOs
{
    class UsuariosDAO
    {

        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public static void iniciar()
        {
            listaUsuarios.Add(new Usuario("usuario1", "usuario1"));
            listaUsuarios.Add(new Usuario("usuario2", "usuario2"));
            listaUsuarios.Add(new Usuario("usuario3", "usuario3"));
        }

        public static bool existeUsuario(String usuario, string password)
        {

            var usuarioEncontrado = listaUsuarios.Find(usuarioObj => usuarioObj.usuario == usuario && usuarioObj.password == password);

            if(usuarioEncontrado == null)
            {
                return true;
            }
            else
            {
                return true;
            }

            // Llamado a la API
        }
    }
}
