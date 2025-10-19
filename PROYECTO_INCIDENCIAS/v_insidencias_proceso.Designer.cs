using System.Drawing;

namespace PROYECTO_INCIDENCIAS
{
    partial class v_insidencias_proceso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_insidencias_proceso));
            this.dgvincidenciasproceso = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsactualizar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsfinalizarcaso = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsvolver = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tssalir = new System.Windows.Forms.ToolStripLabel();
            this.btnvisreportfinal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMensajes = new System.Windows.Forms.Label();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvincidenciasproceso)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvincidenciasproceso
            // 
            this.dgvincidenciasproceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvincidenciasproceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.Usuario,
            this.Tipo,
            this.Descripcion,
            this.Ubicacion,
            this.FechaHora});
            this.dgvincidenciasproceso.Location = new System.Drawing.Point(12, 75);
            this.dgvincidenciasproceso.Name = "dgvincidenciasproceso";
            this.dgvincidenciasproceso.Size = new System.Drawing.Size(763, 271);
            this.dgvincidenciasproceso.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsactualizar,
            this.toolStripSeparator1,
            this.tsfinalizarcaso,
            this.toolStripSeparator2,
            this.tsvolver,
            this.toolStripSeparator3,
            this.tssalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
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
            // tsfinalizarcaso
            // 
            this.tsfinalizarcaso.Name = "tsfinalizarcaso";
            this.tsfinalizarcaso.Size = new System.Drawing.Size(98, 22);
            this.tsfinalizarcaso.Text = "FINALIZAR CASO";
            this.tsfinalizarcaso.Click += new System.EventHandler(this.tsfinalizarcaso_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // btnvisreportfinal
            // 
            this.btnvisreportfinal.Location = new System.Drawing.Point(644, 391);
            this.btnvisreportfinal.Name = "btnvisreportfinal";
            this.btnvisreportfinal.Size = new System.Drawing.Size(144, 47);
            this.btnvisreportfinal.TabIndex = 2;
            this.btnvisreportfinal.Text = "VISUALIZAR REPORTES FINALIZADOS";
            this.btnvisreportfinal.UseVisualStyleBackColor = true;
            this.btnvisreportfinal.Click += new System.EventHandler(this.btnvisreportfinal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMensajes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMensajes.Location = new System.Drawing.Point(114, 453);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(0, 21);
            this.lblMensajes.TabIndex = 4;
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
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 140;
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
            // v_insidencias_proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.btnvisreportfinal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvincidenciasproceso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "v_insidencias_proceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v_insidencias_proceso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvincidenciasproceso)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvincidenciasproceso;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsactualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsfinalizarcaso;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsvolver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tssalir;
        private System.Windows.Forms.Button btnvisreportfinal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
    }
}