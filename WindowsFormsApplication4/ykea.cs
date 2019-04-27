using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class ykea6t : Form
    {
        public static List<PictureBox> vse_mebel = new List<PictureBox>();
        public ykea6t()
        {
            InitializeComponent();
            //vse_tovary.Clear();
            int x = 0;
            DirectoryInfo dir = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath) +
                "\\mebel\\");
            foreach (FileInfo fl in dir.GetFiles())
            {
                if (fl.Extension == ".jpg")
                {
                    PictureBox pb = new PictureBox();
                    pb.Location = new Point(x,100);
                    pb.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) +
                "\\mebel\\" + fl.Name);
                    pb.Size = new Size(150, 100);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pb.Click += new System.EventHandler(pictureBox3_Click);

                    vse_mebel.Add(pb);
                    /*if (vse_tovary.Count <= 4)
                    {
                        productsPanel1.Controls.Add(pb);
                    }
                    else if (vse_tovary.Count <= 8)
                    {
                        productsPanel2.Controls.Add(pb);
                    }
                    else if (vse_tovary.Count <= 16)
                    {
                        productsPanel3.Controls.Add(pb);
                    }*/
                    this.Controls.Add(pb);

                    x = x + 140;

                    /*if (vse_tovary.Count % 4 == 0)
                    {
                        x = x - 560;
                    }*/
                }
            }

            System.Drawing.Drawing2D.GraphicsPath oz = Terochka.BuildTransparencyPath(pictureBox10);
            pictureBox10.Region = new Region(oz);
        }

        private void ykea_Load(object sender, EventArgs e)
        {
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
        }
    }
}
