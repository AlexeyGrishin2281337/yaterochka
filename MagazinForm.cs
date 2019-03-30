﻿using System;
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
        public static List<PictureBox> tovary = new List<PictureBox>();
        public static List<PictureBox> vse_tovary = new List<PictureBox>();

        public MagazinForm()
        {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath oz = Terochka.BuildTransparencyPath(pictureBox10);
            pictureBox10.Region = new Region(oz);
        }

        private void MagazinForm_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(label2);
            this.Controls.Add(productsPanel1);
            MagazinForm_Resize(null, null);

            vse_tovary.Add(pictureBox1);
            vse_tovary.Add(pictureBox2);
            vse_tovary.Add(pictureBox3);
            vse_tovary.Add(pictureBox4);
        }

        /// <summary>
        /// 1 страница
        /// </summary>
        private void page1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(label2);
            this.Controls.Add(productsPanel1);
            MagazinForm_Resize(null, null);
        }

        /// <summary>
        /// 2 страница
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(label2);
            this.Controls.Add(productsPanel2);
            MagazinForm_Resize(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(label2);
            this.Controls.Add(productsPanel3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox10);
            this.Controls.Add(label2);
            this.Controls.Add(productsPanel2);
        }

        private void productsPanel3_Click(object sender, EventArgs e)
        {

        }

        private void productsPanel4_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (tovary.Contains(pb) == false)
            {
                tovary.Add(pb);
            }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}