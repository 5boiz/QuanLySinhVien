
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
    public partial class fQuanLySinhVien : Form
    {
        public fQuanLySinhVien()
        {
            InitializeComponent();
        }


        public fMain frm;
        public delegate void _deDongTab();
        public _deDongTab dongTab;

        private void fQuanLySinhVien_Load(object sender, EventArgs e)
        {
            
        }


        private void closeButton1_Click_1(object sender, EventArgs e)
        {
            dongTab();
        }
    }
}
