namespace PROYECTO_INCIDENCIAS
{
    partial class visualizar_estado_reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visualizar_estado_reporte));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_estado_reporte = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnact = new System.Windows.Forms.PictureBox();
            this.btnvolver2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estado_reporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 17.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(311, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTADO DE REPORTES";
            // 
            // dgv_estado_reporte
            // 
            this.dgv_estado_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estado_reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nombre,
            this.tipo,
            this.descripcion,
            this.fecha,
            this.estado});
            this.dgv_estado_reporte.Location = new System.Drawing.Point(12, 88);
            this.dgv_estado_reporte.Name = "dgv_estado_reporte";
            this.dgv_estado_reporte.Size = new System.Drawing.Size(905, 441);
            this.dgv_estado_reporte.TabIndex = 1;
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.Name = "numero";
            this.numero.Width = 70;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.Width = 140;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.Width = 130;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 220;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.Width = 150;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.Width = 140;
            // 
            // btnact
            // 
            this.btnact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnact.Image = ((System.Drawing.Image)(resources.GetObject("btnact.Image")));
            this.btnact.Location = new System.Drawing.Point(21, 20);
            this.btnact.Name = "btnact";
            this.btnact.Size = new System.Drawing.Size(42, 35);
            this.btnact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnact.TabIndex = 2;
            this.btnact.TabStop = false;
            this.btnact.Click += new System.EventHandler(this.btnact_Click);
            // 
            // btnvolver2
            // 
            this.btnvolver2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver2.Image = ((System.Drawing.Image)(resources.GetObject("btnvolver2.Image")));
            this.btnvolver2.Location = new System.Drawing.Point(873, 12);
            this.btnvolver2.Name = "btnvolver2";
            this.btnvolver2.Size = new System.Drawing.Size(44, 50);
            this.btnvolver2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver2.TabIndex = 13;
            this.btnvolver2.TabStop = false;
            this.btnvolver2.Click += new System.EventHandler(this.btnvolver2_Click);
            // 
            // visualizar_estado_reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 571);
            this.Controls.Add(this.btnvolver2);
            this.Controls.Add(this.btnact);
            this.Controls.Add(this.dgv_estado_reporte);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "visualizar_estado_reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "visualizar_estado_reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estado_reporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_estado_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.PictureBox btnact;
        private System.Windows.Forms.PictureBox btnvolver2;
    }
}