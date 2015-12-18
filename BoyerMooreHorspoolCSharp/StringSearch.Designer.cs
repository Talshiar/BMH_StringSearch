namespace BoyerMooreHorspoolCSharp
{
    partial class StringSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxFileText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxBrowser = new System.Windows.Forms.GroupBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.groupBoxBrowser.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Or type a text you will be searching through:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(9, 31);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(367, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(15, 162);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(292, 20);
            this.textBoxPattern.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type a pattern you want to search for:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(301, 32);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxFileText
            // 
            this.textBoxFileText.Location = new System.Drawing.Point(8, 32);
            this.textBoxFileText.Name = "textBoxFileText";
            this.textBoxFileText.Size = new System.Drawing.Size(287, 20);
            this.textBoxFileText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Browse for a text file:";
            // 
            // groupBoxBrowser
            // 
            this.groupBoxBrowser.Controls.Add(this.label3);
            this.groupBoxBrowser.Controls.Add(this.buttonBrowse);
            this.groupBoxBrowser.Controls.Add(this.textBoxFileText);
            this.groupBoxBrowser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBrowser.Name = "groupBoxBrowser";
            this.groupBoxBrowser.Size = new System.Drawing.Size(386, 65);
            this.groupBoxBrowser.TabIndex = 10;
            this.groupBoxBrowser.TabStop = false;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.textBoxInput);
            this.groupBoxType.Controls.Add(this.label1);
            this.groupBoxType.Location = new System.Drawing.Point(12, 83);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(386, 60);
            this.groupBoxType.TabIndex = 11;
            this.groupBoxType.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(313, 160);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(316, 320);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(15, 320);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.richTextBoxResults.Location = new System.Drawing.Point(15, 213);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(376, 101);
            this.richTextBoxResults.TabIndex = 14;
            this.richTextBoxResults.Text = "";
            this.richTextBoxResults.Visible = false;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(15, 194);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(45, 13);
            this.labelResults.TabIndex = 15;
            this.labelResults.Text = "Results:";
            // 
            // StringSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 355);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.richTextBoxResults);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxBrowser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPattern);
            this.Name = "StringSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Search App";
            this.groupBoxBrowser.ResumeLayout(false);
            this.groupBoxBrowser.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFileText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxBrowser;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.Label labelResults;
    }
}

