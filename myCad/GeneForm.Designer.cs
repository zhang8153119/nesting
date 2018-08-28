namespace myCad
{
    partial class GeneForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jiaoCha = new System.Windows.Forms.TextBox();
            this.bianYi = new System.Windows.Forms.TextBox();
            this.zaiBian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "测试用，设置交叉，变异，灾变的概率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "交叉率（0-1）：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "变异率（0-1）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "灾变率（0-1）：";
            // 
            // jiaoCha
            // 
            this.jiaoCha.Location = new System.Drawing.Point(252, 116);
            this.jiaoCha.Name = "jiaoCha";
            this.jiaoCha.Size = new System.Drawing.Size(142, 25);
            this.jiaoCha.TabIndex = 4;
            // 
            // bianYi
            // 
            this.bianYi.Location = new System.Drawing.Point(252, 156);
            this.bianYi.Name = "bianYi";
            this.bianYi.Size = new System.Drawing.Size(142, 25);
            this.bianYi.TabIndex = 5;
            // 
            // zaiBian
            // 
            this.zaiBian.Location = new System.Drawing.Point(252, 193);
            this.zaiBian.Name = "zaiBian";
            this.zaiBian.Size = new System.Drawing.Size(142, 25);
            this.zaiBian.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(75, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(397, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "连续优秀子代，但是还是不符合要求的时候的时候进行灾变";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "设置概率";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zaiBian);
            this.Controls.Add(this.bianYi);
            this.Controls.Add(this.jiaoCha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GeneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "遗传算法配置";
            this.Load += new System.EventHandler(this.GeneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jiaoCha;
        private System.Windows.Forms.TextBox bianYi;
        private System.Windows.Forms.TextBox zaiBian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}