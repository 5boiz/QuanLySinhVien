using QuanLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    partial class Controller
    {
        public void LoadDataToDataGridView(DataGridView view, BindingSource bindingSource)
        {
            view.DataSource = bindingSource;

        }

        public void Resetbinding()
        {
            bindingSourceStudent.DataSource = GetAllStudent();
            bindingSourceTeacher.DataSource = GetAllTeacher();
            bindingSourceStudent.ResetBindings(false);
            bindingSourceTeacher.ResetBindings(false);

        }
    }
}
