
using QuanLy.Models;
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
    public partial class ClassTab : Form
    {
        public ClassTab()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;


            Static.controller.LoadDataToDataGridView(dgvClass, Static.controller.bindingSourceClass);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateClassForm createClassForm = new CreateClassForm();
            createClassForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvClass.SelectedRows[0];
            string ID = row.Cells[0].Value.ToString();
            Class classs = Static.controller.GetClassByID(ID);
            if (classs == null)
            {
                MessageBox.Show("Có lỗi!!!! Lớp không tồn tại.");
                return;
            }
            EditClassForm editClassForm = new EditClassForm(classs);
            editClassForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvClass.SelectedRows[0];

            string ID = row.Cells[0].Value.ToString();

            if (ID == null)
            {
                MessageBox.Show("Có lỗi!!!! Cần chọn lớp để xóa.");
                return;
            }
            if (!Static.controller.IsClassEmpty(ID))
            {
                MessageBox.Show("Lớp này đang có người học, không thể xóa.");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc xóa lớp [" + Static.controller.GetClassByID(ID).TenLop + "] không!!!", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Static.controller.DeleteClass(ID);
                MessageBox.Show("Xóa lớp thành công.");
            }
        }

        private void btnCloseTab_Load(object sender, EventArgs e)
        {
            
        }
    }
}
