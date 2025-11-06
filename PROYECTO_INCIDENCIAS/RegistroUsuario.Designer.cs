using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_INCIDENCIAS
{
    partial class RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.TbDNI = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblVerificacion = new System.Windows.Forms.Label();
            this.tbVerificacion = new System.Windows.Forms.TextBox();
            this.tbcontra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolver3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblNombre.Location = new System.Drawing.Point(246, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(169, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombres Completos";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblDni.Location = new System.Drawing.Point(244, 245);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(41, 22);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(269, 126);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(403, 29);
            this.tbNombre.TabIndex = 2;
            // 
            // TbDNI
            // 
            this.TbDNI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDNI.Location = new System.Drawing.Point(267, 270);
            this.TbDNI.Name = "TbDNI";
            this.TbDNI.Size = new System.Drawing.Size(403, 29);
            this.TbDNI.TabIndex = 3;
            // 
            // btRegistrar
            // 
            this.btRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegistrar.FlatAppearance.BorderSize = 0;
            this.btRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrar.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.ForeColor = System.Drawing.Color.White;
            this.btRegistrar.Location = new System.Drawing.Point(426, 517);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(119, 38);
            this.btRegistrar.TabIndex = 4;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = false;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblTelefono.Location = new System.Drawing.Point(244, 403);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(97, 22);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "TELÉFONO";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbTelefono.Location = new System.Drawing.Point(267, 430);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(196, 29);
            this.tbTelefono.TabIndex = 6;
            // 
            // lblVerificacion
            // 
            this.lblVerificacion.AutoSize = true;
            this.lblVerificacion.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblVerificacion.Location = new System.Drawing.Point(500, 403);
            this.lblVerificacion.Name = "lblVerificacion";
            this.lblVerificacion.Size = new System.Drawing.Size(95, 22);
            this.lblVerificacion.TabIndex = 7;
            this.lblVerificacion.Text = "Verficación";
            // 
            // tbVerificacion
            // 
            this.tbVerificacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbVerificacion.Location = new System.Drawing.Point(528, 430);
            this.tbVerificacion.Name = "tbVerificacion";
            this.tbVerificacion.Size = new System.Drawing.Size(196, 29);
            this.tbVerificacion.TabIndex = 8;
            // 
            // tbcontra
            // 
            this.tbcontra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontra.Location = new System.Drawing.Point(265, 350);
            this.tbcontra.Name = "tbcontra";
            this.tbcontra.PasswordChar = '*';
            this.tbcontra.Size = new System.Drawing.Size(407, 29);
            this.tbcontra.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(242, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(242, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // tbusuario
            // 
            this.tbusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusuario.Location = new System.Drawing.Point(265, 196);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.ReadOnly = true;
            this.tbusuario.Size = new System.Drawing.Size(407, 29);
            this.tbusuario.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(363, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "JUNTOS TRUJILLO";
            // 
            // btnvolver3
            // 
            this.btnvolver3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver3.Image = ((System.Drawing.Image)(resources.GetObject("btnvolver3.Image")));
            this.btnvolver3.Location = new System.Drawing.Point(12, 12);
            this.btnvolver3.Name = "btnvolver3";
            this.btnvolver3.Size = new System.Drawing.Size(44, 50);
            this.btnvolver3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver3.TabIndex = 14;
            this.btnvolver3.TabStop = false;
            this.btnvolver3.Click += new System.EventHandler(this.btnvolver3_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.btnvolver3);
            this.Controls.Add(this.tbcontra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbVerificacion);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblVerificacion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.TbDNI);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lblTelefono);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private Label lblDni;
        private TextBox tbNombre;
        private TextBox TbDNI;
        private Button btRegistrar;
        private Label lblTelefono;
        private TextBox tbTelefono;
        private Label lblVerificacion;
        private TextBox tbVerificacion;
        private Label label1;
        private Label label2;
        private TextBox tbusuario;
        private TextBox tbcontra;
        private Label label3;
        private PictureBox btnvolver3;
    }
}