using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aries_Constellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Graphics
            Graphics formGraphics = this.CreateGraphics();
            BackgroundImage = null;
            Pen drawPen = new Pen(Color.White, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            AriesLabel.Dispose();
            Refresh();
            formGraphics.Clear(Color.Black);

            //Constellation
            formGraphics.FillEllipse(drawBrush, 35, 50, 5, 5);
            formGraphics.FillEllipse(drawBrush, 185, 55, 5, 5);
            formGraphics.FillEllipse(drawBrush, 325, 75, 5, 5);
            formGraphics.FillEllipse(drawBrush, 355, 85, 5, 5);
            formGraphics.FillEllipse(drawBrush, 25, 25, 5, 5);
            //label1
        }
    }
}
