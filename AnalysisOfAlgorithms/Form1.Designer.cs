namespace AnalysisOfAlgorithms
{
    partial class HuffmanGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.decodedLbl = new System.Windows.Forms.Label();
            this.AddLabel = new System.Windows.Forms.Label();
            this.chart0 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StaticRadio = new System.Windows.Forms.RadioButton();
            this.DynamicRadio = new System.Windows.Forms.RadioButton();
            this.BothRadio = new System.Windows.Forms.RadioButton();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.Graphics = new System.Windows.Forms.Label();
            this.FileInfLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.CharNumberLabel = new System.Windows.Forms.Label();
            this.NOCLabel = new System.Windows.Forms.Label();
            this.DynamicResult = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart0)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ChooseFileButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ChooseFileButton.Location = new System.Drawing.Point(327, 48);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(300, 33);
            this.ChooseFileButton.TabIndex = 3;
            this.ChooseFileButton.Text = "Add Document";
            this.ChooseFileButton.UseVisualStyleBackColor = false;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.start.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(24, 163);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(603, 36);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(14, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(14, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 9;
            // 
            // decodedLbl
            // 
            this.decodedLbl.AutoSize = true;
            this.decodedLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodedLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.decodedLbl.Location = new System.Drawing.Point(110, 316);
            this.decodedLbl.Name = "decodedLbl";
            this.decodedLbl.Size = new System.Drawing.Size(0, 17);
            this.decodedLbl.TabIndex = 10;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddLabel.Location = new System.Drawing.Point(324, 25);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(165, 16);
            this.AddLabel.TabIndex = 12;
            this.AddLabel.Text = "Click to add document:";
            // 
            // chart0
            // 
            this.chart0.BackColor = System.Drawing.Color.Transparent;
            this.chart0.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart0.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chart0.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart0.Legends.Add(legend2);
            this.chart0.Location = new System.Drawing.Point(6, 11);
            this.chart0.Name = "chart0";
            this.chart0.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart0.Series.Add(series2);
            this.chart0.Size = new System.Drawing.Size(596, 239);
            this.chart0.TabIndex = 1;
            this.chart0.Text = "chart0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(249, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compression Ratio";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chart0);
            this.panel1.Location = new System.Drawing.Point(25, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 256);
            this.panel1.TabIndex = 2;
            // 
            // StaticRadio
            // 
            this.StaticRadio.AutoSize = true;
            this.StaticRadio.Location = new System.Drawing.Point(27, 56);
            this.StaticRadio.Name = "StaticRadio";
            this.StaticRadio.Size = new System.Drawing.Size(52, 17);
            this.StaticRadio.TabIndex = 13;
            this.StaticRadio.TabStop = true;
            this.StaticRadio.Text = "Static";
            this.StaticRadio.UseVisualStyleBackColor = true;
            // 
            // DynamicRadio
            // 
            this.DynamicRadio.AutoSize = true;
            this.DynamicRadio.Location = new System.Drawing.Point(127, 56);
            this.DynamicRadio.Name = "DynamicRadio";
            this.DynamicRadio.Size = new System.Drawing.Size(66, 17);
            this.DynamicRadio.TabIndex = 14;
            this.DynamicRadio.TabStop = true;
            this.DynamicRadio.Text = "Dynamic";
            this.DynamicRadio.UseVisualStyleBackColor = true;
            // 
            // BothRadio
            // 
            this.BothRadio.AutoSize = true;
            this.BothRadio.Location = new System.Drawing.Point(240, 56);
            this.BothRadio.Name = "BothRadio";
            this.BothRadio.Size = new System.Drawing.Size(47, 17);
            this.BothRadio.TabIndex = 15;
            this.BothRadio.TabStop = true;
            this.BothRadio.Text = "Both";
            this.BothRadio.UseVisualStyleBackColor = true;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectionLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SelectionLabel.Location = new System.Drawing.Point(23, 25);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(161, 16);
            this.SelectionLabel.TabIndex = 16;
            this.SelectionLabel.Text = "Huffman Coding Type:";
            // 
            // Graphics
            // 
            this.Graphics.AutoSize = true;
            this.Graphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Graphics.ForeColor = System.Drawing.Color.SteelBlue;
            this.Graphics.Location = new System.Drawing.Point(20, 434);
            this.Graphics.Name = "Graphics";
            this.Graphics.Size = new System.Drawing.Size(608, 20);
            this.Graphics.TabIndex = 17;
            this.Graphics.Text = "Graphics ------------------------------------------------------------------------" +
    "---------------";
            // 
            // FileInfLabel
            // 
            this.FileInfLabel.AutoSize = true;
            this.FileInfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FileInfLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.FileInfLabel.Location = new System.Drawing.Point(20, 95);
            this.FileInfLabel.Name = "FileInfLabel";
            this.FileInfLabel.Size = new System.Drawing.Size(607, 20);
            this.FileInfLabel.TabIndex = 18;
            this.FileInfLabel.Text = "Document Information ------------------------------------------------------------" +
    "---------";
            this.FileInfLabel.Click += new System.EventHandler(this.FileInfLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(278, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Size:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SizeLabel.Location = new System.Drawing.Point(320, 130);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(65, 16);
            this.SizeLabel.TabIndex = 20;
            this.SizeLabel.Text = "                   ";
            // 
            // DName
            // 
            this.DName.AutoSize = true;
            this.DName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DName.Location = new System.Drawing.Point(75, 130);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(62, 16);
            this.DName.TabIndex = 22;
            this.DName.Text = "                  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(22, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Name:";
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.LightBlue;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Results.Location = new System.Drawing.Point(25, 213);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(299, 207);
            this.Results.TabIndex = 23;
            this.Results.Text = "";
            // 
            // CharNumberLabel
            // 
            this.CharNumberLabel.AutoSize = true;
            this.CharNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CharNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.CharNumberLabel.Location = new System.Drawing.Point(502, 130);
            this.CharNumberLabel.Name = "CharNumberLabel";
            this.CharNumberLabel.Size = new System.Drawing.Size(52, 16);
            this.CharNumberLabel.TabIndex = 24;
            this.CharNumberLabel.Text = "Chars:";
            this.CharNumberLabel.Click += new System.EventHandler(this.CharNumberLabel_Click);
            // 
            // NOCLabel
            // 
            this.NOCLabel.AutoSize = true;
            this.NOCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NOCLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NOCLabel.Location = new System.Drawing.Point(556, 130);
            this.NOCLabel.Name = "NOCLabel";
            this.NOCLabel.Size = new System.Drawing.Size(35, 16);
            this.NOCLabel.TabIndex = 25;
            this.NOCLabel.Text = "         ";
            // 
            // DynamicResult
            // 
            this.DynamicResult.BackColor = System.Drawing.Color.PaleGreen;
            this.DynamicResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DynamicResult.Location = new System.Drawing.Point(327, 213);
            this.DynamicResult.Name = "DynamicResult";
            this.DynamicResult.Size = new System.Drawing.Size(300, 207);
            this.DynamicResult.TabIndex = 26;
            this.DynamicResult.Text = "";
            // 
            // HuffmanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(649, 749);
            this.Controls.Add(this.DynamicResult);
            this.Controls.Add(this.NOCLabel);
            this.Controls.Add(this.CharNumberLabel);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FileInfLabel);
            this.Controls.Add(this.Graphics);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.BothRadio);
            this.Controls.Add(this.DynamicRadio);
            this.Controls.Add(this.StaticRadio);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.decodedLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HuffmanGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis of Algorithms - Huffman Coding Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart0)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label decodedLbl;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton StaticRadio;
        private System.Windows.Forms.RadioButton DynamicRadio;
        private System.Windows.Forms.RadioButton BothRadio;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.Label Graphics;
        private System.Windows.Forms.Label FileInfLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label DName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Label CharNumberLabel;
        private System.Windows.Forms.Label NOCLabel;
        private System.Windows.Forms.RichTextBox DynamicResult;
    }
}

