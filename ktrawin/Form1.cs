using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktrawin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu nội dung của txtMaSP không rỗng
                bool isNotEmpty = !string.IsNullOrWhiteSpace(txtMaSP.Text);

                // Bật hoặc tắt các nút liên quan
                btLuu.Enabled = isNotEmpty; // Cho phép lưu nếu mã sản phẩm không rỗng
                btKLuu.Enabled = isNotEmpty; // Cho phép hủy nếu mã sản phẩm không rỗng

                // Nếu không có nội dung, tắt nút Sửa và Xóa
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    btSua.Enabled = false;
                    btXoa.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu xảy ra lỗi
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu nội dung của txtTenSP không rỗng
                bool isNotEmpty = !string.IsNullOrWhiteSpace(txtTenSP.Text);

                // Bật nút Lưu nếu tên sản phẩm không rỗng
                btLuu.Enabled = isNotEmpty;

                // Nếu trống, vô hiệu hóa các nút Sửa và Xóa
                if (!isNotEmpty)
                {
                    btSua.Enabled = false;
                    btXoa.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị ngày vừa chọn
                DateTime selectedDate = dtNgayNhap.Value;

                // Kiểm tra nếu ngày nhập lớn hơn ngày hiện tại
                if (selectedDate > DateTime.Now)
                {
                    // Hiển thị thông báo lỗi nếu ngày nhập không hợp lệ
                    MessageBox.Show("Ngày nhập không được lớn hơn ngày hiện tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Reset giá trị về ngày hiện tại
                    dtNgayNhap.Value = DateTime.Now;
                }
                else
                {
                    // Nếu hợp lệ, bật nút Lưu
                    btLuu.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu xảy ra lỗi
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiSP = cboLoaiSP.SelectedItem?.ToString(); // Lấy loại sản phẩm đã chọn

            if (!string.IsNullOrEmpty(loaiSP))
            {
                switch (loaiSP)
                {
                    case "Bánh quy":
                        MessageBox.Show("Bạn đã chọn Bánh quy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Kẹo dẻo":
                        MessageBox.Show("Bạn đã chọn Kẹo dẻo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Kẹo socola":
                        MessageBox.Show("Bạn đã chọn Kẹo socola.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Bánh bông lan":
                        MessageBox.Show("Bạn đã chọn Bánh bông lan.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }
            

        private void btThem_Click(object sender, EventArgs e)
        {


        }
    }
}

        

