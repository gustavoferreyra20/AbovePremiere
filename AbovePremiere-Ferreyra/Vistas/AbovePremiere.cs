using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbovePremiere_Ferreyra.Vistas
{
    public partial class AbovePremiere : Form
    {
        public AbovePremiere()
        {
            InitializeComponent();
            CargarFormatos();
        }

        public void CargarFormatos()
        {
            _ = this.cbxformatos.Items.Add("mp4");
            _ = this.cbxformatos.Items.Add("avi");
            _ = this.cbxformatos.Items.Add("mpeg");
            _ = this.cbxformatos.Items.Add("flv");
        }

        private void txtbuscarArchivo_Click(object sender, EventArgs e)
        {

            DialogResult result = opdbuscador.ShowDialog();

            if (result == DialogResult.OK) 
            {
                string direccion = opdbuscador.FileName;
                string titulo = opdbuscador.SafeFileName;

                this.lblnombreArchivo.Text = titulo;
            }
        }

    }
}
