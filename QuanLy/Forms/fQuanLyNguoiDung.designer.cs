
namespace QuanLy
{
    partial class fQuanLySinhVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnbtnNguoiDung = new System.Windows.Forms.Panel();
            this.txtTimKiemNguoiDung = new Guna.UI.WinForms.GunaTextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNapLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.closeButton1 = new QuanLy.UC_control.CloseButton();
            this.dgvNguoiDung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.pnbtnNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 589);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 23);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.pnbtnNguoiDung);
            this.panel2.Controls.Add(this.closeButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 70);
            this.panel2.TabIndex = 9;
            // 
            // pnbtnNguoiDung
            // 
            this.pnbtnNguoiDung.Controls.Add(this.txtTimKiemNguoiDung);
            this.pnbtnNguoiDung.Controls.Add(this.btnIn);
            this.pnbtnNguoiDung.Controls.Add(this.btnThem);
            this.pnbtnNguoiDung.Controls.Add(this.btnNapLai);
            this.pnbtnNguoiDung.Controls.Add(this.btnSua);
            this.pnbtnNguoiDung.Controls.Add(this.btnXoa);
            this.pnbtnNguoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnbtnNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.pnbtnNguoiDung.Name = "pnbtnNguoiDung";
            this.pnbtnNguoiDung.Size = new System.Drawing.Size(744, 70);
            this.pnbtnNguoiDung.TabIndex = 10;
            // 
            // txtTimKiemNguoiDung
            // 
            this.txtTimKiemNguoiDung.BaseColor = System.Drawing.Color.White;
            this.txtTimKiemNguoiDung.BorderColor = System.Drawing.Color.Silver;
            this.txtTimKiemNguoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNguoiDung.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimKiemNguoiDung.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.txtTimKiemNguoiDung.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimKiemNguoiDung.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNguoiDung.Location = new System.Drawing.Point(380, 22);
            this.txtTimKiemNguoiDung.Name = "txtTimKiemNguoiDung";
            this.txtTimKiemNguoiDung.PasswordChar = '\0';
            this.txtTimKiemNguoiDung.SelectedText = "";
            this.txtTimKiemNguoiDung.Size = new System.Drawing.Size(234, 31);
            this.txtTimKiemNguoiDung.TabIndex = 14;
            this.txtTimKiemNguoiDung.Tag = "";
            // 
            // btnIn
            // 
            this.btnIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIn.Location = new System.Drawing.Point(637, 16);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(81, 40);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "In DSSV";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Location = new System.Drawing.Point(20, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnNapLai
            // 
            this.btnNapLai.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNapLai.Location = new System.Drawing.Point(263, 16);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(75, 40);
            this.btnNapLai.TabIndex = 9;
            this.btnNapLai.Text = "Nạp lại";
            this.btnNapLai.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Location = new System.Drawing.Point(101, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Location = new System.Drawing.Point(182, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.Location = new System.Drawing.Point(897, 15);
            this.closeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(40, 40);
            this.closeButton1.TabIndex = 9;
            this.closeButton1.Click += new System.EventHandler(this.closeButton1_Click_1);
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AllowUserToAddRows = false;
            this.dgvNguoiDung.AllowUserToDeleteRows = false;
            this.dgvNguoiDung.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaSV,
            this.HoTen,
            this.Lop,
            this.Diachi,
            this.SDT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguoiDung.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNguoiDung.Location = new System.Drawing.Point(0, 70);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.ReadOnly = true;
            this.dgvNguoiDung.RowHeadersWidth = 51;
            this.dgvNguoiDung.RowTemplate.Height = 24;
            this.dgvNguoiDung.Size = new System.Drawing.Size(957, 519);
            this.dgvNguoiDung.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            this.Lop.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "DiaChi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // fQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 612);
            this.Controls.Add(this.dgvNguoiDung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQuanLySinhVien";
            this.Text = "QuanLySinhVien";
            this.Load += new System.EventHandler(this.fQuanLySinhVien_Load);
            this.panel2.ResumeLayout(false);
            this.pnbtnNguoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNguoiDung;
        private UC_control.CloseButton closeButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Panel pnbtnNguoiDung;
        private Guna.UI.WinForms.GunaTextBox txtTimKiemNguoiDung;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNapLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        //private UC_control.MenuButton menuButton1;
        //private UC_control.MenuButton menuButton2;
        //private UC_control.MenuButton menuButton3;
    }
}