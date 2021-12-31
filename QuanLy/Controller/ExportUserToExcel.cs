using QuanLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace QuanLy
{
   
    partial class Controller
    {
        public void ExportUserToExcel(DataGridView dataGridView)
        {
            DateTime time = DateTime.Now;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "Excel Sheet|*.xls;*.xlsx|All Files(*.*)|*.*";
            saveFileDialog.FileName = String.Format("Result-{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}.xls", time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook workbook = xlApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = null;

                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Test";

                worksheet.Cells[1, 1] = "ID";
                worksheet.Cells[1, 2] = "Họ tên";
                worksheet.Cells[1, 3] = "Lớp";
                worksheet.Cells[1, 4] = "Giới tính";
                worksheet.Cells[1, 5] = "Địa chỉ";
                worksheet.Cells[1, 6] = "Tài khoản";
                worksheet.Cells[1, 7] = "Mật khẩu";
                worksheet.Cells[1, 8] = "Loại người dùng";

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    worksheet.Cells[i + 2, 1] = dataGridView.Rows[i].Cells["ID"].Value;
                    worksheet.Cells[i + 2, 2] = dataGridView.Rows[i].Cells["HoTen"].Value;
                    worksheet.Cells[i + 2, 3] = dataGridView.Rows[i].Cells["Lop"].Value;
                    worksheet.Cells[i + 2, 4] = dataGridView.Rows[i].Cells["GioiTinh"].Value;
                    worksheet.Cells[i + 2, 5] = dataGridView.Rows[i].Cells["Diachi"].Value;
                    worksheet.Cells[i + 2, 6] = dataGridView.Rows[i].Cells["TenTaiKhoan"].Value;
                    worksheet.Cells[i + 2, 7] = dataGridView.Rows[i].Cells["MatKhau"].Value;
                    worksheet.Cells[i + 2, 8] = ((LoaiNguoiDung)dataGridView.Rows[i].Cells["LoaiTaiKhoan"].Value).ToString();
                }

                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                xlApp.Quit();
            }
        }
    }
}
