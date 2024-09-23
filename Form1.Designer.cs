namespace DelegadosC_
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.distanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angulo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.txty1 = new System.Windows.Forms.TextBox();
            this.txty2 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblresultado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(401, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pendienteToolStripMenuItem
            // 
            this.pendienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendienteToolStripMenuItem1,
            this.distanciaToolStripMenuItem,
            this.angulo1ToolStripMenuItem});
            this.pendienteToolStripMenuItem.Name = "pendienteToolStripMenuItem";
            this.pendienteToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pendienteToolStripMenuItem.Text = "Operaciones";
            // 
            // pendienteToolStripMenuItem1
            // 
            this.pendienteToolStripMenuItem1.Name = "pendienteToolStripMenuItem1";
            this.pendienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pendienteToolStripMenuItem1.Text = "Pendiente";
            this.pendienteToolStripMenuItem1.Click += new System.EventHandler(this.pendienteToolStripMenuItem1_Click);
            // 
            // distanciaToolStripMenuItem
            // 
            this.distanciaToolStripMenuItem.Name = "distanciaToolStripMenuItem";
            this.distanciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.distanciaToolStripMenuItem.Text = "Distancia";
            this.distanciaToolStripMenuItem.Click += new System.EventHandler(this.distanciaToolStripMenuItem_Click);
            // 
            // angulo1ToolStripMenuItem
            // 
            this.angulo1ToolStripMenuItem.Name = "angulo1ToolStripMenuItem";
            this.angulo1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.angulo1ToolStripMenuItem.Text = "Angulo";
            this.angulo1ToolStripMenuItem.Click += new System.EventHandler(this.angulo1ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txty2);
            this.groupBox1.Controls.Add(this.txty1);
            this.groupBox1.Controls.Add(this.txtx2);
            this.groupBox1.Controls.Add(this.txtx1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y2";
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(45, 23);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(83, 20);
            this.txtx1.TabIndex = 4;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(45, 53);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(83, 20);
            this.txtx2.TabIndex = 5;
            // 
            // txty1
            // 
            this.txty1.Location = new System.Drawing.Point(244, 23);
            this.txty1.Name = "txty1";
            this.txty1.Size = new System.Drawing.Size(83, 20);
            this.txty1.TabIndex = 6;
            // 
            // txty2
            // 
            this.txty2.Location = new System.Drawing.Point(244, 53);
            this.txty2.Name = "txty2";
            this.txty2.Size = new System.Drawing.Size(83, 20);
            this.txty2.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(13, 169);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(376, 372);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(13, 131);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 554);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Delegados en c#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pendienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem distanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angulo1ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txty2;
        private System.Windows.Forms.TextBox txty1;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblresultado;
    }
}

