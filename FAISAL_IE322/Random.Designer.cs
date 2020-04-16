namespace FAISAL_IE322
{
    partial class FrmRandom
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
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnNum = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.LblRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(30, 33);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(311, 128);
            this.BtnColor.TabIndex = 0;
            this.BtnColor.Text = "Generate Random Color";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnNum
            // 
            this.BtnNum.Location = new System.Drawing.Point(30, 278);
            this.BtnNum.Name = "BtnNum";
            this.BtnNum.Size = new System.Drawing.Size(311, 128);
            this.BtnNum.TabIndex = 1;
            this.BtnNum.Text = "Random Number";
            this.BtnNum.UseVisualStyleBackColor = true;
            this.BtnNum.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(582, 323);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(206, 83);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // LblRandom
            // 
            this.LblRandom.AutoSize = true;
            this.LblRandom.Location = new System.Drawing.Point(53, 209);
            this.LblRandom.Name = "LblRandom";
            this.LblRandom.Size = new System.Drawing.Size(46, 17);
            this.LblRandom.TabIndex = 3;
            this.LblRandom.Text = "label1";
            // 
            // Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRandom);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNum);
            this.Controls.Add(this.BtnColor);
            this.Name = "Random";
            this.Text = "Random";
            this.Load += new System.EventHandler(this.Random_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnNum;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblRandom;
    }
}