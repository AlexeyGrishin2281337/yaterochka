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
            Controls.Clear();
            Controls.Add(saloLabel);
            Controls.Add(button1);
            Controls.Add(pictureBox10);
            saloLabel.Text = "салоcoin : " + MagazinForm.money.ToString();
            int x = 0;
            foreach (PictureBox pb in ykea.kypi_mebel)
            {
                pb.Location = new Point(x, 50);
                Controls.Add(pb);
                x = x + pb.Size.Width;
            }
        }

        private void saloLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ykea ym = new ykea();
            ym.ShowDialog();
            My_Kabinet_Load(sender, e);
        }
    }
}
