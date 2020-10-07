using AbovePremiere_Ferreyra.FFMPEG;
using AbovePremiere_Ferreyra.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbovePremiere_Ferreyra.Vistas
{
    public partial class AbovePremiere : Form
    {
        private string direccionArchivo;
        private string destinoArchivo;
        private string nombreArchivo;
        private string archivo;
        private bool archivoSeleccionado = false;

        public AbovePremiere()
        {
            InitializeComponent();
            cargarFormatos();
            cargarResoluciones();
        }

        public void cargarFormatos()
        {
            _ = this.cbxformatos.Items.Add(".mp4");
            _ = this.cbxformatos.Items.Add(".avi");
            _ = this.cbxformatos.Items.Add(".mpeg");
            _ = this.cbxformatos.Items.Add(".flv");
        }

        public void cargarResoluciones()
        {
            _ = this.cbxresoluciones.Items.Add("1920x1080");
            _ = this.cbxresoluciones.Items.Add("1280x720");
            _ = this.cbxresoluciones.Items.Add("1024x576");
            _ = this.cbxresoluciones.Items.Add("768x432");
            _ = this.cbxresoluciones.Items.Add("512x288");
            _ = this.cbxresoluciones.Items.Add("256x144 ");
        }

        private void txtbuscarArchivo_Click(object sender, EventArgs e)
        {

            DialogResult result = opdbuscador.ShowDialog();

            if (result == DialogResult.OK) 
            {
                this.archivo = opdbuscador.SafeFileName;
                this.direccionArchivo = opdbuscador.FileName;
                this.nombreArchivo = Path.GetFileNameWithoutExtension(this.direccionArchivo);
                this.lblnombreArchivo.Text = this.nombreArchivo;
                this.archivoSeleccionado = true;
            }
        }

        private void btnconvertirVideo_Click(object sender, EventArgs e)
        {
            if (!this.archivoSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                guardarArchivo(this.nombreArchivo + this.cbxformatos.Text);
                ffmpegHandler.cambiarFormato(this.direccionArchivo, this.destinoArchivo);
                reiniciarFfmpeg();
            }

        }

        private void btndescargarVideo_Click(object sender, EventArgs e)
        {
            if (!this.archivoSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                guardarArchivo(this.archivo);
                ffmpegHandler.cambiarResolucion(this.direccionArchivo, this.cbxresoluciones.Text.Replace("x", ":"), this.destinoArchivo);
                //sobreEscribir(this.destinoArchivo);
                reiniciarFfmpeg();
            }
        }

        private void btnguardarCapturas_Click(object sender, EventArgs e)
        {
            if (!this.archivoSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                guardarArchivo("image-%04d.jpg");
                ffmpegHandler.sacarCapturas(this.direccionArchivo, this.numFrames.Value, this.destinoArchivo);
                reiniciarFfmpeg();
            }
        }

        private void sobreEscribir(string archivo)
        {
            if (File.Exists(archivo))
            {
                DialogResult dialogResult = MessageBox.Show("Sobreescribir archivo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ffmpegHandler.sobreEscribir("y");
                }
                else if (dialogResult == DialogResult.No)
                {
                    ffmpegHandler.sobreEscribir("n");
                }
            }
        }

        private void reiniciarFfmpeg()
        {
            this.direccionArchivo = null;
            this.nombreArchivo = null;
            this.lblnombreArchivo.Text = null;
            this.archivoSeleccionado = false;
        }

        private void guardarArchivo(string archivo)
        {
            DialogResult result = fbdbajar.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.destinoArchivo = fbdbajar.SelectedPath + "\\" + archivo;
                
            }
        }
    }
}
