using myCad;
using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Threading .Tasks;
using System .Windows .Forms;

namespace test
{
      public partial class FrmMain : Form
      {
            public FrmMain()
            {
                  InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                  DrawingBoard drbo = new DrawingBoard();
                  drbo .ShowDialog();
            }

            private void btnCut_Click(object sender, EventArgs e)
            {
                  FrmCut frm = new FrmCut();
                  frm .Show();
            }

            private void FrmMain_Shown(object sender, EventArgs e)
            {
                  FrmCut frm = new FrmCut();
                  frm .Show();
            }
      }
}
