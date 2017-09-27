//Gonzalo Manrique, September 26th 2017
//With this project I demostrate I know how to use timing effects with graphics and text

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Aries_Constellation
{
    public partial class AriesConstellation : Form
    {
        public AriesConstellation()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Graphics
            Graphics formGraphics = this.CreateGraphics();
            BackgroundImage = null;
            Pen drawPen = new Pen(Color.White, 5);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            ariesLabel.Dispose();
            Refresh();
            infoLabel.Dispose();
            Refresh();
            formGraphics.Clear(Color.Black);

            //Constellation Stars
            drawBrush.Color = Color.Yellow;
            Thread.Sleep(1250);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Blop_Mark_DiAngelo_79054334);
            player.Play();
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 35, 50, 5, 5);

            Thread.Sleep(500);
            player = new SoundPlayer(Properties.Resources.Blop_Mark_DiAngelo_79054334);
            player.Play();
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 190, 75, 5, 5);

            Thread.Sleep(500);
            player = new SoundPlayer(Properties.Resources.Blop_Mark_DiAngelo_79054334);
            player.Play();
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 255, 95, 5, 5);

            Thread.Sleep(500);
            player = new SoundPlayer(Properties.Resources.Blop_Mark_DiAngelo_79054334);
            player.Play();
            Thread.Sleep(100);
            formGraphics.FillEllipse(drawBrush, 280, 125, 5, 5);

            //Constellation Lines
            drawPen = new Pen(Color.White, 1);
            Thread.Sleep(750);
            formGraphics.DrawLine(drawPen, 36, 52, 191, 77);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 191, 76, 256, 96);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 256, 96, 281, 126);
            Thread.Sleep(750);

            //41 Ari Code
            drawBrush.Color = Color.RoyalBlue;
            Font drawFont = new Font("Charlemagne Std", 8, FontStyle.Regular);
            formGraphics.DrawString("41 Ari", drawFont, drawBrush, 40, 35);
            Thread.Sleep(500);

            //Hamal Code
            formGraphics.DrawString("Hamal", drawFont, drawBrush, 195, 55);
            Thread.Sleep(500);

            //Sheratan Code
            formGraphics.DrawString("Sheratan", drawFont, drawBrush, 245, 75);
            Thread.Sleep(500);

            //Mesarthim Code
            formGraphics.DrawString("Mesarthim", drawFont, drawBrush, 235, 140);
            Thread.Sleep(500);

            //Aries Code
            player = new SoundPlayer(Properties.Resources.Appear_KP_1137861048);
            player.Play();
            Thread.Sleep(500);
            drawBrush.Color = Color.Yellow;
            drawFont = new Font("Charlemagne Std", 30, FontStyle.Regular);
            formGraphics.DrawString("ARIES", drawFont, drawBrush, 50, 75);

            //Change Constellation Color
            drawBrush.Color = Color.White;
            formGraphics.FillEllipse(drawBrush, 35, 50, 5, 5);            
            formGraphics.DrawLine(drawPen, 36, 52, 191, 77);
            formGraphics.FillEllipse(drawBrush, 190, 75, 5, 5);
            formGraphics.DrawLine(drawPen, 191, 76, 256, 96);
            formGraphics.FillEllipse(drawBrush, 255, 95, 5, 5);
            formGraphics.DrawLine(drawPen, 256, 96, 281, 126);
            formGraphics.FillEllipse(drawBrush, 280, 125, 5, 5);

            //Change Constellation Color 2
            Thread.Sleep(1000);
            drawPen.Color = Color.RoyalBlue;
            drawBrush.Color = Color.RoyalBlue;
            formGraphics.FillEllipse(drawBrush, 35, 50, 5, 5);
            formGraphics.DrawLine(drawPen, 36, 52, 191, 77);
            formGraphics.FillEllipse(drawBrush, 190, 75, 5, 5);
            formGraphics.DrawLine(drawPen, 191, 76, 256, 96);
            formGraphics.FillEllipse(drawBrush, 255, 95, 5, 5);
            formGraphics.DrawLine(drawPen, 256, 96, 281, 126);
            formGraphics.FillEllipse(drawBrush, 280, 125, 5, 5);

            //Change Names Color 2
            drawFont = new Font("Charlemagne Std", 8, FontStyle.Regular);
            drawBrush.Color = Color.White;
            formGraphics.TranslateTransform(40, 35);
            formGraphics.DrawString("41 Ari", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(195, 55);
            formGraphics.DrawString("Hamal", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(245, 75);
            formGraphics.DrawString("Sheratan", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(235, 140);
            formGraphics.DrawString("Mesarthim", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            //Change Constellation Color 2
            Thread.Sleep(1000);
            drawPen.Color = Color.White;
            drawBrush.Color = Color.White;
            formGraphics.FillEllipse(drawBrush, 35, 50, 5, 5);
            formGraphics.DrawLine(drawPen, 36, 52, 191, 77);
            formGraphics.FillEllipse(drawBrush, 190, 75, 5, 5);
            formGraphics.DrawLine(drawPen, 191, 76, 256, 96);
            formGraphics.FillEllipse(drawBrush, 255, 95, 5, 5);
            formGraphics.DrawLine(drawPen, 256, 96, 281, 126);
            formGraphics.FillEllipse(drawBrush, 280, 125, 5, 5);

            //Change Text Color 3
            drawFont = new Font("Charlemagne Std", 8, FontStyle.Regular);
            drawBrush.Color = Color.RoyalBlue;
            formGraphics.TranslateTransform(40, 35);
            formGraphics.DrawString("41 Ari", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(195, 55);
            formGraphics.DrawString("Hamal", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(245, 75);
            formGraphics.DrawString("Sheratan", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            formGraphics.TranslateTransform(235, 140);
            formGraphics.DrawString("Mesarthim", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            //Information Text Code
            //Aries is one of the constellations of the zodiac. It is located in the northern celestial hemisphere between Pisces to the west and Taurus to the east. The name Aries is Latin for ram. It is one of the 48 constellations described by the 2nd century astronomer Ptolemy. 
            Thread.Sleep(1500);
            drawFont = new Font("Gentium Book Basic", 10, FontStyle.Regular);
            drawBrush.Color = Color.White;
            formGraphics.DrawString("Aries is one of the constellations of the zodiac. It is", drawFont, drawBrush, 15, 185);

            drawFont = new Font("Gentium Book Basic", 10, FontStyle.Regular);
            formGraphics.DrawString("located in the northern celestial hemisphere between", drawFont, drawBrush, 10, 200);

            drawFont = new Font("Gentium Book Basic", 10, FontStyle.Regular);
            formGraphics.DrawString("Pisces to the west and Taurus to the east.", drawFont, drawBrush, 10, 215);

            drawFont = new Font("Gentium Book Basic", 10, FontStyle.Regular);
            formGraphics.DrawString("The name Aries is Latin for ram. It is one of the 48 cons-", drawFont, drawBrush, 10, 230);

            drawFont = new Font("Gentium Book Basic", 10, FontStyle.Regular);
            formGraphics.DrawString("tellations described by the astronomer Ptolemy.", drawFont, drawBrush, 10, 245);
  
            

        }

    }
}
