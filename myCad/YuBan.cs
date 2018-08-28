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
    public partial class YuBan : Form
    {
        private DrawingBoard drawBoard;
        public YuBan()
        {
            InitializeComponent();
        }

        public YuBan(DrawingBoard drawBoard)
        {
            this.drawBoard = drawBoard;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (juXing.Checked)
            {
                drawBoard.yuBanBaoLiuFangShi = 0;
            }
            else if (tiXing.Checked)
            {
                drawBoard.yuBanBaoLiuFangShi = 1;
            }
            else
            {
                drawBoard.yuBanBaoLiuFangShi = 2;
            }
            MessageBox.Show("余板保留方式已经确定");
            this.Close();
        }

        private void juXing_CheckedChanged(object sender, EventArgs e)
        {
            if (juXing.Checked)
            {
                tiXing.Checked = false;
                yuanXing.Checked = false;
            }
        }

        private void tiXing_CheckedChanged(object sender, EventArgs e)
        {
            if (tiXing.Checked)
            {
                juXing.Checked = false;
                yuanXing.Checked = false;
            }
        }

        private void yuanXing_CheckedChanged(object sender, EventArgs e)
        {
            if (yuanXing.Checked)
            {
                tiXing.Checked = false;
                juXing.Checked = false;
            }
        }

        private void YuBan_Load(object sender, EventArgs e)
        {
            if (drawBoard.yuBanBaoLiuFangShi == 0)
            {
                juXing.Checked = true;
            }
            else if (drawBoard.yuBanBaoLiuFangShi == 1)
            {
                tiXing.Checked = true;
            }
            else
            {
                yuanXing.Checked = true;
            }
        }
    }
}
