﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAAn
{
    
    public partial class FormChinh : Form
    {
        private Right right;
        private Form currentChildForm;
        public FormChinh(Right right)
        {
            this.right = right;
    
            InitializeComponent();
         
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiNhanSu());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlisinhvien());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Nganh_ChuyenNganh());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new PhanQuyen());
        }
    }
}
