using AbovePremiere_Ferreyra.FFMPEG;
using AbovePremiere_Ferreyra.Modelo;
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
        private String direccionArchivo;
        private String destinoArchivo;
        private String nombreArchivo;


        public AbovePremiere()
        {
            InitializeComponent();
            CargarFormatos();
        }

        public void CargarFormatos()
        {
            _ = this.cbxformatos.Items.Add(".mp4");
            _ = this.cbxformatos.Items.Add(".avi");
            _ = this.cbxformatos.Items.Add(".mpeg");
            _ = this.cbxformatos.Items.Add(".flv");
        }

        private void txtbuscarArchivo_Click(object sender, EventArgs e)
        {

            DialogResult result = opdbuscador.ShowDialog();

            if (result == DialogResult.OK) 
            {
                this.direccionArchivo = opdbuscador.FileName;
                this.nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(this.direccionArchivo);
                this.lblnombreArchivo.Text = nombreArchivo;
            }
        }

        private void btnconvertirVideo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.opdbuscador.FileName))
            {
                MessageBox.Show("Debe seleccionar un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                guardarArchivo();
                ffmpegHandler.cambiarFormato(this.direccionArchivo, this.destinoArchivo + "\\" + this.nombreArchivo + this.cbxformatos.Text);
            }

        }

        private void guardarArchivo()
        {
            DialogResult result = fbdbajar.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.destinoArchivo = fbdbajar.SelectedPath;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
