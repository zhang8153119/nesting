using myCad.BaseShapeOper;
using myCad.CADInterfaceCtrl;
using myCad.DrawTools;
using myCad.DXFOper;
using myCad.Model;
using myCad.PaiYangSuanFa;
using myCad.Shape;
using myCad.ShapeOper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace myCad
{
    public partial class DrawingBoard : Form
    {
        public static BaseTool currentTool;                                                                       //当前命令
        public static Dictionary<string, BaseTool> registerTool = new Dictionary<string, BaseTool>();             //工具组件列表

        //初始化绘图工具
        public const string CreateLineTool = "CreateLineTool";
        public const string CreateCircleTool = "CreateCircleTool";
        public const string CreateArcTool = "CreateArcTool";
        public const string CreateEllipseTool = "CreateEllipseTool";
        public const string CreateTextTool = "CreateTextTool";

        List<PlateModel> listPlate = new List<PlateModel>();                                  //件号列表，先分别按宽度，长度,面积，排序
        public List<Stock> listStock = new List<Stock>();                                     //原材料钢板
        List<PlateModel> geneCode = new List<PlateModel>();                                   //遗传编码
        //List<Stock> usingStock = new List<Stock>();                                         //使用中的原材料碎片集合
        List<PaiYangFangAn> listFinallyFangAn = new List<PaiYangFangAn>();                    //最终的方案列表

        public float bianYiLv = 0;                                                            //变异率
        public float jiaoChaLv = 0;                                                           //交叉率
        public float zaiBianLv = 0;                                                           //灾变率
        public int yuBanBaoLiuFangShi = 0;                                                    //0，矩形,1，梯形,2，原型
        private float signX = 0;
        private float signY = 0;
        public int angleTest = -9999;


        //初始化编辑工具
        public const string NoToolLoad = "NoToolLoad";

        //记录上一个命令
        public static string LastTool = "NoToolLoad";

        public DrawingBoard()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void picBoard_Paint(object sender, PaintEventArgs e)
        {
            //Graphics graphics = e.Graphics;
            //Pen pen = new Pen(Color.Blue,1);
            //graphics.DrawLine(pen, -10, -10, 100, 100);
            //graphics.DrawEllipse(pen,200,200,299999999999999999, 299999999999999999);
        }

        private void DrawingBoard_Load(object sender, EventArgs e)
        {
            this.currentCoordinates.Text = "0,0";
            registerTool.Add(CreateLineTool, new LineTool());
            registerTool.Add(CreateCircleTool,new CircleTool());
            registerTool.Add(CreateArcTool, new ArcTool());
            registerTool.Add(CreateEllipseTool,new EllipseTool());
            registerTool.Add(CreateTextTool,new TextTool());
            registerTool.Add(NoToolLoad,new NoToolLoad());
            currentTool = registerTool[LastTool];
        }

        /// <summary>
        /// 加载工具
        /// </summary>
        /// <param name="registerName"></param>
        public void UseTool(string registerName)
        {
            currentTool.UnLoadTool();
            currentTool = registerTool[registerName];
            currentTool.LoadTool();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofdnew = new OpenFileDialog();
            DxfInputA di = new DxfInputA();
            di.mainmethod();
        }

        private void ceshipToLine_Click(object sender, EventArgs e)
        {
            //float juli = new BaseDistance().calculateDistance(CADInterfaceCtrl.CADInterface.currentShapes[0], new PointF(0, 50), 1);
            //MessageBox.Show("距离：" + juli.ToString());

            for (int i = 0; i < CADInterface.currentShapes.Count; i++)
            {
                //if ("Ellipse".Equals(CADInterface.currentShapes[i].ShapeClass))
                //{
                //    Ellipse ra = (Ellipse)CADInterface.currentShapes[i];
                //    ra.getArea(); 
                //    RectangleF bound = ra.Bound;
                //    MessageBox.Show("X:"+bound.X +"\n Y:"+bound.Y+"\n Width:"+bound.Width+"\n Height:"+bound.Height+" \n Area" + ra.Area +" \n Area" + ra.LongRadius*ra.ShortRadius*Math.PI +" \n" + 100*ra.Area/(ra.LongRadius * ra.ShortRadius * Math.PI));
                //}

            }
            //MessageBox.Show("角度："+((Ellipse)CADInterfaceCtrl.CADInterface.currentShapes[0]).Angle);
        }

        /// <summary>
        /// 右击菜单，复制功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyOper_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 右击菜单，移动功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveOper_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 右击菜单，旋转功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateOper_Click(object sender, EventArgs e)
        {
            RotateOper rotate = new RotateOper();
            rotate.RotatePlate(listPlate[0],listPlate[0].RotateCenter,5);
        }

        /// <summary>
        /// 右击菜单，镜像功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MirrorOper_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 右击菜单，偏移功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OffsetOper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("后续添加，暂时不用");
        }

        /// <summary>
        /// 右击菜单，缩放功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScalingOper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("方法存在漏洞，需要重新验证考虑");
            //Scale scale = new ShapeOper.Scale();
            //for (int i = 0;i<listPlate.Count;i++)
            //{
            //    scale.ScalePlate(listPlate[i],listPlate[i].RotateCenter,1.01f);
            //}
        }

        /// <summary>
        /// 右击菜单，Zoom功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZoomOper_Click(object sender, EventArgs e)
        {
            ZoomOper zoom = new ShapeOper.ZoomOper();
            zoom.zoomYuanCaiLiao(this.tableLayoutPanel1);
           
        }

        /// <summary>
        /// 右击菜单，删除功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteOper_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 界面关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawingBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            CADInterface.currentShapes.Clear();
            CADInterface.currentPlates.Clear();
            CADInterface.nowStock.StockForm.Clear();
            listPlate.Clear();
            listStock.Clear();
            registerTool.Clear();
        }

        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDrawLine_Click(object sender, EventArgs e)
        {
            UseTool(CreateLineTool);
            LastTool = CreateLineTool;
        }

        /// <summary>
        /// 画圆弧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDrawArc_Click(object sender, EventArgs e)
        {
            UseTool(CreateArcTool);
            LastTool = CreateArcTool;
        }

        /// <summary>
        /// 画圆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDrawCircle_Click(object sender, EventArgs e)
        {
            UseTool(CreateCircleTool);
            LastTool = CreateCircleTool;
        }

        /// <summary>
        /// 画椭圆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDrawEllipse_Click(object sender, EventArgs e)
        {
            UseTool(CreateEllipseTool);
            LastTool = CreateEllipseTool;
        }

        /// <summary>
        /// 画椭圆弧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDrawEllipseArc_Click(object sender, EventArgs e)
        {
            UseTool(CreateEllipseTool);
            LastTool = CreateEllipseTool;
        }

        #region 鼠标事件

        private void cadJieMian_MouseDown(object sender, MouseEventArgs e)
        {
            currentTool.MouseDown(e);
        }


        private void cadJieMian_MouseMove(object sender, MouseEventArgs e)
        {
            currentTool.MouseMove(e);
            this.currentCoordinates.Text = MouseShape.MousePoint.X.ToString() + "," + MouseShape.MousePoint.Y.ToString();
        }

        #endregion

        /// <summary>
        /// 读取件号，直接选择所有的单个文件，分别进行处理，处理完之后对所有件号进行排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
            DxfInputB di = new DxfInputB();
            List<PlateModel> inputPlate = di.mainmethod();
            if (inputPlate.Count > 0)
            {
                listPlate.AddRange(inputPlate);
                //return; 
                PlateSort ps = new PlateSort();
                listPlate = ps.getSortByHeight(listPlate);
                listPlate = ps.getSortByArea(listPlate);
                listPlate = ps.getSortByWidth(listPlate);
                //listPlate = ps.getSortByHWA(listPlate);
                listPlate = ps.getSortByHToWToA(listPlate);

                for (int i = 0; i < listPlate.Count; i++)
                {
                    signY = signY - listPlate[i].Bound.Height;
                    listPlate[i] = new MoveOper().MovePlate(listPlate[i], signX, signY);
                    signY = signY - 10;
                }
            }
        }


        /// <summary>
        /// 件号信息显示，用于测试前期处理是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < listPlate.Count; i++)
            //{
            //    Console.WriteLine("件号名称：{0},数量：{1} ，面积：{2},宽度：{3},权重和：{4}，宽度权重：{5}，长度权重：{6}，面积权重：{7}",
            //        listPlate[i].PlateName, listPlate[i].PlateCount, listPlate[i].Area, listPlate[i].Bound.Height,
            //        (listPlate[i].HeightPower + listPlate[i].WidthPower + listPlate[i].AreaPower),
            //        listPlate[i].HeightPower, listPlate[i].WidthPower, listPlate[i].AreaPower);
            //}
            //for (int i = 0; i < listSortByWidth.Count; i++)
            //{
            //    Console.WriteLine("件号名称：{0},数量：{1} ，面积：{2},长度：{3}",
            //        listSortByWidth[i].PlateName, listSortByWidth[i].PlateCount, listSortByWidth[i].Area, listSortByWidth[i].Bound.Width);
            //}
            //for (int i = 0; i < listSortByArea.Count; i++)
            //{
            //    Console.WriteLine("件号名称：{0},数量：{1} ，面积：{2},宽度：{3}",
            //        listSortByArea[i].PlateName, listSortByArea[i].PlateCount, listSortByArea[i].Area, listSortByArea[i].Bound.Height);
            //}
            //float count = 11.0f/ 4;
            //Console.WriteLine("float：{0},int：{1} ",
            //        count, (int)count);
            //for (int i = 0; i < CADInterface.currentPlates.Count; i++)
            //{
            //    Console.WriteLine("模型ID：{0},面积：{1} ,Bound：{2}",
            //        CADInterface.currentPlates[i].ModelId, CADInterface.currentPlates[i].Area, CADInterface.currentPlates[i].Bound);
            //}
            //Random r = new Random();
            //for (int i = 0; i < 50; i++)
            //{
            //    string ss = r.NextDouble() + "::" + r.NextDouble();
            //    Console.WriteLine("{0}", ss);
            //}
        }


        /// <summary>
        /// 原材料输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            inputStock stockForm = new inputStock(this);
            stockForm.ShowDialog();
        }


        /// <summary>
        /// 开始排样
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (listPlate.Count <=0)
            {
                MessageBox.Show("请先加载需要排样的件号");
                return;
            }

            #region 检查原材料是否符合标准
            if (listStock.Count <= 0)
            {
                MessageBox.Show("请输入一定数量的原材料钢板");
                return;
            }
            else
            {
                //for (int i = 0; i < listStock.Count; i++)
                //{
                //    Console.WriteLine("编号：{0},数量：{1}",
                //    listStock[i].StockId, (listStock[i].Num - listStock[i].UseNum));
                //}

                bool haveStock = false;
                for (int i = 0;i< listStock.Count;i++)
                {
                    if (listStock[i].Num - listStock[i].UseNum > 0) {
                        haveStock = true;
                    }
                }
                if (!haveStock)
                {
                    MessageBox.Show("请输入一定数量的原材料钢板");
                    return;
                }
            }
            #endregion

            GeneForm geneFrom = new GeneForm(this);
            geneFrom.ShowDialog();

            #region 加载原材料钢板
            for (int i = 0; i < listStock.Count; i++)
            {
                if (listStock[i].Num - listStock[i].UseNum > 0)
                {
                    
                    #region 加载原材料钢板的时候，创建原材料钢板的面域以及逆时针循环的点集
                    for (int j = 0; j < listStock[i].StockForm.Count; j++)
                    {
                        listStock[i].StockForm[j].ShapeID = CADInterface.globalID;
                        CADInterface.globalID = CADInterface.globalID + 1;
                        CADInterface.currentShapes.Add(listStock[i].StockForm[j]);
                    }

                    BaseModel newStockModel = new AddOper().addModel(listStock[i].StockForm);
                    listStock[i].ListModel.Add(newStockModel);
                    CADInterface.currentPlates.Add(newStockModel);
                    CADInterface.nowStock = listStock[i];
                    newStockModel.Draw(CADInterface.bGrp.Graphics);
                    
                    ZoomOper zoom = new ShapeOper.ZoomOper();
                    zoom.zoomYuanCaiLiao(this.tableLayoutPanel1);

                    CADInterface.DrawShap();
                    #endregion
                    break;
                }
            }
            #endregion

            GeneSuanFa gene = new GeneSuanFa();
            NFPSuanFa nfp = new NFPSuanFa();
            
            #region 对读取的钢板件号进行遗传编码
            geneCode.AddRange(gene.createGeneCode(listPlate));
            #endregion

            //Console.WriteLine("种群大小：{0}", geneCode.Count);

            DateTime beforDT = System.DateTime.Now;

            PaiYangFangAn fangAn = nfp.createFirstFangAn(geneCode, CADInterface.nowStock, angleTest);

            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);

            Console.WriteLine("获取初始解的时间：{0}", ts.TotalSeconds);

            DateTime beforDT1 = System.DateTime.Now;

            fangAn = gene.getFinallyFangAn(geneCode,fangAn);

            DateTime afterDT1 = System.DateTime.Now;
            TimeSpan ts1 = afterDT1.Subtract(beforDT1);

            Console.WriteLine("获取最终解的时间：{0}", ts1.TotalSeconds);

            Console.WriteLine("获取最终解的利用率：{0}", fangAn.LiYouLv);

            #region 最终方案中已使用的基因编码，置为true
            for (int i = 0; i < fangAn.ListPlate.Count; i++)
            {
                for (int j = 0;j < geneCode.Count; j++)
                {
                    if (fangAn.ListPlate[i].Plate.InheritanceID == geneCode[j].InheritanceID)
                    {
                        geneCode[j].HadUsedGene = true;
                        break;
                    }
                }
            }
            #endregion
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            YuBan yuBan = new YuBan(this);
            yuBan.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            TestAngle inputAngle = new TestAngle(this);
            inputAngle.ShowDialog();
        }
    }
}
