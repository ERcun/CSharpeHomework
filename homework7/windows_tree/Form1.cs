using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //颜色集合
            List<Color> list = new List<Color>() { Color.Red, Color.Blue,Color.Pink,Color.Black };
            //下拉框绑定数据
            comboBox1.DataSource = list;
        }
        private Graphics graphics;
    
        double perl = 0.6;
        double per2 = 0.7;

        void drawCayleyTree(int n,double x0, double y0, double leng, double th,Pen pen,double th1)
        {
            if (n == 0) return;

            double xl = x0 + leng * Math.Cos(th);

            double yl = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, xl, yl,pen);

            drawCayleyTree(n - 1, xl, yl, perl * leng, th + th1,pen,th1);
            drawCayleyTree(n - 1, xl, yl, per2 * leng, th - th1, pen,th1);
        }

        void drawLine(double x0, double y0, double x1, double y1,Pen pen)
        {
            graphics.DrawLine(
            pen,
            (int)x0, (int)y0, (int)x1, (int)y1);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //判断是否为空
            if (graphics != null)
            {
                //清空画板
                graphics.Clear(Color.White);
            }
            //创建一个画板
            graphics = this.CreateGraphics();
            
            Color c = (Color)comboBox1.SelectedItem;
            Pen pen = new Pen(c);
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2, pen, ConvertDegreesToRadians(double.Parse(txt_du.Text)));
        }
        //角度换算弧度
        public static double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return (radians);
        }
    }
}
