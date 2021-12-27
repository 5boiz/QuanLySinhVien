using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy.UC_control
{
    public partial class CloseButton : UserControl
    {
        public CloseButton()
        {
            InitializeComponent();
            WireAllControls(this.Controls);
        }
        private void WireAllControls(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.Click += Control_Click;
                if (control.HasChildren)
                {
                    WireAllControls(control.Controls);
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }
    }


}
