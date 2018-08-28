namespace test
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
                  this.button1 = new System.Windows.Forms.Button();
                  this.btnCut = new System.Windows.Forms.Button();
                  this.SuspendLayout();
                  // 
                  // button1
                  // 
                  this.button1.Location = new System.Drawing.Point(21, 11);
                  this.button1.Margin = new System.Windows.Forms.Padding(2);
                  this.button1.Name = "button1";
                  this.button1.Size = new System.Drawing.Size(65, 24);
                  this.button1.TabIndex = 0;
                  this.button1.Text = "绘图";
                  this.button1.UseVisualStyleBackColor = true;
                  this.button1.Click += new System.EventHandler(this.button1_Click);
                  // 
                  // btnCut
                  // 
                  this.btnCut.Location = new System.Drawing.Point(105, 11);
                  this.btnCut.Margin = new System.Windows.Forms.Padding(2);
                  this.btnCut.Name = "btnCut";
                  this.btnCut.Size = new System.Drawing.Size(74, 24);
                  this.btnCut.TabIndex = 1;
                  this.btnCut.Text = "钢板配料";
                  this.btnCut.UseVisualStyleBackColor = true;
                  this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
                  // 
                  // FrmMain
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(488, 322);
                  this.Controls.Add(this.btnCut);
                  this.Controls.Add(this.button1);
                  this.Margin = new System.Windows.Forms.Padding(2);
                  this.Name = "FrmMain";
                  this.Shown += new System.EventHandler(this.FrmMain_Shown);
                  this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCut;
    }
}

