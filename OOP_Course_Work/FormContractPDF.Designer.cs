namespace OOP_Course_Work
{
    partial class FormContractPDF
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
            this.tbFormContractPDFDate1 = new System.Windows.Forms.TextBox();
            this.tbFormContractPDFDate2 = new System.Windows.Forms.TextBox();
            this.btnFormContractPDF = new System.Windows.Forms.Button();
            this.btnFormContractPDFExit = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFormContractPDFDate1
            // 
            this.tbFormContractPDFDate1.Location = new System.Drawing.Point(12, 23);
            this.tbFormContractPDFDate1.Multiline = true;
            this.tbFormContractPDFDate1.Name = "tbFormContractPDFDate1";
            this.tbFormContractPDFDate1.Size = new System.Drawing.Size(307, 32);
            this.tbFormContractPDFDate1.TabIndex = 1;
            this.tbFormContractPDFDate1.Enter += new System.EventHandler(this.tbFormContractPDFDate1_Enter);
            this.tbFormContractPDFDate1.Leave += new System.EventHandler(this.tbFormContractPDFDate1_Leave);
            // 
            // tbFormContractPDFDate2
            // 
            this.tbFormContractPDFDate2.Location = new System.Drawing.Point(13, 70);
            this.tbFormContractPDFDate2.Multiline = true;
            this.tbFormContractPDFDate2.Name = "tbFormContractPDFDate2";
            this.tbFormContractPDFDate2.Size = new System.Drawing.Size(306, 32);
            this.tbFormContractPDFDate2.TabIndex = 2;
            this.tbFormContractPDFDate2.Enter += new System.EventHandler(this.tbFormContractPDFDate2_Enter);
            this.tbFormContractPDFDate2.Leave += new System.EventHandler(this.tbFormContractPDFDate2_Leave);
            // 
            // btnFormContractPDF
            // 
            this.btnFormContractPDF.Location = new System.Drawing.Point(12, 236);
            this.btnFormContractPDF.Name = "btnFormContractPDF";
            this.btnFormContractPDF.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractPDF.TabIndex = 3;
            this.btnFormContractPDF.Text = "Отчет";
            this.btnFormContractPDF.UseVisualStyleBackColor = true;
            this.btnFormContractPDF.Click += new System.EventHandler(this.btnFormContractPDF_Click);
            // 
            // btnFormContractPDFExit
            // 
            this.btnFormContractPDFExit.Location = new System.Drawing.Point(204, 236);
            this.btnFormContractPDFExit.Name = "btnFormContractPDFExit";
            this.btnFormContractPDFExit.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractPDFExit.TabIndex = 0;
            this.btnFormContractPDFExit.Text = "Выйти";
            this.btnFormContractPDFExit.UseVisualStyleBackColor = true;
            this.btnFormContractPDFExit.Click += new System.EventHandler(this.btnFormContractPDFExit_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(346, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(734, 523);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // FormContractPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 558);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnFormContractPDFExit);
            this.Controls.Add(this.btnFormContractPDF);
            this.Controls.Add(this.tbFormContractPDFDate2);
            this.Controls.Add(this.tbFormContractPDFDate1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormContractPDF";
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.FormContractPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormContractPDFDate1;
        private System.Windows.Forms.TextBox tbFormContractPDFDate2;
        private System.Windows.Forms.Button btnFormContractPDF;
        private System.Windows.Forms.Button btnFormContractPDFExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}