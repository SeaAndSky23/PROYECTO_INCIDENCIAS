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
            this.components = new System.ComponentModel.Container();
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
            this.riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vISUALIZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNORDENDELLEGADAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOLOURGENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOLOMEDIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOLOBAJOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOLODESCONOCIDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTENDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERREPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vOLVERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btadmuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisualincidencias)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(332, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE MONITOREO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADMINISTRAR USUARIOS";
            // 
            // btadmuser
            // 
            this.btadmuser.Image = ((System.Drawing.Image)(resources.GetObject("btadmuser.Image")));
            this.btadmuser.Location = new System.Drawing.Point(12, 32);
            this.btadmuser.Name = "btadmuser";
            this.btadmuser.Size = new System.Drawing.Size(40, 35);
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
            this.fechahora,
            this.riesgo});
            this.dgvvisualincidencias.Location = new System.Drawing.Point(12, 88);
            this.dgvvisualincidencias.Name = "dgvvisualincidencias";
            this.dgvvisualincidencias.Size = new System.Drawing.Size(905, 372);
            this.dgvvisualincidencias.TabIndex = 5;
            this.dgvvisualincidencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvisualincidencias_CellContentClick);
            // 
            // num
            // 
            this.num.HeaderText = "Nº";
            this.num.Name = "num";
            this.num.Width = 50;
            // 
            // usuari
            // 
            this.usuari.HeaderText = "USUARIO";
            this.usuari.Name = "usuari";
            this.usuari.Width = 140;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.Width = 140;
            // 
            // descrip
            // 
            this.descrip.HeaderText = "DESCRIPCION";
            this.descrip.Name = "descrip";
            this.descrip.Width = 170;
            // 
            // ubicac
            // 
            this.ubicac.HeaderText = "UBICACION";
            this.ubicac.Name = "ubicac";
            this.ubicac.Width = 140;
            // 
            // fechahora
            // 
            this.fechahora.HeaderText = "FECHA Y HORA";
            this.fechahora.Name = "fechahora";
            this.fechahora.Width = 120;
            // 
            // riesgo
            // 
            this.riesgo.HeaderText = "RIESGO";
            this.riesgo.Name = "riesgo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "TOTAL CASOS RECIBIDOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LimeGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DodgerBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(709, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vISUALIZARToolStripMenuItem,
            this.aTENDERToolStripMenuItem,
            this.vERREPORTESToolStripMenuItem,
            this.vOLVERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vISUALIZARToolStripMenuItem
            // 
            this.vISUALIZARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.eNORDENDELLEGADAToolStripMenuItem,
            this.sOLOURGENTEToolStripMenuItem,
            this.sOLOMEDIOToolStripMenuItem,
            this.sOLOBAJOToolStripMenuItem,
            this.sOLODESCONOCIDOToolStripMenuItem});
            this.vISUALIZARToolStripMenuItem.Name = "vISUALIZARToolStripMenuItem";
            this.vISUALIZARToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.vISUALIZARToolStripMenuItem.Text = "VISUALIZAR";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.aToolStripMenuItem.Text = "POR PRIORIDAD";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // eNORDENDELLEGADAToolStripMenuItem
            // 
            this.eNORDENDELLEGADAToolStripMenuItem.Name = "eNORDENDELLEGADAToolStripMenuItem";
            this.eNORDENDELLEGADAToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.eNORDENDELLEGADAToolStripMenuItem.Text = "EN ORDEN DE LLEGADA";
            this.eNORDENDELLEGADAToolStripMenuItem.Click += new System.EventHandler(this.eNORDENDELLEGADAToolStripMenuItem_Click);
            // 
            // sOLOURGENTEToolStripMenuItem
            // 
            this.sOLOURGENTEToolStripMenuItem.Name = "sOLOURGENTEToolStripMenuItem";
            this.sOLOURGENTEToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sOLOURGENTEToolStripMenuItem.Text = "SOLO \"URGENTE\"";
            this.sOLOURGENTEToolStripMenuItem.Click += new System.EventHandler(this.sOLOURGENTEToolStripMenuItem_Click);
            // 
            // sOLOMEDIOToolStripMenuItem
            // 
            this.sOLOMEDIOToolStripMenuItem.Name = "sOLOMEDIOToolStripMenuItem";
            this.sOLOMEDIOToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sOLOMEDIOToolStripMenuItem.Text = "SOLO \"MEDIO\"";
            this.sOLOMEDIOToolStripMenuItem.Click += new System.EventHandler(this.sOLOMEDIOToolStripMenuItem_Click);
            // 
            // sOLOBAJOToolStripMenuItem
            // 
            this.sOLOBAJOToolStripMenuItem.Name = "sOLOBAJOToolStripMenuItem";
            this.sOLOBAJOToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sOLOBAJOToolStripMenuItem.Text = "SOLO \"BAJO\"";
            this.sOLOBAJOToolStripMenuItem.Click += new System.EventHandler(this.sOLOBAJOToolStripMenuItem_Click);
            // 
            // sOLODESCONOCIDOToolStripMenuItem
            // 
            this.sOLODESCONOCIDOToolStripMenuItem.Name = "sOLODESCONOCIDOToolStripMenuItem";
            this.sOLODESCONOCIDOToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sOLODESCONOCIDOToolStripMenuItem.Text = "NO ESPECIFICADO";
            this.sOLODESCONOCIDOToolStripMenuItem.Click += new System.EventHandler(this.sOLODESCONOCIDOToolStripMenuItem_Click);
            // 
            // aTENDERToolStripMenuItem
            // 
            this.aTENDERToolStripMenuItem.Name = "aTENDERToolStripMenuItem";
            this.aTENDERToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aTENDERToolStripMenuItem.Text = "ATENDER";
            this.aTENDERToolStripMenuItem.Click += new System.EventHandler(this.aTENDERToolStripMenuItem_Click);
            // 
            // vERREPORTESToolStripMenuItem
            // 
            this.vERREPORTESToolStripMenuItem.Name = "vERREPORTESToolStripMenuItem";
            this.vERREPORTESToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.vERREPORTESToolStripMenuItem.Text = "VER REPORTES EN PROCESO";
            this.vERREPORTESToolStripMenuItem.Click += new System.EventHandler(this.vERREPORTESToolStripMenuItem_Click);
            // 
            // vOLVERToolStripMenuItem
            // 
            this.vOLVERToolStripMenuItem.Name = "vOLVERToolStripMenuItem";
            this.vOLVERToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vOLVERToolStripMenuItem.Text = "VOLVER";
            this.vOLVERToolStripMenuItem.Click += new System.EventHandler(this.vOLVERToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "URGENTE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "MEDIO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "BAJO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(691, 549);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "A EVALUACION";
            // 
            // inicio_autoridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 571);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvvisualincidencias);
            this.Controls.Add(this.btadmuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "inicio_autoridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio_autoridad";
            this.Load += new System.EventHandler(this.inicio_autoridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btadmuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisualincidencias)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btadmuser;
        private System.Windows.Forms.DataGridView dgvvisualincidencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuari;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicac;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahora;
        private System.Windows.Forms.DataGridViewTextBoxColumn riesgo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vISUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNORDENDELLEGADAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOLOURGENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOLOMEDIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOLOBAJOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOLODESCONOCIDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTENDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERREPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vOLVERToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}