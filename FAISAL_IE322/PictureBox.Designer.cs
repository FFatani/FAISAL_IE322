namespace FAISAL_IE322
{
    partial class PictureBox
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
            this.BtnLoad = new System.Windows.Forms.Button();
            this.PctBox = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(12, 12);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(163, 85);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.Text = "Load Image";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // PctBox
            // 
            this.PctBox.Location = new System.Drawing.Point(12, 103);
            this.PctBox.Name = "PctBox";
            this.PctBox.Size = new System.Drawing.Size(776, 335);
            this.PctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox.TabIndex = 1;
            this.PctBox.TabStop = false;
            this.PctBox.Click += new System.EventHandler(this.PctBox_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(586, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(202, 85);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PctBox);
            this.Controls.Add(this.BtnLoad);
            this.Name = "PictureBox";
            this.Text = "PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.PctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.PictureBox PctBox;
        private System.Windows.Forms.Button BtnBack;
    }
}