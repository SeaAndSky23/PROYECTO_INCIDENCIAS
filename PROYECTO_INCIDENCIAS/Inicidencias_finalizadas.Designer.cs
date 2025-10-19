namespace PROYECTO_INCIDENCIAS
{
    partial class Inicidencias_finalizadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicidencias_finalizadas));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsactualizar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsvolver = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tssalir = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsfinalizardia = new System.Windows.Forms.ToolStripLabel();
            this.dgvincifinalizadas = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvincifinalizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsactualizar,
            this.toolStripSeparator1,
            this.tsvolver,
            this.toolStripSeparator3,
            this.tssalir,
            this.toolStripSeparator2,
            this.tsfinalizardia});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsactualizar
            // 
            this.tsactualizar.Name = "tsactualizar";
            this.tsactualizar.Size = new System.Drawing.Size(76, 22);
            this.tsactualizar.Text = "ACTUALIZAR";
            this.tsactualizar.Click += new System.EventHandler(this.tsactualizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsvolver
            // 
            this.tsvolver.Name = "tsvolver";
            this.tsvolver.Size = new System.Drawing.Size(48, 22);
            this.tsvolver.Text = "VOLVER";
            this.tsvolver.Click += new System.EventHandler(this.tsvolver_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tssalir
            // 
            this.tssalir.Name = "tssalir";
            this.tssalir.Size = new System.Drawing.Size(37, 22);
            this.tssalir.Text = "SALIR";
            this.tssalir.Click += new System.EventHandler(this.tssalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsfinalizardia
            // 
            this.tsfinalizardia.Name = "tsfinalizardia";
            this.tsfinalizardia.Size = new System.Drawing.Size(86, 22);
            this.tsfinalizardia.Text = "FINALIZAR DIA";
            this.tsfinalizardia.Click += new System.EventHandler(this.tsfinalizardia_Click);
            // 
            // dgvincifinalizadas
            // 
            this.dgvincifinalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvincifinalizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.Usuario,
            this.Tipo,
            this.Descripcion,
            this.Ubicacion,
            this.FechaHora});
            this.dgvincifinalizadas.Location = new System.Drawing.Point(29, 88);
            this.dgvincifinalizadas.Name = "dgvincifinalizadas";
            this.dgvincifinalizadas.Size = new System.Drawing.Size(749, 300);
            this.dgvincifinalizadas.TabIndex = 3;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nº";
            this.Nro.Name = "Nro";
            this.Nro.Width = 80;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "USUARIO";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 110;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "DESCRIPCION";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "UBICACION";
            this.Ubicacion.Name = "Ubicacion";
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "FECHA Y HORA";
            this.FechaHora.Name = "FechaHora";
            // 
            // Inicidencias_finalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvincifinalizadas);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicidencias_finalizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicidencias_finalizadas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvincifinalizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsactualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsfinalizardia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsvolver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tssalir;
        private System.Windows.Forms.DataGridView dgvincifinalizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
    }
}