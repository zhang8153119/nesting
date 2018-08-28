using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCad
{
    public partial class GeneForm : Form
    {
        public GeneForm()
        {
            InitializeComponent();
        }

        private DrawingBoard drawBoard;
        public GeneForm(DrawingBoard drawBoard)
        {
            this.drawBoard = drawBoard;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawBoard.jiaoChaLv = float.Parse(this.jiaoCha.Text.Trim());
            drawBoard.bianYiLv = float.Parse(this.bianYi.Text.Trim());
            drawBoard.zaiBianLv = float.Parse(this.zaiBian.Text.Trim());

            MessageBox.Show("设置成功");
            this.Close();
        }

        private void GeneForm_Load(object sender, EventArgs e)
        {
            this.jiaoCha.Text = "0.4";
            this.bianYi.Text = "0.5";
            this.zaiBian.Text = "0.1";
        }
    }
}
