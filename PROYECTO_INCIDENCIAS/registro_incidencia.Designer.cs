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
            this.btnenviarep = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbdistrito = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_comentarios = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(253, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIBE TU PROBLEMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO DE INCIDENCIA";
            // 
            // cb_TipoIncidencia
            // 
            this.cb_TipoIncidencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_TipoIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cb_TipoIncidencia.Location = new System.Drawing.Point(414, 162);
            this.cb_TipoIncidencia.Name = "cb_TipoIncidencia";
            this.cb_TipoIncidencia.Size = new System.Drawing.Size(401, 26);
            this.cb_TipoIncidencia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCRIPCION DEL PROBLEMA";
            // 
            // tb_DescripcionProblema
            // 
            this.tb_DescripcionProblema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_DescripcionProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DescripcionProblema.Location = new System.Drawing.Point(414, 230);
            this.tb_DescripcionProblema.Multiline = true;
            this.tb_DescripcionProblema.Name = "tb_DescripcionProblema";
            this.tb_DescripcionProblema.Size = new System.Drawing.Size(401, 69);
            this.tb_DescripcionProblema.TabIndex = 4;
            // 
            // tb_Ubicacion
            // 
            this.tb_Ubicacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ubicacion.Location = new System.Drawing.Point(414, 395);
            this.tb_Ubicacion.Name = "tb_Ubicacion";
            this.tb_Ubicacion.Size = new System.Drawing.Size(401, 26);
            this.tb_Ubicacion.TabIndex = 6;
            // 
            // btnenviarep
            // 
            this.btnenviarep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnenviarep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenviarep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviarep.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviarep.ForeColor = System.Drawing.Color.White;
            this.btnenviarep.Location = new System.Drawing.Point(357, 602);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "DISTRITO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "DIRECCION, REFERENCIA";
            // 
            // cbdistrito
            // 
            this.cbdistrito.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbdistrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbdistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbdistrito.Location = new System.Drawing.Point(111, 400);
            this.cbdistrito.Name = "cbdistrito";
            this.cbdistrito.Size = new System.Drawing.Size(230, 24);
            this.cbdistrito.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "UBICACION ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "AGREGAR COMENTARIOS";
            // 
            // tb_comentarios
            // 
            this.tb_comentarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_comentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comentarios.Location = new System.Drawing.Point(414, 462);
            this.tb_comentarios.Multiline = true;
            this.tb_comentarios.Name = "tb_comentarios";
            this.tb_comentarios.Size = new System.Drawing.Size(401, 69);
            this.tb_comentarios.TabIndex = 14;
            // 
            // registro_incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 727);
            this.Controls.Add(this.tb_comentarios);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Button btnenviarep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbdistrito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_comentarios;
    }
}