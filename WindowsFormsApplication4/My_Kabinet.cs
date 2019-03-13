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
    public partial class My_Kabinet : Form
    {
        public My_Kabinet()
        {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath oz = Terochka.BuildTransparencyPath(pictureBox10);
            pictureBox10.Region = new Region(oz);
        }

        private void My_Kabinet_Load(object sender, EventArgs e)
        {
            int x = 0;
            foreach (PictureBox pb in MagazinForm.tovary)
            {
                pb.Location = new Point(x, 50);
                Controls.Add(pb);
                x = x + pb.Size.Width;
            }
        }
    }
}
