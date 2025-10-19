namespace PROYECTO_INCIDENCIAS
{
    partial class inicio_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio_usuario));
            this.lblbienvenido = new System.Windows.Forms.Label();
            this.btnregistroincidencia = new System.Windows.Forms.Button();
            this.btnconsejos = new System.Windows.Forms.Button();
            this.btneducacion = new System.Windows.Forms.Button();
            this.btncerrarses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblbienvenido
            // 
            this.lblbienvenido.AutoSize = true;
            this.lblbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenido.Location = new System.Drawing.Point(31, 20);
            this.lblbienvenido.Name = "lblbienvenido";
            this.lblbienvenido.Size = new System.Drawing.Size(290, 20);
            this.lblbienvenido.TabIndex = 0;
            this.lblbienvenido.Text = "BIENVENIDO QUERIDO CIUDADANO";
            // 
            // btnregistroincidencia
            // 
            this.btnregistroincidencia.Location = new System.Drawing.Point(169, 110);
            this.btnregistroincidencia.Name = "btnregistroincidencia";
            this.btnregistroincidencia.Size = new System.Drawing.Size(161, 41);
            this.btnregistroincidencia.TabIndex = 1;
            this.btnregistroincidencia.Text = "REGISTRAR INCIDENCIA";
            this.btnregistroincidencia.UseVisualStyleBackColor = true;
            this.btnregistroincidencia.Click += new System.EventHandler(this.btnregistroincidencia_Click);
            // 
            // btnconsejos
            // 
            this.btnconsejos.Location = new System.Drawing.Point(169, 200);
            this.btnconsejos.Name = "btnconsejos";
            this.btnconsejos.Size = new System.Drawing.Size(161, 41);
            this.btnconsejos.TabIndex = 2;
            this.btnconsejos.Text = "CONSEJOS";
            this.btnconsejos.UseVisualStyleBackColor = true;
            // 
            // btneducacion
            // 
            this.btneducacion.Location = new System.Drawing.Point(169, 285);
            this.btneducacion.Name = "btneducacion";
            this.btneducacion.Size = new System.Drawing.Size(161, 41);
            this.btneducacion.TabIndex = 3;
            this.btneducacion.Text = "EDUCACION CIUDADANA";
            this.btneducacion.UseVisualStyleBackColor = true;
            // 
            // btncerrarses
            // 
            this.btncerrarses.Location = new System.Drawing.Point(169, 360);
            this.btncerrarses.Name = "btncerrarses";
            this.btncerrarses.Size = new System.Drawing.Size(161, 41);
            this.btncerrarses.TabIndex = 4;
            this.btncerrarses.Text = "CERRAR SESION";
            this.btncerrarses.UseVisualStyleBackColor = true;
            this.btncerrarses.Click += new System.EventHandler(this.btncerrarses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECCIONA QUE DESEAR REALIZAR";
            // 
            // inicio_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncerrarses);
            this.Controls.Add(this.btneducacion);
            this.Controls.Add(this.btnconsejos);
            this.Controls.Add(this.btnregistroincidencia);
            this.Controls.Add(this.lblbienvenido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inicio_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio_usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbienvenido;
        private System.Windows.Forms.Button btnregistroincidencia;
        private System.Windows.Forms.Button btnconsejos;
        private System.Windows.Forms.Button btneducacion;
        private System.Windows.Forms.Button btncerrarses;
        private System.Windows.Forms.Label label1;
    }
}