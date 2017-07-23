namespace Omi24.Project.Fallout4
{
    partial class CrackerForm
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
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.Location = new System.Drawing.Point(12, 9);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(150, 47);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Word\r\n(ex: FINAL)";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(12, 59);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(150, 490);
            this.txtWord.TabIndex = 1;
            this.txtWord.TextChanged += new System.EventHandler(this.OnTextChangedCalculateResult);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(184, 59);
            this.txtGuess.Multiline = true;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(150, 490);
            this.txtGuess.TabIndex = 3;
            this.txtGuess.TextChanged += new System.EventHandler(this.OnTextChangedCalculateResult);
            // 
            // lblGuess
            // 
            this.lblGuess.Location = new System.Drawing.Point(184, 9);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(150, 47);
            this.lblGuess.TabIndex = 2;
            this.lblGuess.Text = "&Guess\r\n(ex: WORD 1)";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(359, 59);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(150, 490);
            this.txtResult.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(359, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 47);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Possible Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 561);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CrackerForm";
            this.Text = "CrackerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
    }
}