namespace CalculatorUsingAString
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbxAnswer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(22, 198);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(154, 35);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.Snow;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Location = new System.Drawing.Point(22, 66);
            this.txtInput.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(155, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbxAnswer
            // 
            this.lbxAnswer.FormattingEnabled = true;
            this.lbxAnswer.Location = new System.Drawing.Point(22, 88);
            this.lbxAnswer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lbxAnswer.Name = "lbxAnswer";
            this.lbxAnswer.Size = new System.Drawing.Size(154, 108);
            this.lbxAnswer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a formula eg: 4+6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxAnswer);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCalc);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lbxAnswer;
        private System.Windows.Forms.Label label1;
    }
}

