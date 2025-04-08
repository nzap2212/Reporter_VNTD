using Reporter.BUS;
using Reporter.DTO;
using Reporter.UI.services;

namespace Reporter.UI.components
{
    public class Bang6
    {
        private static Bang6? instance;
        public static Bang6 Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Bang6();
                }
                return instance;
            }
        }
        private Bang6() { }

        private DataGridView? _dgvBang6;
        public void SetupBang6(DataGridView dgvBang6, string ngayvao, string ngayra)
        {
            _dgvBang6 = dgvBang6;

            dgvBang6.AutoGenerateColumns = false;
            dgvBang6.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvBang6.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvBang6.AllowUserToAddRows = false;
            dgvBang6.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái
            dgvBang6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự co giãn cột
                   
            dgvBang6.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khoa phòng", DataPropertyName = "PhongKham", ReadOnly = true });
            dgvBang6.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng số", DataPropertyName = "TongSoDenKham", ReadOnly = false });
            dgvBang6.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tháng", DataPropertyName = "TongSoNhapVien", ReadOnly = false });
            dgvBang6.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ nhập viện", DataPropertyName = "TyLeNhapVien", ReadOnly = true });
                   
            dgvBang6.CellEndEdit += DgvBang5_CellEndEdit;
            dgvBang6.DataSource = SoLieuPhongKhamCapCuuBUS.Instance.KhoiTaoDuLieu(ngayvao, ngayvao);
                   
            // Gắn sự kiện để tự động điều chỉnh chiều cao dòng
            dgvBang6.DataBindingComplete += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBang6);
            dgvBang6.SizeChanged += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBang6);

            // Gọi ngay khi khởi tạo
            ResizeRowsToFit.Instance.AutoResizeRow(dgvBang6);
        }

        private void DgvBang5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_dgvBang6 == null) return;
            int TongSoDenKham = ConvertToInt.Instance.TryParseInt(_dgvBang6.Rows[e.RowIndex].Cells[1].Value);
            int TongSoNhapVien = ConvertToInt.Instance.TryParseInt(_dgvBang6.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                try
                {
                    _dgvBang6.Rows[e.RowIndex].Cells[3].Value = (TongSoDenKham > 0 && TongSoNhapVien > 0) ? (TongSoNhapVien * 100 / TongSoDenKham) + "%" : "-";
                }
                catch (Exception ex)
                {
                    _dgvBang6.Rows[e.RowIndex].Cells[5].Value = "-"; // Nếu có lỗi chuyển đổi số, để trống
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
