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
            this.RIESGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvincidenciasproceso)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.FechaHora,
            this.RIESGO});
            this.dgvincidenciasproceso.Location = new System.Drawing.Point(16, 42);
            this.dgvincidenciasproceso.Name = "dgvincidenciasproceso";
            this.dgvincidenciasproceso.Size = new System.Drawing.Size(832, 300);
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
            this.toolStrip1.Size = new System.Drawing.Size(855, 25);
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
            this.btnvisreportfinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnvisreportfinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvisreportfinal.FlatAppearance.BorderSize = 0;
            this.btnvisreportfinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvisreportfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisreportfinal.ForeColor = System.Drawing.Color.White;
            this.btnvisreportfinal.Location = new System.Drawing.Point(704, 453);
            this.btnvisreportfinal.Name = "btnvisreportfinal";
            this.btnvisreportfinal.Size = new System.Drawing.Size(144, 47);
            this.btnvisreportfinal.TabIndex = 2;
            this.btnvisreportfinal.Text = "VISUALIZAR REPORTES FINALIZADOS";
            this.btnvisreportfinal.UseVisualStyleBackColor = false;
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
            this.lblMensajes.Location = new System.Drawing.Point(100, 108);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(0, 21);
            this.lblMensajes.TabIndex = 4;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nº";
            this.Nro.Name = "Nro";
            this.Nro.Width = 50;
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
            // RIESGO
            // 
            this.RIESGO.HeaderText = "RIESGO";
            this.RIESGO.Name = "RIESGO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(26, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "URGENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MEDIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(106, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "BAJO";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Lime;
            this.pictureBox3.Location = new System.Drawing.Point(25, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(67, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "NO ESPECIFICADO";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(106, 91);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "NIVEL DE RIESGO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMensajes);
            this.panel1.Location = new System.Drawing.Point(16, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 141);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // v_insidencias_proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RIESGO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}