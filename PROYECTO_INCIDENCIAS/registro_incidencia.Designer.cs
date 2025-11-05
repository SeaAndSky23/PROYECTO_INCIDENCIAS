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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbdistrito = new System.Windows.Forms.ComboBox();
            this.btnvolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(301, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIBE TU PROBLEMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO DE INCIDENCIA";
            // 
            // cb_TipoIncidencia
            // 
            this.cb_TipoIncidencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_TipoIncidencia.FormattingEnabled = true;
            this.cb_TipoIncidencia.Items.AddRange(new object[] {
            "ACCIDENTES DE TRÁFICO (PEATONALES, VEHICULARES)",
            "INCENDIOS (ESTRUCTURALES, NATURALES)",
            "DELITOS (ROBOS, HURTOS, VANDALISMO, ASALTOS)",
            "ACTIVIDADES DE MANIFESTACIÓN O DISTURBIOS",
            "DEFICIENCIAS EN LA VÍA PÚBLICA (BACHES, ACERAS ROTAS, MOBILIARIO URBANO DAÑADO)",
            "AVERÍAS EN LA RED DE AGUA O ALCANTARILLADO",
            "INCIDENTES DE BIENESTAR ANIMAL",
            "PROBLEMAS CON SERVICIOS URBANOS (ALUMBRADO PÚBLICO, LIMPIEZA Y GESTIÓN DE RESIDUO" +
                "S)",
            "PLAGAS SANITARIAS",
            "PROBLEMAS CON EL ARBOLADO Y JARDINERÍA (RAMAS CAÍDAS, RIEGO, PODA)"});
            this.cb_TipoIncidencia.Location = new System.Drawing.Point(357, 124);
            this.cb_TipoIncidencia.Name = "cb_TipoIncidencia";
            this.cb_TipoIncidencia.Size = new System.Drawing.Size(349, 21);
            this.cb_TipoIncidencia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCRIPCION DEL PROBLEMA";
            // 
            // tb_DescripcionProblema
            // 
            this.tb_DescripcionProblema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_DescripcionProblema.Location = new System.Drawing.Point(357, 189);
            this.tb_DescripcionProblema.Multiline = true;
            this.tb_DescripcionProblema.Name = "tb_DescripcionProblema";
            this.tb_DescripcionProblema.Size = new System.Drawing.Size(349, 69);
            this.tb_DescripcionProblema.TabIndex = 4;
            // 
            // tb_Ubicacion
            // 
            this.tb_Ubicacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Ubicacion.Location = new System.Drawing.Point(393, 360);
            this.tb_Ubicacion.Name = "tb_Ubicacion";
            this.tb_Ubicacion.Size = new System.Drawing.Size(313, 20);
            this.tb_Ubicacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "UBICACION ";
            // 
            // btnenviarep
            // 
            this.btnenviarep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnenviarep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenviarep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviarep.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviarep.ForeColor = System.Drawing.Color.White;
            this.btnenviarep.Location = new System.Drawing.Point(382, 452);
            this.btnenviarep.Name = "btnenviarep";
            this.btnenviarep.Size = new System.Drawing.Size(95, 35);
            this.btnenviarep.TabIndex = 7;
            this.btnenviarep.Text = "ENVIAR";
            this.btnenviarep.UseVisualStyleBackColor = false;
            this.btnenviarep.Click += new System.EventHandler(this.btnenviarep_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "DISTRITO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "DIRECCION, REFERENCIA";
            // 
            // cbdistrito
            // 
            this.cbdistrito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbdistrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbdistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdistrito.FormattingEnabled = true;
            this.cbdistrito.Items.AddRange(new object[] {
            "TRUJILLO",
            "EL PORVENIR",
            "FLORENCIA DE MORA",
            "HUANCHACO",
            "LA ESPERANZA",
            "LAREDO",
            "MOCHE",
            "POROTO",
            "SALAVERRY",
            "SIMBAL",
            "VÍCTOR LARCO"});
            this.cbdistrito.Location = new System.Drawing.Point(123, 359);
            this.cbdistrito.Name = "cbdistrito";
            this.cbdistrito.Size = new System.Drawing.Size(191, 21);
            this.cbdistrito.TabIndex = 11;
            // 
            // btnvolver
            // 
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.Image = ((System.Drawing.Image)(resources.GetObject("btnvolver.Image")));
            this.btnvolver.Location = new System.Drawing.Point(12, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(44, 50);
            this.btnvolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver.TabIndex = 12;
            this.btnvolver.TabStop = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click_1);
            // 
            // registro_incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 539);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.cbdistrito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbdistrito;
        private System.Windows.Forms.PictureBox btnvolver;
    }
}