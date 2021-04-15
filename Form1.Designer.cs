
namespace Reproductor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.LbCancion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBsiguiente = new System.Windows.Forms.PictureBox();
            this.PBPlay = new System.Windows.Forms.PictureBox();
            this.PBanterior = new System.Windows.Forms.PictureBox();
            this.PBDelete = new System.Windows.Forms.PictureBox();
            this.PBAgregar = new System.Windows.Forms.PictureBox();
            this.MtBduracion = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MtBVolumen = new XComponent.SliderBar.MACTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCircular = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBsiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBanterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(537, 199);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(75, 23);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            this.Reproductor.StatusChange += new System.EventHandler(this.Reproductor_StatusChange);
            this.Reproductor.Enter += new System.EventHandler(this.Reproductor_Enter);
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 16;
            this.lstCanciones.Location = new System.Drawing.Point(12, 78);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(206, 212);
            this.lstCanciones.TabIndex = 2;
            // 
            // LbCancion
            // 
            this.LbCancion.AutoSize = true;
            this.LbCancion.Location = new System.Drawing.Point(15, 18);
            this.LbCancion.Name = "LbCancion";
            this.LbCancion.Size = new System.Drawing.Size(18, 17);
            this.LbCancion.TabIndex = 8;
            this.LbCancion.Text = "--";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PBsiguiente
            // 
            this.PBsiguiente.Image = global::Reproductor.Properties.Resources.Siguiente;
            this.PBsiguiente.Location = new System.Drawing.Point(118, 296);
            this.PBsiguiente.Name = "PBsiguiente";
            this.PBsiguiente.Size = new System.Drawing.Size(47, 45);
            this.PBsiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBsiguiente.TabIndex = 6;
            this.PBsiguiente.TabStop = false;
            this.PBsiguiente.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PBPlay
            // 
            this.PBPlay.Image = global::Reproductor.Properties.Resources.play;
            this.PBPlay.Location = new System.Drawing.Point(65, 296);
            this.PBPlay.Name = "PBPlay";
            this.PBPlay.Size = new System.Drawing.Size(47, 45);
            this.PBPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPlay.TabIndex = 5;
            this.PBPlay.TabStop = false;
            this.PBPlay.Click += new System.EventHandler(this.PBPlay_Click);
            // 
            // PBanterior
            // 
            this.PBanterior.Image = global::Reproductor.Properties.Resources.Anterior;
            this.PBanterior.Location = new System.Drawing.Point(12, 296);
            this.PBanterior.Name = "PBanterior";
            this.PBanterior.Size = new System.Drawing.Size(47, 45);
            this.PBanterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBanterior.TabIndex = 4;
            this.PBanterior.TabStop = false;
            this.PBanterior.Click += new System.EventHandler(this.PBanterior_Click);
            // 
            // PBDelete
            // 
            this.PBDelete.Image = ((System.Drawing.Image)(resources.GetObject("PBDelete.Image")));
            this.PBDelete.Location = new System.Drawing.Point(234, 155);
            this.PBDelete.Name = "PBDelete";
            this.PBDelete.Size = new System.Drawing.Size(60, 45);
            this.PBDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBDelete.TabIndex = 3;
            this.PBDelete.TabStop = false;
            this.PBDelete.Click += new System.EventHandler(this.PBDelete_Click);
            // 
            // PBAgregar
            // 
            this.PBAgregar.Image = ((System.Drawing.Image)(resources.GetObject("PBAgregar.Image")));
            this.PBAgregar.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBAgregar.InitialImage")));
            this.PBAgregar.Location = new System.Drawing.Point(234, 88);
            this.PBAgregar.Name = "PBAgregar";
            this.PBAgregar.Size = new System.Drawing.Size(60, 45);
            this.PBAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAgregar.TabIndex = 1;
            this.PBAgregar.TabStop = false;
            this.PBAgregar.Click += new System.EventHandler(this.PBAgregar_Click);
            // 
            // MtBduracion
            // 
            this.MtBduracion.BackColor = System.Drawing.Color.Transparent;
            this.MtBduracion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.MtBduracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtBduracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MtBduracion.IndentHeight = 6;
            this.MtBduracion.Location = new System.Drawing.Point(12, 38);
            this.MtBduracion.Maximum = 10;
            this.MtBduracion.Minimum = 0;
            this.MtBduracion.Name = "MtBduracion";
            this.MtBduracion.Size = new System.Drawing.Size(206, 28);
            this.MtBduracion.TabIndex = 9;
            this.MtBduracion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBduracion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.MtBduracion.TickHeight = 4;
            this.MtBduracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBduracion.TrackerColor = System.Drawing.Color.Black;
            this.MtBduracion.TrackerSize = new System.Drawing.Size(16, 16);
            this.MtBduracion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.MtBduracion.TrackLineHeight = 3;
            this.MtBduracion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.MtBduracion.Value = 0;
            this.MtBduracion.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtBduracion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volumen";
            // 
            // MtBVolumen
            // 
            this.MtBVolumen.BackColor = System.Drawing.Color.Transparent;
            this.MtBVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.MtBVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtBVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MtBVolumen.IndentHeight = 6;
            this.MtBVolumen.Location = new System.Drawing.Point(12, 364);
            this.MtBVolumen.Maximum = 100;
            this.MtBVolumen.Minimum = 0;
            this.MtBVolumen.Name = "MtBVolumen";
            this.MtBVolumen.Size = new System.Drawing.Size(206, 28);
            this.MtBVolumen.TabIndex = 11;
            this.MtBVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.MtBVolumen.TickHeight = 4;
            this.MtBVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MtBVolumen.TrackerColor = System.Drawing.Color.Black;
            this.MtBVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.MtBVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.MtBVolumen.TrackLineHeight = 3;
            this.MtBVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.MtBVolumen.Value = 0;
            this.MtBVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.MtBVolumen_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCircular
            // 
            this.lbCircular.AutoSize = true;
            this.lbCircular.Location = new System.Drawing.Point(224, 296);
            this.lbCircular.Name = "lbCircular";
            this.lbCircular.Size = new System.Drawing.Size(86, 17);
            this.lbCircular.TabIndex = 12;
            this.lbCircular.Text = "Desactivado";
            this.lbCircular.Click += new System.EventHandler(this.lbCircular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(321, 420);
            this.Controls.Add(this.lbCircular);
            this.Controls.Add(this.MtBVolumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtBduracion);
            this.Controls.Add(this.LbCancion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PBsiguiente);
            this.Controls.Add(this.PBPlay);
            this.Controls.Add(this.PBanterior);
            this.Controls.Add(this.PBDelete);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.PBAgregar);
            this.Controls.Add(this.Reproductor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBsiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBanterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.PictureBox PBAgregar;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox PBDelete;
        private System.Windows.Forms.PictureBox PBanterior;
        private System.Windows.Forms.PictureBox PBPlay;
        private System.Windows.Forms.PictureBox PBsiguiente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbCancion;
        private XComponent.SliderBar.MACTrackBar MtBduracion;
        private System.Windows.Forms.Label label1;
        private XComponent.SliderBar.MACTrackBar MtBVolumen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbCircular;
    }
}

