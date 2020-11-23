﻿using AbovePremiere_Ferreyra.FFMPEG;
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
        private string[] formatosValidos = new[] { ".mp4", ".avi", ".mpeg", ".flv" };
        private string[] resolucionesValidas = new[] { "1920x1080", "1280x720", "1024x576", "768x432", "512x288", "256x144" };


        public AbovePremiere()
        {
            InitializeComponent();
            cargarFormatos();
            cargarResoluciones();
        }

        public void cargarFormatos()
        {
            foreach(string formato in formatosValidos)
            {
                _ = this.cbxformatos.Items.Add(formato);
            }
        }

        public void cargarResoluciones()
        {
            foreach (string resolucion in resolucionesValidas)
            {
                _ = this.cbxresoluciones.Items.Add(resolucion);
            }

        }

        private void txtbuscarArchivo_Click(object sender, EventArgs e)
        {

            DialogResult result = opdbuscador.ShowDialog();

            if (result == DialogResult.OK) 
            {
                this.archivo = opdbuscador.SafeFileName;
                this.direccionArchivo = opdbuscador.FileName;
                this.nombreArchivo = this.direccionArchivo;
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
                ElegirRuta(this.nombreArchivo + this.cbxformatos.Text);
                if (rutaDisponible(this.direccionArchivo, this.destinoArchivo))
                {
                    ffmpegHandler.cambiarFormato(this.direccionArchivo, this.destinoArchivo);
                }
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
                ElegirRuta(this.archivo);
                if (rutaDisponible(this.direccionArchivo, this.destinoArchivo))
                {
                   ffmpegHandler.cambiarResolucion(this.direccionArchivo, this.cbxresoluciones.Text.Replace("x", ":"), this.destinoArchivo);
                }
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
                ElegirRuta("image-%04d.jpg");
                ffmpegHandler.sacarCapturas(this.direccionArchivo, this.numFrames.Value, this.destinoArchivo);
                reiniciarFfmpeg();

            }
        }

        private void btnextraer_Click(object sender, EventArgs e)
        {
            if (!this.archivoSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ElegirRuta(this.nombreArchivo + ".mp3");
                if (rutaDisponible(this.direccionArchivo, this.destinoArchivo))
                {
                    ffmpegHandler.extraerAudio(this.direccionArchivo, this.destinoArchivo);
                }
                reiniciarFfmpeg();
            }
        }

        private bool rutaDisponible(string archivo, string ruta)
        {
            if (archivo == ruta)
            {
                MessageBox.Show("No se puede sobreescribir el archivo base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (File.Exists(ruta))
            {
                DialogResult dialogResult = MessageBox.Show("Sobreescribir archivo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return (dialogResult == DialogResult.Yes) ? true : false;
            }
            else
            {
                return true;
            }
        }

        private void reiniciarFfmpeg()
        {
            this.direccionArchivo = null;
            this.nombreArchivo = null;
            this.lblnombreArchivo.Text = null;
            this.archivoSeleccionado = false;
        }

        private void ElegirRuta(string archivo)
        {
            DialogResult result = fbdbajar.ShowDialog();
            if (result == DialogResult.OK)
            {
               
               this.destinoArchivo = fbdbajar.SelectedPath + "\\" + archivo;
               
            }
                       
        }
    }
}
