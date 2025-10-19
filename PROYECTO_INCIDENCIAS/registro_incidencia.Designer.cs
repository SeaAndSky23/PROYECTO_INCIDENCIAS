namespace PROYECTO_INCIDENCIAS
{
    partial class registro_incidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro_incidencia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TipoIncidencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DescripcionProblema = new System.Windows.Forms.TextBox();
            this.tb_Ubicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnenviarep = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIBE TU PROBLEMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO DE INCIDENCIA";
            // 
            // cb_TipoIncidencia
            // 
            this.cb_TipoIncidencia.FormattingEnabled = true;
            this.cb_TipoIncidencia.Items.AddRange(new object[] {
            "Accidentes de tráfico (peatonales, vehiculares)",
            "Incendios (estructurales, naturales)",
            "Delitos (robos, hurtos, vandalismo, asaltos)",
            "Deficiencias en la vía pública (baches, aceras rotas, mobiliario urbano dañado)",
            "Problemas con servicios urbanos (alumbrado público, limpieza y gestión de residuo" +
                "s)",
            "Plagas sanitarias",
            "Averías en la red de agua o alcantarillado",
            "Problemas con el arbolado y jardinería (ramas caídas, riego, poda)",
            "Actividades de manifestación o disturbios",
            "Incidentes de bienestar animal"});
            this.cb_TipoIncidencia.Location = new System.Drawing.Point(232, 93);
            this.cb_TipoIncidencia.Name = "cb_TipoIncidencia";
            this.cb_TipoIncidencia.Size = new System.Drawing.Size(313, 21);
            this.cb_TipoIncidencia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCRIPCION DEL PROBLEMA";
            // 
            // tb_DescripcionProblema
            // 
            this.tb_DescripcionProblema.Location = new System.Drawing.Point(232, 157);
            this.tb_DescripcionProblema.Multiline = true;
            this.tb_DescripcionProblema.Name = "tb_DescripcionProblema";
            this.tb_DescripcionProblema.Size = new System.Drawing.Size(313, 69);
            this.tb_DescripcionProblema.TabIndex = 4;
            // 
            // tb_Ubicacion
            // 
            this.tb_Ubicacion.Location = new System.Drawing.Point(232, 268);
            this.tb_Ubicacion.Name = "tb_Ubicacion";
            this.tb_Ubicacion.Size = new System.Drawing.Size(313, 20);
            this.tb_Ubicacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "UBICACION (Distrito,direccion,referencia)";
            // 
            // btnenviarep
            // 
            this.btnenviarep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnenviarep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenviarep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviarep.Location = new System.Drawing.Point(305, 325);
            this.btnenviarep.Name = "btnenviarep";
            this.btnenviarep.Size = new System.Drawing.Size(75, 23);
            this.btnenviarep.TabIndex = 7;
            this.btnenviarep.Text = "ENVIAR";
            this.btnenviarep.UseVisualStyleBackColor = false;
            this.btnenviarep.Click += new System.EventHandler(this.btnenviarep_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(553, 354);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 8;
            this.btnvolver.Text = "VOLVER";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // registro_incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 389);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnenviarep);
            this.Controls.Add(this.tb_Ubicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_DescripcionProblema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_TipoIncidencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registro_incidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro_incidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TipoIncidencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_DescripcionProblema;
        private System.Windows.Forms.TextBox tb_Ubicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnenviarep;
        private System.Windows.Forms.Button btnvolver;
    }
}