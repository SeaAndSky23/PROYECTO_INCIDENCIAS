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
            this.dgv_ListaAtendiendose = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RIESGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aCTUALIZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINALIZARCASOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARCASOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vOLVERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMPRIMIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESDELDIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcontador_medio = new System.Windows.Forms.Label();
            this.lblcontador_urgente = new System.Windows.Forms.Label();
            this.lblcontador_final = new System.Windows.Forms.Label();
            this.lblcontador_elininados = new System.Windows.Forms.Label();
            this.lblcontador_noespec = new System.Windows.Forms.Label();
            this.lblcontador_bajo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaAtendiendose)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ListaAtendiendose
            // 
            this.dgv_ListaAtendiendose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaAtendiendose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.Usuario,
            this.Tipo,
            this.Descripcion,
            this.Ubicacion,
            this.FechaHora,
            this.RIESGO});
            this.dgv_ListaAtendiendose.Location = new System.Drawing.Point(12, 106);
            this.dgv_ListaAtendiendose.Name = "dgv_ListaAtendiendose";
            this.dgv_ListaAtendiendose.Size = new System.Drawing.Size(940, 434);
            this.dgv_ListaAtendiendose.TabIndex = 0;
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
            this.Usuario.Width = 120;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "TIPO";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 130;
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
            this.Ubicacion.Width = 150;
            // 
            // FechaHora
            // 
            this.FechaHora.HeaderText = "FECHA Y HORA";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.Width = 120;
            // 
            // RIESGO
            // 
            this.RIESGO.HeaderText = "RIESGO";
            this.RIESGO.Name = "RIESGO";
            this.RIESGO.Width = 130;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTUALIZARToolStripMenuItem,
            this.aCCIONESToolStripMenuItem,
            this.vOLVERToolStripMenuItem,
            this.iMPRIMIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aCTUALIZARToolStripMenuItem
            // 
            this.aCTUALIZARToolStripMenuItem.Name = "aCTUALIZARToolStripMenuItem";
            this.aCTUALIZARToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.aCTUALIZARToolStripMenuItem.Text = "ACTUALIZAR";
            this.aCTUALIZARToolStripMenuItem.Click += new System.EventHandler(this.aCTUALIZARToolStripMenuItem_Click);
            // 
            // aCCIONESToolStripMenuItem
            // 
            this.aCCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fINALIZARCASOToolStripMenuItem,
            this.eLIMINARCASOToolStripMenuItem});
            this.aCCIONESToolStripMenuItem.Name = "aCCIONESToolStripMenuItem";
            this.aCCIONESToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.aCCIONESToolStripMenuItem.Text = "ACCIONES";
            // 
            // fINALIZARCASOToolStripMenuItem
            // 
            this.fINALIZARCASOToolStripMenuItem.Name = "fINALIZARCASOToolStripMenuItem";
            this.fINALIZARCASOToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fINALIZARCASOToolStripMenuItem.Text = "FINALIZAR CASO";
            this.fINALIZARCASOToolStripMenuItem.Click += new System.EventHandler(this.fINALIZARCASOToolStripMenuItem_Click);
            // 
            // eLIMINARCASOToolStripMenuItem
            // 
            this.eLIMINARCASOToolStripMenuItem.Name = "eLIMINARCASOToolStripMenuItem";
            this.eLIMINARCASOToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.eLIMINARCASOToolStripMenuItem.Text = "ELIMINAR CASO";
            this.eLIMINARCASOToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARCASOToolStripMenuItem_Click);
            // 
            // vOLVERToolStripMenuItem
            // 
            this.vOLVERToolStripMenuItem.Name = "vOLVERToolStripMenuItem";
            this.vOLVERToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vOLVERToolStripMenuItem.Text = "VOLVER";
            this.vOLVERToolStripMenuItem.Click += new System.EventHandler(this.vOLVERToolStripMenuItem_Click);
            // 
            // iMPRIMIRToolStripMenuItem
            // 
            this.iMPRIMIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eLIMINADOSToolStripMenuItem,
            this.rEPORTESDELDIAToolStripMenuItem});
            this.iMPRIMIRToolStripMenuItem.Name = "iMPRIMIRToolStripMenuItem";
            this.iMPRIMIRToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.iMPRIMIRToolStripMenuItem.Text = "IMPRIMIR";
            // 
            // eLIMINADOSToolStripMenuItem
            // 
            this.eLIMINADOSToolStripMenuItem.Name = "eLIMINADOSToolStripMenuItem";
            this.eLIMINADOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eLIMINADOSToolStripMenuItem.Text = "ELIMINADOS";
            this.eLIMINADOSToolStripMenuItem.Click += new System.EventHandler(this.eLIMINADOSToolStripMenuItem_Click);
            // 
            // rEPORTESDELDIAToolStripMenuItem
            // 
            this.rEPORTESDELDIAToolStripMenuItem.Name = "rEPORTESDELDIAToolStripMenuItem";
            this.rEPORTESDELDIAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rEPORTESDELDIAToolStripMenuItem.Text = "REPORTES DEL DIA";
            this.rEPORTESDELDIAToolStripMenuItem.Click += new System.EventHandler(this.rEPORTESDELDIAToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.label2.Location = new System.Drawing.Point(363, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "REPORTES EN PROCESO\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "TOTAL DE CASOS FINALIZADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "TOTAL DE CASOS URGENTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 649);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "TOTAL DE CASOS SIN ESPECIFICAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "TOTAL DE CASOS RIESGO \"BAJO\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "TOTAL DE CASOS RIESGO \"MEDIO\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 607);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "TOTAL DE CASOS ELIMINADOS";
            // 
            // lblcontador_medio
            // 
            this.lblcontador_medio.AutoSize = true;
            this.lblcontador_medio.BackColor = System.Drawing.Color.Gold;
            this.lblcontador_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador_medio.Location = new System.Drawing.Point(796, 596);
            this.lblcontador_medio.Name = "lblcontador_medio";
            this.lblcontador_medio.Size = new System.Drawing.Size(14, 20);
            this.lblcontador_medio.TabIndex = 27;
            this.lblcontador_medio.Text = "-";
            // 
            // lblcontador_urgente
            // 
            this.lblcontador_urgente.AutoSize = true;
            this.lblcontador_urgente.BackColor = System.Drawing.Color.Red;
            this.lblcontador_urgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador_urgente.Location = new System.Drawing.Point(796, 572);
            this.lblcontador_urgente.Name = "lblcontador_urgente";
            this.lblcontador_urgente.Size = new System.Drawing.Size(14, 20);
            this.lblcontador_urgente.TabIndex = 26;
            this.lblcontador_urgente.Text = "-";
            // 
            // lblcontador_final
            // 
            this.lblcontador_final.AutoSize = true;
            this.lblcontador_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador_final.Location = new System.Drawing.Point(365, 575);
            this.lblcontador_final.Name = "lblcontador_final";
            this.lblcontador_final.Size = new System.Drawing.Size(15, 20);
            this.lblcontador_final.TabIndex = 25;
            this.lblcontador_final.Text = "-";
            // 
            // lblcontador_elininados
            // 
            this.lblcontador_elininados.AutoSize = true;
            this.lblcontador_elininados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador_elininados.Location = new System.Drawing.Point(365, 607);
            this.lblcontador_elininados.Name = "lblcontador_elininados";
            this.lblcontador_elininados.Size = new System.Drawing.Size(15, 20);
            this.lblcontador_elininados.TabIndex = 30;
            this.lblcontador_elininados.Text = "-";
            // 
            // lblcontador_noespec
            // 
            this.lblcontador_noespec.AutoSize = true;
            this.lblcontador_noespec.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblcontador_noespec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador_noespec.Location = new System.Drawing.Point(796, 649);
            this.lblcontador_noespec.Name = "lblcontador_noespec";
            this.lblcontador_noespec.Size = new System.Drawing.Size(14, 20);
            this.lblcontador_noespec.TabIndex = 29;
            this.lblcontador_noespec.Text = "-";
            // 
            // lblcontador_bajo
            // 
            this.lblcontador_bajo.AutoSize = true;
            this.lblcontador_bajo.BackColor = System.Drawing.Color.LimeGreen;
            this.lblcontador_bajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador_bajo.Location = new System.Drawing.Point(796, 622);
            this.lblcontador_bajo.Name = "lblcontador_bajo";
            this.lblcontador_bajo.Size = new System.Drawing.Size(14, 20);
            this.lblcontador_bajo.TabIndex = 28;
            this.lblcontador_bajo.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // v_insidencias_proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(964, 727);
            this.Controls.Add(this.lblcontador_elininados);
            this.Controls.Add(this.lblcontador_noespec);
            this.Controls.Add(this.lblcontador_bajo);
            this.Controls.Add(this.lblcontador_medio);
            this.Controls.Add(this.lblcontador_urgente);
            this.Controls.Add(this.lblcontador_final);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_ListaAtendiendose);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "v_insidencias_proceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIONAR REPORTES";
            this.Load += new System.EventHandler(this.v_insidencias_proceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaAtendiendose)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListaAtendiendose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aCTUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vOLVERToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcontador_medio;
        private System.Windows.Forms.Label lblcontador_urgente;
        private System.Windows.Forms.Label lblcontador_final;
        private System.Windows.Forms.Label lblcontador_elininados;
        private System.Windows.Forms.Label lblcontador_noespec;
        private System.Windows.Forms.Label lblcontador_bajo;
        private System.Windows.Forms.ToolStripMenuItem fINALIZARCASOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARCASOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMPRIMIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESDELDIAToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn RIESGO;
    }
}