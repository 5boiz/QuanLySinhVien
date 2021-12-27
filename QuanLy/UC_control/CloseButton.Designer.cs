
namespace QuanLy.UC_control
{
    partial class CloseButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThoat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.CheckedState.Parent = this.btnThoat;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.HoverState.Image = global::QuanLy.Properties.Resources.exit_100px;
            this.btnThoat.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThoat.HoverState.Parent = this.btnThoat;
            this.btnThoat.Image = global::QuanLy.Properties.Resources.delete_40px;
            this.btnThoat.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThoat.Location = new System.Drawing.Point(0, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PressedState.Parent = this.btnThoat;
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 8;
            // 
            // CloseButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThoat);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CloseButton";
            this.Size = new System.Drawing.Size(40, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnThoat;
    }
}
