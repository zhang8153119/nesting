namespace myCad
{
    partial class YuBan
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
            this.juXing = new System.Windows.Forms.CheckBox();
            this.tiXing = new System.Windows.Forms.CheckBox();
            this.yuanXing = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // juXing
            // 
            this.juXing.AutoSize = true;
            this.juXing.Location = new System.Drawing.Point(173, 71);
            this.juXing.Name = "juXing";
            this.juXing.Size = new System.Drawing.Size(59, 19);
            this.juXing.TabIndex = 0;
            this.juXing.Text = "矩形";
            this.juXing.UseVisualStyleBackColor = true;
            this.juXing.CheckedChanged += new System.EventHandler(this.juXing_CheckedChanged);
            // 
            // tiXing
            // 
            this.tiXing.AutoSize = true;
            this.tiXing.Location = new System.Drawing.Point(173, 118);
            this.tiXing.Name = "tiXing";
            this.tiXing.Size = new System.Drawing.Size(59, 19);
            this.tiXing.TabIndex = 1;
            this.tiXing.Text = "梯形";
            this.tiXing.UseVisualStyleBackColor = true;
            this.tiXing.CheckedChanged += new System.EventHandler(this.tiXing_CheckedChanged);
            // 
            // yuanXing
            // 
            this.yuanXing.AutoSize = true;
            this.yuanXing.Location = new System.Drawing.Point(173, 163);
            this.yuanXing.Name = "yuanXing";
            this.yuanXing.Size = new System.Drawing.Size(59, 19);
            this.yuanXing.TabIndex = 2;
            this.yuanXing.Text = "原型";
            this.yuanXing.UseVisualStyleBackColor = true;
            this.yuanXing.CheckedChanged += new System.EventHandler(this.yuanXing_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YuBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yuanXing);
            this.Controls.Add(this.tiXing);
            this.Controls.Add(this.juXing);
            this.Name = "YuBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "余板保留模式";
            this.Load += new System.EventHandler(this.YuBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox juXing;
        private System.Windows.Forms.CheckBox tiXing;
        private System.Windows.Forms.CheckBox yuanXing;
        private System.Windows.Forms.Button button1;
    }
}