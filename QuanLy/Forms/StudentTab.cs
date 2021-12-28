
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
    public partial class StudentTab : Form
    {
        public StudentTab()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;

            Static.controller.LoadDataToDataGridView(dgvStudent, Static.controller.bindingSourceStudent);
        }



        private void fQuanLySinhVien_Load(object sender, EventArgs e)
        {
            
        }


        private void closeButton1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
