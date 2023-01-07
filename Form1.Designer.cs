namespace PPM
{
    partial class Form1
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
            this.btnBrowseTraceFile = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBitiHRg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxAcuratete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowseTraceFile
            // 
            this.btnBrowseTraceFile.Location = new System.Drawing.Point(79, 61);
            this.btnBrowseTraceFile.Name = "btnBrowseTraceFile";
            this.btnBrowseTraceFile.Size = new System.Drawing.Size(150, 30);
            this.btnBrowseTraceFile.TabIndex = 0;
            this.btnBrowseTraceFile.Text = "Browse Trace File";
            this.btnBrowseTraceFile.UseVisualStyleBackColor = true;
            this.btnBrowseTraceFile.Click += new System.EventHandler(this.btnBrowseTraceFile_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(263, 67);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(289, 20);
            this.textBoxFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numar biti HRg:";
            // 
            // comboBoxBitiHRg
            // 
            this.comboBoxBitiHRg.FormattingEnabled = true;
            this.comboBoxBitiHRg.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "70",
            "100"});
            this.comboBoxBitiHRg.Location = new System.Drawing.Point(183, 124);
            this.comboBoxBitiHRg.Name = "comboBoxBitiHRg";
            this.comboBoxBitiHRg.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBitiHRg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Predictor de ordin:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(82, 243);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxAcuratete
            // 
            this.textBoxAcuratete.Location = new System.Drawing.Point(589, 67);
            this.textBoxAcuratete.Name = "textBoxAcuratete";
            this.textBoxAcuratete.Size = new System.Drawing.Size(110, 20);
            this.textBoxAcuratete.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 765);
            this.Controls.Add(this.textBoxAcuratete);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBitiHRg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.btnBrowseTraceFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrowseTraceFile;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBitiHRg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxAcuratete;
    }
}

