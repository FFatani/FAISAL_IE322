namespace FAISAL_IE322
{
    partial class Combo
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
            this.BtnMethod1 = new System.Windows.Forms.Button();
            this.BtnMethod2 = new System.Windows.Forms.Button();
            this.BtnIndex = new System.Windows.Forms.Button();
            this.BtnName = new System.Windows.Forms.Button();
            this.BtnItem = new System.Windows.Forms.Button();
            this.BtnItem2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnMethod1
            // 
            this.BtnMethod1.Location = new System.Drawing.Point(47, 60);
            this.BtnMethod1.Name = "BtnMethod1";
            this.BtnMethod1.Size = new System.Drawing.Size(176, 81);
            this.BtnMethod1.TabIndex = 0;
            this.BtnMethod1.Text = "Show Selected Method 1";
            this.BtnMethod1.UseVisualStyleBackColor = true;
            this.BtnMethod1.Click += new System.EventHandler(this.BtnMethod1_Click);
            // 
            // BtnMethod2
            // 
            this.BtnMethod2.Location = new System.Drawing.Point(240, 61);
            this.BtnMethod2.Name = "BtnMethod2";
            this.BtnMethod2.Size = new System.Drawing.Size(176, 80);
            this.BtnMethod2.TabIndex = 1;
            this.BtnMethod2.Text = "Show Selected Method 2";
            this.BtnMethod2.UseVisualStyleBackColor = true;
            this.BtnMethod2.Click += new System.EventHandler(this.BtnMethod2_Click);
            // 
            // BtnIndex
            // 
            this.BtnIndex.Location = new System.Drawing.Point(47, 305);
            this.BtnIndex.Name = "BtnIndex";
            this.BtnIndex.Size = new System.Drawing.Size(123, 72);
            this.BtnIndex.TabIndex = 2;
            this.BtnIndex.Text = "Remove by Index";
            this.BtnIndex.UseVisualStyleBackColor = true;
            this.BtnIndex.Click += new System.EventHandler(this.BtnIndex_Click);
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(189, 306);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(123, 71);
            this.BtnName.TabIndex = 3;
            this.BtnName.Text = "Remove by Name";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // BtnItem
            // 
            this.BtnItem.Location = new System.Drawing.Point(566, 84);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(143, 95);
            this.BtnItem.TabIndex = 4;
            this.BtnItem.Text = "Remove last item";
            this.BtnItem.UseVisualStyleBackColor = true;
            this.BtnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // BtnItem2
            // 
            this.BtnItem2.Location = new System.Drawing.Point(566, 220);
            this.BtnItem2.Name = "BtnItem2";
            this.BtnItem2.Size = new System.Drawing.Size(143, 95);
            this.BtnItem2.TabIndex = 5;
            this.BtnItem2.Text = "Remove 2nd last item";
            this.BtnItem2.UseVisualStyleBackColor = true;
            this.BtnItem2.Click += new System.EventHandler(this.BtnItem2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(631, 367);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(144, 57);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbBox
            // 
            this.CmbBox.FormattingEnabled = true;
            this.CmbBox.Location = new System.Drawing.Point(170, 179);
            this.CmbBox.Name = "CmbBox";
            this.CmbBox.Size = new System.Drawing.Size(121, 24);
            this.CmbBox.TabIndex = 8;
            this.CmbBox.SelectedIndexChanged += new System.EventHandler(this.CmbBox_SelectedIndexChanged);
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnItem2);
            this.Controls.Add(this.BtnItem);
            this.Controls.Add(this.BtnName);
            this.Controls.Add(this.BtnIndex);
            this.Controls.Add(this.BtnMethod2);
            this.Controls.Add(this.BtnMethod1);
            this.Name = "Combo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.Combo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMethod1;
        private System.Windows.Forms.Button BtnMethod2;
        private System.Windows.Forms.Button BtnIndex;
        private System.Windows.Forms.Button BtnName;
        private System.Windows.Forms.Button BtnItem;
        private System.Windows.Forms.Button BtnItem2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBox;
    }
}