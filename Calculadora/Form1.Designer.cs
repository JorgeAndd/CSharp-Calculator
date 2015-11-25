namespace Calculadora
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
			this.txtResult = new System.Windows.Forms.TextBox();
			this.btnNum7 = new System.Windows.Forms.Button();
			this.btnNum4 = new System.Windows.Forms.Button();
			this.btnNum1 = new System.Windows.Forms.Button();
			this.btnOpSign = new System.Windows.Forms.Button();
			this.btnNum8 = new System.Windows.Forms.Button();
			this.btnNum9 = new System.Windows.Forms.Button();
			this.btnOpDiv = new System.Windows.Forms.Button();
			this.btnClearEntry = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnBackspace = new System.Windows.Forms.Button();
			this.btnHistory = new System.Windows.Forms.Button();
			this.btnNum5 = new System.Windows.Forms.Button();
			this.btnNum2 = new System.Windows.Forms.Button();
			this.btnNum0 = new System.Windows.Forms.Button();
			this.btnNum6 = new System.Windows.Forms.Button();
			this.btnNum3 = new System.Windows.Forms.Button();
			this.btnComma = new System.Windows.Forms.Button();
			this.btnOpTimes = new System.Windows.Forms.Button();
			this.btnOpMinus = new System.Windows.Forms.Button();
			this.btnOpPlus = new System.Windows.Forms.Button();
			this.btnOpEquals = new System.Windows.Forms.Button();
			this.lbHistory = new System.Windows.Forms.ListBox();
			this.panelHistory = new System.Windows.Forms.Panel();
			this.btnBin = new System.Windows.Forms.Button();
			this.panelHistory.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtResult
			// 
			this.txtResult.Enabled = false;
			this.txtResult.Location = new System.Drawing.Point(12, 14);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(259, 20);
			this.txtResult.TabIndex = 0;
			this.txtResult.Text = "0";
			// 
			// btnNum7
			// 
			this.btnNum7.Location = new System.Drawing.Point(12, 69);
			this.btnNum7.Name = "btnNum7";
			this.btnNum7.Size = new System.Drawing.Size(75, 23);
			this.btnNum7.TabIndex = 1;
			this.btnNum7.Text = "7";
			this.btnNum7.UseVisualStyleBackColor = true;
			this.btnNum7.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnNum4
			// 
			this.btnNum4.Location = new System.Drawing.Point(11, 98);
			this.btnNum4.Name = "btnNum4";
			this.btnNum4.Size = new System.Drawing.Size(75, 23);
			this.btnNum4.TabIndex = 2;
			this.btnNum4.Text = "4";
			this.btnNum4.UseVisualStyleBackColor = true;
			this.btnNum4.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnNum1
			// 
			this.btnNum1.Location = new System.Drawing.Point(11, 127);
			this.btnNum1.Name = "btnNum1";
			this.btnNum1.Size = new System.Drawing.Size(75, 23);
			this.btnNum1.TabIndex = 3;
			this.btnNum1.Text = "1";
			this.btnNum1.UseVisualStyleBackColor = true;
			this.btnNum1.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnOpSign
			// 
			this.btnOpSign.Location = new System.Drawing.Point(12, 156);
			this.btnOpSign.Name = "btnOpSign";
			this.btnOpSign.Size = new System.Drawing.Size(75, 23);
			this.btnOpSign.TabIndex = 4;
			this.btnOpSign.Text = "+-";
			this.btnOpSign.UseVisualStyleBackColor = true;
			// 
			// btnNum8
			// 
			this.btnNum8.Location = new System.Drawing.Point(93, 69);
			this.btnNum8.Name = "btnNum8";
			this.btnNum8.Size = new System.Drawing.Size(75, 23);
			this.btnNum8.TabIndex = 5;
			this.btnNum8.Text = "8";
			this.btnNum8.UseVisualStyleBackColor = true;
			this.btnNum8.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnNum9
			// 
			this.btnNum9.Location = new System.Drawing.Point(174, 69);
			this.btnNum9.Name = "btnNum9";
			this.btnNum9.Size = new System.Drawing.Size(75, 23);
			this.btnNum9.TabIndex = 9;
			this.btnNum9.Text = "9";
			this.btnNum9.UseVisualStyleBackColor = true;
			this.btnNum9.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnOpDiv
			// 
			this.btnOpDiv.Location = new System.Drawing.Point(253, 69);
			this.btnOpDiv.Name = "btnOpDiv";
			this.btnOpDiv.Size = new System.Drawing.Size(75, 23);
			this.btnOpDiv.TabIndex = 17;
			this.btnOpDiv.Text = "/";
			this.btnOpDiv.UseVisualStyleBackColor = true;
			this.btnOpDiv.Click += new System.EventHandler(this.btnOp_Click);
			// 
			// btnClearEntry
			// 
			this.btnClearEntry.Location = new System.Drawing.Point(54, 40);
			this.btnClearEntry.Name = "btnClearEntry";
			this.btnClearEntry.Size = new System.Drawing.Size(75, 23);
			this.btnClearEntry.TabIndex = 18;
			this.btnClearEntry.Text = "CE";
			this.btnClearEntry.UseVisualStyleBackColor = true;
			this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(135, 40);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 19;
			this.btnClear.Text = "C";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnBackspace
			// 
			this.btnBackspace.Location = new System.Drawing.Point(216, 40);
			this.btnBackspace.Name = "btnBackspace";
			this.btnBackspace.Size = new System.Drawing.Size(75, 23);
			this.btnBackspace.TabIndex = 20;
			this.btnBackspace.Text = "<<";
			this.btnBackspace.UseVisualStyleBackColor = true;
			this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
			// 
			// btnHistory
			// 
			this.btnHistory.Location = new System.Drawing.Point(299, 14);
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(28, 23);
			this.btnHistory.TabIndex = 22;
			this.btnHistory.Text = "H";
			this.btnHistory.UseVisualStyleBackColor = true;
			this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
			// 
			// btnNum5
			// 
			this.btnNum5.Location = new System.Drawing.Point(93, 98);
			this.btnNum5.Name = "btnNum5";
			this.btnNum5.Size = new System.Drawing.Size(75, 23);
			this.btnNum5.TabIndex = 6;
			this.btnNum5.Text = "5";
			this.btnNum5.UseVisualStyleBackColor = true;
			this.btnNum5.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnNum2
			// 
			this.btnNum2.Location = new System.Drawing.Point(93, 127);
			this.btnNum2.Name = "btnNum2";
			this.btnNum2.Size = new System.Drawing.Size(75, 23);
			this.btnNum2.TabIndex = 7;
			this.btnNum2.Text = "2";
			this.btnNum2.UseVisualStyleBackColor = true;
			this.btnNum2.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnNum0
			// 
			this.btnNum0.Location = new System.Drawing.Point(93, 156);
			this.btnNum0.Name = "btnNum0";
			this.btnNum0.Size = new System.Drawing.Size(75, 23);
			this.btnNum0.TabIndex = 8;
			this.btnNum0.Text = "0";
			this.btnNum0.UseVisualStyleBackColor = true;
			this.btnNum0.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnNum6
			// 
			this.btnNum6.Location = new System.Drawing.Point(174, 98);
			this.btnNum6.Name = "btnNum6";
			this.btnNum6.Size = new System.Drawing.Size(75, 23);
			this.btnNum6.TabIndex = 10;
			this.btnNum6.Text = "6";
			this.btnNum6.UseVisualStyleBackColor = true;
			this.btnNum6.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnNum3
			// 
			this.btnNum3.Location = new System.Drawing.Point(174, 127);
			this.btnNum3.Name = "btnNum3";
			this.btnNum3.Size = new System.Drawing.Size(75, 23);
			this.btnNum3.TabIndex = 11;
			this.btnNum3.Text = "3";
			this.btnNum3.UseVisualStyleBackColor = true;
			this.btnNum3.Click += new System.EventHandler(this.btnNumber_Click);
			// 
			// btnComma
			// 
			this.btnComma.Location = new System.Drawing.Point(174, 156);
			this.btnComma.Name = "btnComma";
			this.btnComma.Size = new System.Drawing.Size(75, 23);
			this.btnComma.TabIndex = 12;
			this.btnComma.Text = ",";
			this.btnComma.UseVisualStyleBackColor = true;
			this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
			// 
			// btnOpTimes
			// 
			this.btnOpTimes.Location = new System.Drawing.Point(255, 98);
			this.btnOpTimes.Name = "btnOpTimes";
			this.btnOpTimes.Size = new System.Drawing.Size(75, 23);
			this.btnOpTimes.TabIndex = 13;
			this.btnOpTimes.Text = "x";
			this.btnOpTimes.UseVisualStyleBackColor = true;
			this.btnOpTimes.Click += new System.EventHandler(this.btnOp_Click);
			// 
			// btnOpMinus
			// 
			this.btnOpMinus.Location = new System.Drawing.Point(255, 127);
			this.btnOpMinus.Name = "btnOpMinus";
			this.btnOpMinus.Size = new System.Drawing.Size(75, 23);
			this.btnOpMinus.TabIndex = 14;
			this.btnOpMinus.Text = "-";
			this.btnOpMinus.UseVisualStyleBackColor = true;
			this.btnOpMinus.Click += new System.EventHandler(this.btnOp_Click);
			// 
			// btnOpPlus
			// 
			this.btnOpPlus.Location = new System.Drawing.Point(253, 156);
			this.btnOpPlus.Name = "btnOpPlus";
			this.btnOpPlus.Size = new System.Drawing.Size(75, 23);
			this.btnOpPlus.TabIndex = 15;
			this.btnOpPlus.Text = "+";
			this.btnOpPlus.UseVisualStyleBackColor = true;
			this.btnOpPlus.Click += new System.EventHandler(this.btnOp_Click);
			// 
			// btnOpEquals
			// 
			this.btnOpEquals.Location = new System.Drawing.Point(253, 185);
			this.btnOpEquals.Name = "btnOpEquals";
			this.btnOpEquals.Size = new System.Drawing.Size(75, 23);
			this.btnOpEquals.TabIndex = 16;
			this.btnOpEquals.Text = "=";
			this.btnOpEquals.UseVisualStyleBackColor = true;
			this.btnOpEquals.Click += new System.EventHandler(this.btnOpEquals_Click);
			// 
			// lbHistory
			// 
			this.lbHistory.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.lbHistory.FormattingEnabled = true;
			this.lbHistory.Location = new System.Drawing.Point(3, 4);
			this.lbHistory.Name = "lbHistory";
			this.lbHistory.Size = new System.Drawing.Size(342, 147);
			this.lbHistory.TabIndex = 21;
			this.lbHistory.Visible = false;
			// 
			// panelHistory
			// 
			this.panelHistory.Controls.Add(this.btnBin);
			this.panelHistory.Controls.Add(this.lbHistory);
			this.panelHistory.Location = new System.Drawing.Point(0, 40);
			this.panelHistory.Name = "panelHistory";
			this.panelHistory.Size = new System.Drawing.Size(345, 180);
			this.panelHistory.TabIndex = 23;
			this.panelHistory.Visible = false;
			// 
			// btnBin
			// 
			this.btnBin.BackColor = System.Drawing.Color.Transparent;
			this.btnBin.BackgroundImage = global::Calculadora.Properties.Resources.bin;
			this.btnBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnBin.Location = new System.Drawing.Point(311, 145);
			this.btnBin.Name = "btnBin";
			this.btnBin.Size = new System.Drawing.Size(34, 35);
			this.btnBin.TabIndex = 22;
			this.btnBin.UseVisualStyleBackColor = false;
			this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 218);
			this.Controls.Add(this.panelHistory);
			this.Controls.Add(this.btnHistory);
			this.Controls.Add(this.btnBackspace);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnClearEntry);
			this.Controls.Add(this.btnOpDiv);
			this.Controls.Add(this.btnOpEquals);
			this.Controls.Add(this.btnOpPlus);
			this.Controls.Add(this.btnOpMinus);
			this.Controls.Add(this.btnOpTimes);
			this.Controls.Add(this.btnComma);
			this.Controls.Add(this.btnNum3);
			this.Controls.Add(this.btnNum6);
			this.Controls.Add(this.btnNum9);
			this.Controls.Add(this.btnNum0);
			this.Controls.Add(this.btnNum2);
			this.Controls.Add(this.btnNum5);
			this.Controls.Add(this.btnNum8);
			this.Controls.Add(this.btnOpSign);
			this.Controls.Add(this.btnNum1);
			this.Controls.Add(this.btnNum4);
			this.Controls.Add(this.btnNum7);
			this.Controls.Add(this.txtResult);
			this.Name = "Form1";
			this.Text = "Calculadora";
			this.Click += new System.EventHandler(this.Form1_Click);
			this.panelHistory.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnOpSign;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnOpDiv;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnHistory;
		private System.Windows.Forms.Button btnNum5;
		private System.Windows.Forms.Button btnNum2;
		private System.Windows.Forms.Button btnNum0;
		private System.Windows.Forms.Button btnNum6;
		private System.Windows.Forms.Button btnNum3;
		private System.Windows.Forms.Button btnComma;
		private System.Windows.Forms.Button btnOpTimes;
		private System.Windows.Forms.Button btnOpMinus;
		private System.Windows.Forms.Button btnOpPlus;
		private System.Windows.Forms.Button btnOpEquals;
		private System.Windows.Forms.ListBox lbHistory;
		private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Button btnBin;
    }
}

