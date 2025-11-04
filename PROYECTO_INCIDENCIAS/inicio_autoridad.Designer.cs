namespace PROYECTO_INCIDENCIAS
{
    partial class inicio_autoridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio_autoridad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btadmuser = new System.Windows.Forms.PictureBox();
            this.dgvvisualincidencias = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsactualizar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsatender = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsvolver = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tssalir = new System.Windows.Forms.ToolStripLabel();
            this.btnreporproces = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btadmuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisualincidencias)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(275, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE MONITOREO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADMINISTRAR USUARIOS";
            // 
            // btadmuser
            // 
            this.btadmuser.Image = ((System.Drawing.Image)(resources.GetObject("btadmuser.Image")));
            this.btadmuser.Location = new System.Drawing.Point(2, 28);
            this.btadmuser.Name = "btadmuser";
            this.btadmuser.Size = new System.Drawing.Size(47, 50);
            this.btadmuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btadmuser.TabIndex = 3;
            this.btadmuser.TabStop = false;
            this.btadmuser.Click += new System.EventHandler(this.btadmuser_Click);
            // 
            // dgvvisualincidencias
            // 
            this.dgvvisualincidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvisualincidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.usuari,
            this.tipo,
            this.descrip,
            this.ubicac,
            this.fechahora});
            this.dgvvisualincidencias.Location = new System.Drawing.Point(52, 99);
            this.dgvvisualincidencias.Name = "dgvvisualincidencias";
            this.dgvvisualincidencias.Size = new System.Drawing.Size(713, 268);
            this.dgvvisualincidencias.TabIndex = 5;
            this.dgvvisualincidencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvisualincidencias_CellContentClick);
            // 
            // num
            // 
            this.num.HeaderText = "Nº";
            this.num.Name = "num";
            this.num.Width = 70;
            // 
            // usuari
            // 
            this.usuari.HeaderText = "USUARIO";
            this.usuari.Name = "usuari";
            this.usuari.Width = 120;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            // 
            // descrip
            // 
            this.descrip.HeaderText = "DESCRIPCION";
            this.descrip.Name = "descrip";
            this.descrip.Width = 180;
            // 
            // ubicac
            // 
            this.ubicac.HeaderText = "UBICACION";
            this.ubicac.Name = "ubicac";
            // 
            // fechahora
            // 
            this.fechahora.HeaderText = "FECHA Y HORA";
            this.fechahora.Name = "fechahora";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsactualizar,
            this.toolStripSeparator1,
            this.tsatender,
            this.toolStripSeparator2,
            this.tsvolver,
            this.toolStripSeparator3,
            this.tssalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
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
            // tsatender
            // 
            this.tsatender.Name = "tsatender";
            this.tsatender.Size = new System.Drawing.Size(56, 22);
            this.tsatender.Text = "ATENDER";
            this.tsatender.Click += new System.EventHandler(this.tsatender_Click);
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
            // btnreporproces
            // 
            this.btnreporproces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnreporproces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreporproces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporproces.ForeColor = System.Drawing.Color.White;
            this.btnreporproces.Location = new System.Drawing.Point(638, 398);
            this.btnreporproces.Name = "btnreporproces";
            this.btnreporproces.Size = new System.Drawing.Size(150, 40);
            this.btnreporproces.TabIndex = 7;
            this.btnreporproces.Text = "VISUALIZAR REPORTES EN PROCESO";
            this.btnreporproces.UseVisualStyleBackColor = false;
            this.btnreporproces.Click += new System.EventHandler(this.btnreporproces_Click);
            // 
            // inicio_autoridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreporproces);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvvisualincidencias);
            this.Controls.Add(this.btadmuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inicio_autoridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio_autoridad";
            this.Load += new System.EventHandler(this.inicio_autoridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btadmuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisualincidencias)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btadmuser;
        private System.Windows.Forms.DataGridView dgvvisualincidencias;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsactualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsatender;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tssalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsvolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuari;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicac;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahora;
        private System.Windows.Forms.Button btnreporproces;
    }
}