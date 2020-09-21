using AbovePremiere_Ferreyra.DAOs;
using AbovePremiere_Ferreyra.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbovePremiere_Ferreyra
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var usuario = txtUsuario.Text;
            var password = txtPassword.Text;

            /*
              Validacion de input del usuario:
                - Campos !- vacio
                - si yo pido un email, checkear que me hayan escrito un email
                - catcheo de caracteres especiales
            */

            // Existe usuario con esas credenciales

            if(UsuariosDAO.existeUsuario(usuario, password))
            {
                var form = new AbovePremiere();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Si existe -> Pasa a form 2
            // Si no existe -> Arrojo Cartel de error
        }

    }
}
