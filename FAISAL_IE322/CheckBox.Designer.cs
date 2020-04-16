namespace FAISAL_IE322
{
    partial class CheckBox
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.ChkDonut = new System.Windows.Forms.CheckBox();
            this.ChkBrownie = new System.Windows.Forms.CheckBox();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(87, 44);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(187, 77);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // ChkDonut
            // 
            this.ChkDonut.AutoSize = true;
            this.ChkDonut.Location = new System.Drawing.Point(87, 223);
            this.ChkDonut.Name = "ChkDonut";
            this.ChkDonut.Size = new System.Drawing.Size(68, 21);
            this.ChkDonut.TabIndex = 2;
            this.ChkDonut.Text = "Donut";
            this.ChkDonut.UseVisualStyleBackColor = true;
            // 
            // ChkBrownie
            // 
            this.ChkBrownie.AutoSize = true;
            this.ChkBrownie.Location = new System.Drawing.Point(87, 274);
            this.ChkBrownie.Name = "ChkBrownie";
            this.ChkBrownie.Size = new System.Drawing.Size(80, 21);
            this.ChkBrownie.TabIndex = 3;
            this.ChkBrownie.Text = "Brownie";
            this.ChkBrownie.UseVisualStyleBackColor = true;
            this.ChkBrownie.CheckedChanged += new System.EventHandler(this.ChkBrownie_CheckedChanged);
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(87, 163);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(71, 21);
            this.ChkCoffee.TabIndex = 4;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(583, 337);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(143, 65);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.ChkCoffee);
            this.Controls.Add(this.ChkBrownie);
            this.Controls.Add(this.ChkDonut);
            this.Controls.Add(this.BtnShow);
            this.Name = "CheckBox";
            this.Text = "CheckBox";
            this.Load += new System.EventHandler(this.CheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.CheckBox ChkDonut;
        private System.Windows.Forms.CheckBox ChkBrownie;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.Button BtnBack;
    }
}