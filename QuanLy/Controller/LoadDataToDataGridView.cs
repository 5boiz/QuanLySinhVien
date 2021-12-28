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

        public void Resetbinding(BindingSource bindingSource)
        {
            bindingSource.ResetBindings(false);

        }
    }
}
