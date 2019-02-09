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
    public partial class Ya_Terochka : Form
    {
        public Ya_Terochka()
        {
            InitializeComponent();
        }

        private void Магазин_Click(object sender, EventArgs e)
        {
            MagazinForm mf = new MagazinForm();
            mf.ShowDialog();
        }

        private void Тёрочка_Click(object sender, EventArgs e)
        {
            Terochka mv= new Terochka();
            mv.ShowDialog();
        }

        private void Мой_кабинет_Click(object sender, EventArgs e)
        {
            My_Kabinet ms = new My_Kabinet();
            ms.ShowDialog();
        }

        private void Скины_Click(object sender, EventArgs e)
        {
            Skins mk = new Skins();
            mk.ShowDialog();
        }

        private void Ya_Terochka_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Location = new Point(
                tableLayoutPanel1.Width - tableLayoutPanel1.Size.Width,
                tableLayoutPanel1.Height - tableLayoutPanel1.Size.Height);
        }
}

    }