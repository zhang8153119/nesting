using myCad.CADInterfaceCtrl;
using myCad.Model;
using myCad.Shape;
using myCad.ShapeOper;
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
    public partial class inputStock : Form
    {
        private DrawingBoard drawBoard;
        public inputStock()
        {
            InitializeComponent();
        }
        public inputStock(DrawingBoard drawBoard)
        {
            this.drawBoard = drawBoard;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Line line1 = new Line(new PointF(0, 0), new PointF(float.Parse(this.width.Text.Trim()), 0));
            Line line2 = new Line(
                new PointF(float.Parse(this.width.Text.Trim()), 0),
                new PointF(float.Parse(this.width.Text.Trim()), float.Parse(this.height.Text.Trim())));
            Line line3 = new Line(
                new PointF(float.Parse(this.width.Text.Trim()), float.Parse(this.height.Text.Trim())),
                new PointF(0, float.Parse(this.height.Text.Trim())));
            Line line4 = new Line(
                new PointF(0, float.Parse(this.height.Text.Trim())),
                new PointF(0, 0));

            Stock stock = new Stock();
            stock.StockForm.Add(line1);
            stock.StockForm.Add(line2);
            stock.StockForm.Add(line3);
            stock.StockForm.Add(line4);

            stock.MinPoint = new PointF(0, 0);
            stock.MaxPoint = new PointF(float.Parse(this.width.Text.Trim()), float.Parse(this.height.Text.Trim()));

            stock.Height = float.Parse(this.height.Text.Trim());
            stock.Width = float.Parse(this.width.Text.Trim());
            stock.Num = int.Parse(this.number.Text.Trim());
            stock.StockId = drawBoard.listStock.Count;
            drawBoard.listStock.Add(stock);

            this.Close();
            MessageBox.Show("成功添加原材料钢板\n长度：" + this.width.Text.Trim() + "\n宽度：" + this.height.Text.Trim() + "\n数量：" + this.number.Text.Trim());
        }

        private void inputStock_Load(object sender, EventArgs e)
        {
            this.height.Text = "2000";
            this.width.Text = "8000";
            this.number.Text = "10";
        }
    }
}
