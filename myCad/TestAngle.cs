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
    public partial class TestAngle : Form
    {
        private DrawingBoard db ;
        public TestAngle()
        {
            InitializeComponent();
        }
        public TestAngle(DrawingBoard db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.angleTest = int.Parse(this.angle.Text.Trim().Equals("") ? "0": this.angle.Text.Trim());
            this.Close();
        }
    }
}
