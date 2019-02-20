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
    public partial class Skins : Form
    {
        public Skins()
        {
            InitializeComponent();
        }

        private void Skins_Load(object sender, EventArgs e)
        {

            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath gp = Terochka.BuildTransparencyPath(pictureBox1);
            pictureBox1.Region = new Region(gp);

            System.Drawing.Drawing2D.GraphicsPath blueTerkaOblast = Terochka.BuildTransparencyPath(blueTerkaPictureBox);
            blueTerkaPictureBox.Region = new Region(blueTerkaOblast);
        }
    }
}
