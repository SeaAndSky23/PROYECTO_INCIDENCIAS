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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iscrearcuenta = new System.Windows.Forms.Label();
            this.isbtningresar = new System.Windows.Forms.Button();
            this.iscontrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(333, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "JUNTOS TRUJILLO";
            // 
            // iscrearcuenta
            // 
            this.iscrearcuenta.AutoSize = true;
            this.iscrearcuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iscrearcuenta.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.iscrearcuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.iscrearcuenta.Location = new System.Drawing.Point(414, 481);
            this.iscrearcuenta.Name = "iscrearcuenta";
            this.iscrearcuenta.Size = new System.Drawing.Size(88, 13);
            this.iscrearcuenta.TabIndex = 7;
            this.iscrearcuenta.Text = "CREAR CUENTA";
            this.iscrearcuenta.Click += new System.EventHandler(this.iscrearcuenta_Click);
            // 
            // isbtningresar
            // 
            this.isbtningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.isbtningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isbtningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isbtningresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.isbtningresar.ForeColor = System.Drawing.Color.White;
            this.isbtningresar.Location = new System.Drawing.Point(416, 425);
            this.isbtningresar.Name = "isbtningresar";
            this.isbtningresar.Size = new System.Drawing.Size(89, 34);
            this.isbtningresar.TabIndex = 6;
            this.isbtningresar.Text = "INGRESAR";
            this.isbtningresar.UseVisualStyleBackColor = false;
            this.isbtningresar.Click += new System.EventHandler(this.isbtningresar_Click);
            // 
            // iscontrase
            // 
            this.iscontrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iscontrase.Location = new System.Drawing.Point(362, 382);
            this.iscontrase.Name = "iscontrase";
            this.iscontrase.PasswordChar = '*';
            this.iscontrase.Size = new System.Drawing.Size(202, 21);
            this.iscontrase.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTRASEÑA";
            // 
            // isusuario
            // 
            this.isusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isusuario.Location = new System.Drawing.Point(362, 322);
            this.isusuario.Name = "isusuario";
            this.isusuario.Size = new System.Drawing.Size(202, 21);
            this.isusuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "USUARIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iscrearcuenta);
            this.Controls.Add(this.isbtningresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iscontrase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO SESION";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox iscontrase;
        private Label label3;
        private TextBox isusuario;
        private Label label2;
        private Label iscrearcuenta;
        private Button isbtningresar;
        private Label label4;
    }
}

