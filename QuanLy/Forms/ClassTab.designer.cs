
namespace QuanLy
{
    partial class ClassTab
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
            this.pnbtnLopHoc = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNapLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.closeButton1 = new QuanLy.UC_control.CloseButton();
            this.dgvLop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaoVienCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.pnbtnLopHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 23);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.pnbtnLopHoc);
            this.panel2.Controls.Add(this.closeButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 70);
            this.panel2.TabIndex = 9;
            // 
            // pnbtnLopHoc
            // 
            this.pnbtnLopHoc.Controls.Add(this.btnThem);
            this.pnbtnLopHoc.Controls.Add(this.btnNapLai);
            this.pnbtnLopHoc.Controls.Add(this.btnSua);
            this.pnbtnLopHoc.Controls.Add(this.btnXoa);
            this.pnbtnLopHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnbtnLopHoc.Location = new System.Drawing.Point(0, 0);
            this.pnbtnLopHoc.Name = "pnbtnLopHoc";
            this.pnbtnLopHoc.Size = new System.Drawing.Size(483, 70);
            this.pnbtnLopHoc.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Location = new System.Drawing.Point(20, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNapLai
            // 
            this.btnNapLai.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNapLai.Location = new System.Drawing.Point(263, 15);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(75, 40);
            this.btnNapLai.TabIndex = 6;
            this.btnNapLai.Text = "Nạp lại";
            this.btnNapLai.UseVisualStyleBackColor = true;
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Location = new System.Drawing.Point(101, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Location = new System.Drawing.Point(182, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton1.Location = new System.Drawing.Point(890, 15);
            this.closeButton1.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(40, 40);
            this.closeButton1.TabIndex = 6;
            this.closeButton1.Click += new System.EventHandler(this.closeButton1_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTenLop,
            this.colKhoa,
            this.GiaoVienCN,
            this.colNamHoc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLop.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLop.Location = new System.Drawing.Point(0, 70);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(950, 507);
            this.dgvLop.TabIndex = 10;
            this.dgvLop.Click += new System.EventHandler(this.dgvLop_Click);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colTenLop
            // 
            this.colTenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.MinimumWidth = 6;
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.ReadOnly = true;
            // 
            // colKhoa
            // 
            this.colKhoa.DataPropertyName = "Khoa";
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            this.colKhoa.Width = 200;
            // 
            // GiaoVienCN
            // 
            this.GiaoVienCN.DataPropertyName = "GiaoVienCN";
            this.GiaoVienCN.HeaderText = "Giáo Viên phụ trách";
            this.GiaoVienCN.MinimumWidth = 6;
            this.GiaoVienCN.Name = "GiaoVienCN";
            this.GiaoVienCN.ReadOnly = true;
            this.GiaoVienCN.Width = 125;
            // 
            // colNamHoc
            // 
            this.colNamHoc.DataPropertyName = "NamHoc";
            this.colNamHoc.HeaderText = "Năm học";
            this.colNamHoc.MinimumWidth = 6;
            this.colNamHoc.Name = "colNamHoc";
            this.colNamHoc.ReadOnly = true;
            this.colNamHoc.Width = 125;
            // 
            // fQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQuanLyLopHoc";
            this.Text = "fQuanLyLop";
            this.Load += new System.EventHandler(this.fQuanLyLopHoc_Load);
            this.panel2.ResumeLayout(false);
            this.pnbtnLopHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLop;
        private UC_control.CloseButton closeButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaoVienCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamHoc;
        private System.Windows.Forms.Panel pnbtnLopHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNapLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}