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
    public partial class MagazinForm : Form
    {
        public MagazinForm()
        {
            InitializeComponent();
        }

        private void MagazinForm_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel1);
            MagazinForm_Resize(null, null);
        }

        /// <summary>
        /// 1 страница
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel1);
            MagazinForm_Resize(null, null);
        }

        /// <summary>
        /// 2 страница
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel2);
            MagazinForm_Resize(null, null);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel2);
        }

        private void productsPanel3_Click(object sender, EventArgs e)
        {

        }

        private void productsPanel4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void productsPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productsPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(productsPanel2);
        }

        private void MagazinForm_Resize(object sender, EventArgs e)
        {
            productsPanel1.Height = this.Height - 100;
            productsPanel2.Height = this.Height - 100;
            productsPanel3.Height = this.Height - 100;

            buttonDalshe1.Location = new Point(
                productsPanel1.Width - buttonDalshe1.Size.Width, 
                productsPanel1.Height - buttonDalshe1.Size.Height);
            buttonDalshe2.Location = new Point(
                productsPanel2.Width - buttonDalshe2.Size.Width, 
                productsPanel2.Height - buttonDalshe2.Size.Height);
            buttonNazad2.Location = new Point(
                0,
                productsPanel2.Height - buttonNazad2.Size.Height);
        }
    }
}
