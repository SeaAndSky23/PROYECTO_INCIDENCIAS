using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_INCIDENCIAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.iscrearcuenta = new System.Windows.Forms.Label();
            this.isbtningresar = new System.Windows.Forms.Button();
            this.iscontrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iscrearcuenta);
            this.panel1.Controls.Add(this.isbtningresar);
            this.panel1.Controls.Add(this.iscontrase);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.isusuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(231, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 437);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "JUNTOS TRUJILLO";
            // 
            // iscrearcuenta
            // 
            this.iscrearcuenta.AutoSize = true;
            this.iscrearcuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iscrearcuenta.Font = new System.Drawing.Font("Segoe UI", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.iscrearcuenta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.iscrearcuenta.Location = new System.Drawing.Point(134, 404);
            this.iscrearcuenta.Name = "iscrearcuenta";
            this.iscrearcuenta.Size = new System.Drawing.Size(78, 12);
            this.iscrearcuenta.TabIndex = 7;
            this.iscrearcuenta.Text = "CREAR CUENTA";
            this.iscrearcuenta.Click += new System.EventHandler(this.iscrearcuenta_Click);
            // 
            // isbtningresar
            // 
            this.isbtningresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.isbtningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isbtningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isbtningresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.isbtningresar.ForeColor = System.Drawing.Color.White;
            this.isbtningresar.Location = new System.Drawing.Point(136, 358);
            this.isbtningresar.Name = "isbtningresar";
            this.isbtningresar.Size = new System.Drawing.Size(76, 27);
            this.isbtningresar.TabIndex = 6;
            this.isbtningresar.Text = "INGRESAR";
            this.isbtningresar.UseVisualStyleBackColor = false;
            this.isbtningresar.Click += new System.EventHandler(this.isbtningresar_Click);
            // 
            // iscontrase
            // 
            this.iscontrase.Location = new System.Drawing.Point(93, 320);
            this.iscontrase.Name = "iscontrase";
            this.iscontrase.PasswordChar = '*';
            this.iscontrase.Size = new System.Drawing.Size(171, 20);
            this.iscontrase.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTRASEÑA";
            // 
            // isusuario
            // 
            this.isusuario.Location = new System.Drawing.Point(93, 264);
            this.isusuario.Name = "isusuario";
            this.isusuario.Size = new System.Drawing.Size(171, 20);
            this.isusuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "USUARIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO SESION";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox iscontrase;
        private Label label3;
        private TextBox isusuario;
        private Label label2;
        private Label iscrearcuenta;
        private Button isbtningresar;
        private Label label4;
    }
}

