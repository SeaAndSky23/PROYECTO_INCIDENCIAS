namespace PROYECTO_INCIDENCIAS
{
    partial class frmEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas));
            this.chartIncidencias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnactu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncidencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnactu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartIncidencias
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIncidencias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIncidencias.Legends.Add(legend1);
            this.chartIncidencias.Location = new System.Drawing.Point(26, 211);
            this.chartIncidencias.Name = "chartIncidencias";
            this.chartIncidencias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartIncidencias.Series.Add(series1);
            this.chartIncidencias.Size = new System.Drawing.Size(821, 355);
            this.chartIncidencias.TabIndex = 0;
            this.chartIncidencias.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(250, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "DISTRITOS CON MAYORES INCIDENCIAS";
            // 
            // btnactu
            // 
            this.btnactu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactu.Image = global::PROYECTO_INCIDENCIAS.Properties.Resources.actualizar;
            this.btnactu.Location = new System.Drawing.Point(133, 141);
            this.btnactu.Name = "btnactu";
            this.btnactu.Size = new System.Drawing.Size(42, 35);
            this.btnactu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnactu.TabIndex = 15;
            this.btnactu.TabStop = false;
            this.btnactu.Click += new System.EventHandler(this.btnactu_Click);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 727);
            this.Controls.Add(this.btnactu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartIncidencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncidencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnactu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncidencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnactu;
    }
}