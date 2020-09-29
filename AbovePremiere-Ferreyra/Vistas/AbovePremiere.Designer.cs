namespace AbovePremiere_Ferreyra.Vistas
{
    partial class AbovePremiere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSeleccionarArchivo = new System.Windows.Forms.Label();
            this.opdbuscador = new System.Windows.Forms.OpenFileDialog();
            this.txtbuscarArchivo = new System.Windows.Forms.Button();
            this.lblnombreArchivo = new System.Windows.Forms.Label();
            this.tabextraerImg = new System.Windows.Forms.TabPage();
            this.btnguardarCapturas = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblcapturas = new System.Windows.Forms.Label();
            this.tabcambiarRel = new System.Windows.Forms.TabPage();
            this.btndescargarVideo = new System.Windows.Forms.Button();
            this.cbxresoluciones = new System.Windows.Forms.ComboBox();
            this.lblseleccionarResolucion = new System.Windows.Forms.Label();
            this.tabconvertir = new System.Windows.Forms.TabPage();
            this.btnconvertirVideo = new System.Windows.Forms.Button();
            this.cbxeliminarAudio = new System.Windows.Forms.CheckBox();
            this.cbxformatos = new System.Windows.Forms.ComboBox();
            this.lblseleccionarFormato = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fbdbajar = new System.Windows.Forms.FolderBrowserDialog();
            this.tabextraerImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabcambiarRel.SuspendLayout();
            this.tabconvertir.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeleccionarArchivo
            // 
            this.lblSeleccionarArchivo.AutoSize = true;
            this.lblSeleccionarArchivo.Location = new System.Drawing.Point(12, 22);
            this.lblSeleccionarArchivo.Name = "lblSeleccionarArchivo";
            this.lblSeleccionarArchivo.Size = new System.Drawing.Size(101, 13);
            this.lblSeleccionarArchivo.TabIndex = 0;
            this.lblSeleccionarArchivo.Text = "Seleccionar archivo";
            // 
            // opdbuscador
            // 
            this.opdbuscador.FileName = "Seleccionar archivo";
            this.opdbuscador.Filter = "Solo video (*.mp4; *.avi; *.mpeg; *.flv)|*.mp4; *.avi; *.mpeg; *.flv;";
            // 
            // txtbuscarArchivo
            // 
            this.txtbuscarArchivo.Location = new System.Drawing.Point(119, 17);
            this.txtbuscarArchivo.Name = "txtbuscarArchivo";
            this.txtbuscarArchivo.Size = new System.Drawing.Size(75, 23);
            this.txtbuscarArchivo.TabIndex = 3;
            this.txtbuscarArchivo.Text = "buscar ";
            this.txtbuscarArchivo.UseVisualStyleBackColor = true;
            this.txtbuscarArchivo.Click += new System.EventHandler(this.txtbuscarArchivo_Click);
            // 
            // lblnombreArchivo
            // 
            this.lblnombreArchivo.AutoSize = true;
            this.lblnombreArchivo.Location = new System.Drawing.Point(200, 22);
            this.lblnombreArchivo.Name = "lblnombreArchivo";
            this.lblnombreArchivo.Size = new System.Drawing.Size(0, 13);
            this.lblnombreArchivo.TabIndex = 4;
            // 
            // tabextraerImg
            // 
            this.tabextraerImg.Controls.Add(this.btnguardarCapturas);
            this.tabextraerImg.Controls.Add(this.numericUpDown1);
            this.tabextraerImg.Controls.Add(this.lblcapturas);
            this.tabextraerImg.Location = new System.Drawing.Point(4, 22);
            this.tabextraerImg.Name = "tabextraerImg";
            this.tabextraerImg.Padding = new System.Windows.Forms.Padding(3);
            this.tabextraerImg.Size = new System.Drawing.Size(476, 116);
            this.tabextraerImg.TabIndex = 3;
            this.tabextraerImg.Text = "Extraer capturas";
            this.tabextraerImg.UseVisualStyleBackColor = true;
            // 
            // btnguardarCapturas
            // 
            this.btnguardarCapturas.Location = new System.Drawing.Point(354, 87);
            this.btnguardarCapturas.Name = "btnguardarCapturas";
            this.btnguardarCapturas.Size = new System.Drawing.Size(116, 23);
            this.btnguardarCapturas.TabIndex = 2;
            this.btnguardarCapturas.Text = "Guardar capturas";
            this.btnguardarCapturas.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(124, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // lblcapturas
            // 
            this.lblcapturas.AutoSize = true;
            this.lblcapturas.Location = new System.Drawing.Point(6, 14);
            this.lblcapturas.Name = "lblcapturas";
            this.lblcapturas.Size = new System.Drawing.Size(112, 13);
            this.lblcapturas.TabIndex = 0;
            this.lblcapturas.Text = "Frames entre capturas";
            // 
            // tabcambiarRel
            // 
            this.tabcambiarRel.Controls.Add(this.btndescargarVideo);
            this.tabcambiarRel.Controls.Add(this.cbxresoluciones);
            this.tabcambiarRel.Controls.Add(this.lblseleccionarResolucion);
            this.tabcambiarRel.Location = new System.Drawing.Point(4, 22);
            this.tabcambiarRel.Name = "tabcambiarRel";
            this.tabcambiarRel.Padding = new System.Windows.Forms.Padding(3);
            this.tabcambiarRel.Size = new System.Drawing.Size(476, 116);
            this.tabcambiarRel.TabIndex = 2;
            this.tabcambiarRel.Text = "Cambiar resolución";
            this.tabcambiarRel.UseVisualStyleBackColor = true;
            // 
            // btndescargarVideo
            // 
            this.btndescargarVideo.Location = new System.Drawing.Point(354, 87);
            this.btndescargarVideo.Name = "btndescargarVideo";
            this.btndescargarVideo.Size = new System.Drawing.Size(116, 23);
            this.btndescargarVideo.TabIndex = 4;
            this.btndescargarVideo.Text = "Descargar video";
            this.btndescargarVideo.UseVisualStyleBackColor = true;
            // 
            // cbxresoluciones
            // 
            this.cbxresoluciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxresoluciones.FormattingEnabled = true;
            this.cbxresoluciones.Location = new System.Drawing.Point(123, 17);
            this.cbxresoluciones.Name = "cbxresoluciones";
            this.cbxresoluciones.Size = new System.Drawing.Size(121, 21);
            this.cbxresoluciones.TabIndex = 3;
            // 
            // lblseleccionarResolucion
            // 
            this.lblseleccionarResolucion.AutoSize = true;
            this.lblseleccionarResolucion.Location = new System.Drawing.Point(3, 20);
            this.lblseleccionarResolucion.Name = "lblseleccionarResolucion";
            this.lblseleccionarResolucion.Size = new System.Drawing.Size(114, 13);
            this.lblseleccionarResolucion.TabIndex = 2;
            this.lblseleccionarResolucion.Text = "Seleccionar resolución";
            // 
            // tabconvertir
            // 
            this.tabconvertir.Controls.Add(this.btnconvertirVideo);
            this.tabconvertir.Controls.Add(this.cbxeliminarAudio);
            this.tabconvertir.Controls.Add(this.cbxformatos);
            this.tabconvertir.Controls.Add(this.lblseleccionarFormato);
            this.tabconvertir.Location = new System.Drawing.Point(4, 22);
            this.tabconvertir.Name = "tabconvertir";
            this.tabconvertir.Padding = new System.Windows.Forms.Padding(3);
            this.tabconvertir.Size = new System.Drawing.Size(476, 116);
            this.tabconvertir.TabIndex = 0;
            this.tabconvertir.Text = "Convertir";
            this.tabconvertir.UseVisualStyleBackColor = true;
            // 
            // btnconvertirVideo
            // 
            this.btnconvertirVideo.Location = new System.Drawing.Point(354, 87);
            this.btnconvertirVideo.Name = "btnconvertirVideo";
            this.btnconvertirVideo.Size = new System.Drawing.Size(116, 23);
            this.btnconvertirVideo.TabIndex = 5;
            this.btnconvertirVideo.Text = "Convertir video";
            this.btnconvertirVideo.UseVisualStyleBackColor = true;
            this.btnconvertirVideo.Click += new System.EventHandler(this.btnconvertirVideo_Click);
            // 
            // cbxeliminarAudio
            // 
            this.cbxeliminarAudio.AutoSize = true;
            this.cbxeliminarAudio.Location = new System.Drawing.Point(113, 57);
            this.cbxeliminarAudio.Name = "cbxeliminarAudio";
            this.cbxeliminarAudio.Size = new System.Drawing.Size(91, 17);
            this.cbxeliminarAudio.TabIndex = 4;
            this.cbxeliminarAudio.Text = "Eliminar audio";
            this.cbxeliminarAudio.UseVisualStyleBackColor = true;
            // 
            // cbxformatos
            // 
            this.cbxformatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxformatos.FormattingEnabled = true;
            this.cbxformatos.Location = new System.Drawing.Point(158, 18);
            this.cbxformatos.Name = "cbxformatos";
            this.cbxformatos.Size = new System.Drawing.Size(121, 21);
            this.cbxformatos.TabIndex = 2;
            // 
            // lblseleccionarFormato
            // 
            this.lblseleccionarFormato.AutoSize = true;
            this.lblseleccionarFormato.Location = new System.Drawing.Point(6, 21);
            this.lblseleccionarFormato.Name = "lblseleccionarFormato";
            this.lblseleccionarFormato.Size = new System.Drawing.Size(146, 13);
            this.lblseleccionarFormato.TabIndex = 1;
            this.lblseleccionarFormato.Text = "Seleccionar formato de salida";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabconvertir);
            this.tabControl1.Controls.Add(this.tabcambiarRel);
            this.tabControl1.Controls.Add(this.tabextraerImg);
            this.tabControl1.Location = new System.Drawing.Point(15, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 142);
            this.tabControl1.TabIndex = 5;
            // 
            // fbdbajar
            // 
            this.fbdbajar.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // AbovePremiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 214);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblnombreArchivo);
            this.Controls.Add(this.txtbuscarArchivo);
            this.Controls.Add(this.lblSeleccionarArchivo);
            this.Name = "AbovePremiere";
            this.Tag = "";
            this.Text = "Above Premiere";
            this.tabextraerImg.ResumeLayout(false);
            this.tabextraerImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabcambiarRel.ResumeLayout(false);
            this.tabcambiarRel.PerformLayout();
            this.tabconvertir.ResumeLayout(false);
            this.tabconvertir.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionarArchivo;
        private System.Windows.Forms.OpenFileDialog opdbuscador;
        private System.Windows.Forms.Button txtbuscarArchivo;
        private System.Windows.Forms.Label lblnombreArchivo;
        private System.Windows.Forms.TabPage tabextraerImg;
        private System.Windows.Forms.TabPage tabcambiarRel;
        private System.Windows.Forms.TabPage tabconvertir;
        private System.Windows.Forms.CheckBox cbxeliminarAudio;
        private System.Windows.Forms.ComboBox cbxformatos;
        private System.Windows.Forms.Label lblseleccionarFormato;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblseleccionarResolucion;
        private System.Windows.Forms.ComboBox cbxresoluciones;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblcapturas;
        private System.Windows.Forms.Button btnguardarCapturas;
        private System.Windows.Forms.Button btndescargarVideo;
        private System.Windows.Forms.Button btnconvertirVideo;
        private System.Windows.Forms.FolderBrowserDialog fbdbajar;
    }
}