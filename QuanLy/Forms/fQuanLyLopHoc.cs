
using QuanLy.UC_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class fQuanLyLopHoc : Form
    {
        public fQuanLyLopHoc()
        {
            InitializeComponent();
        }

        public fMain frm;
        public delegate void _deDongTab();
        public _deDongTab dongTab;


        private void fQuanLyLopHoc_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

       
        private void btnNapLai_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvLop_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            
        }



        private void closeButton1_Click(object sender, EventArgs e)
        {
            dongTab();
        }

    }
}
