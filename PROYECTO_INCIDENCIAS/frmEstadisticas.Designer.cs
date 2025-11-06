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
            this.btnvolver4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncidencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver4)).BeginInit();
            this.SuspendLayout();
            // 
            // chartIncidencias
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIncidencias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIncidencias.Legends.Add(legend1);
            this.chartIncidencias.Location = new System.Drawing.Point(103, 135);
            this.chartIncidencias.Name = "chartIncidencias";
            this.chartIncidencias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartIncidencias.Series.Add(series1);
            this.chartIncidencias.Size = new System.Drawing.Size(759, 331);
            this.chartIncidencias.TabIndex = 0;
            this.chartIncidencias.Text = "chart1";
            // 
            // btnvolver4
            // 
            this.btnvolver4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver4.Image = ((System.Drawing.Image)(resources.GetObject("btnvolver4.Image")));
            this.btnvolver4.Location = new System.Drawing.Point(12, 12);
            this.btnvolver4.Name = "btnvolver4";
            this.btnvolver4.Size = new System.Drawing.Size(44, 50);
            this.btnvolver4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvolver4.TabIndex = 13;
            this.btnvolver4.TabStop = false;
            this.btnvolver4.Click += new System.EventHandler(this.btnvolver4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(293, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "DISTRITOS CON MAYOES INCIDENCIAS";
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvolver4);
            this.Controls.Add(this.chartIncidencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncidencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvolver4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncidencias;
        private System.Windows.Forms.PictureBox btnvolver4;
        private System.Windows.Forms.Label label1;
    }
}