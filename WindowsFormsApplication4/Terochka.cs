using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Terochka : Form
    {
        Random rnd = new Random();
        public Terochka()
        {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath gp = BuildTransparencyPath(pictureBox1);
            pictureBox1.Region = new Region(gp);

            System.Drawing.Drawing2D.GraphicsPath gp2 = BuildTransparencyPath(pictureBox2);
            pictureBox2.Region = new Region(gp2);

            System.Drawing.Drawing2D.GraphicsPath gp3 = BuildTransparencyPath(pictureBox3);
            pictureBox3.Region = new Region(gp3);
        }
        public static System.Drawing.Drawing2D.GraphicsPath BuildTransparencyPath(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            Image im = pb.Image;
            int x;
            int y;
            if(pb.Image==null)
            {
                return gp;
            }
            Bitmap bmp = new Bitmap(im);
            Color mask = bmp.GetPixel(0, 0);

            for (x = 0; x <= pb.Size.Width - 1; x++)
            {
                for (y = 0; y <= pb.Size.Height - 1; y++)
                {
                    int newX = x * im.Size.Width / pb.Size.Width;
                    int newY = y * im.Size.Height / pb.Size.Height;

                    if (!bmp.GetPixel(newX, newY).Equals(mask))
                    {                                                
                        gp.AddRectangle(new Rectangle(
                            x,
                            y, 1, 1));
                    }
                }
            }
            bmp.Dispose();
            return gp;
        }  

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(
                pictureBox1.Location.X + pictureBox1.Size.Width - 200,
                pictureBox2.Location.Y + (rnd.Next() % 7) - (rnd.Next() % 7));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Terochka_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
