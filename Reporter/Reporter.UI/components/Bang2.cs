using Reporter.BUS;
using Reporter.UI.services;

namespace Reporter.UI.components
{
    public class Bang2
    {
        private static Bang2 instance;
        public static Bang2 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bang2();
                }
                return instance;
            }
        }

        private Bang2() { }

        private DataGridView _dgvKetQuaNoiTru;
        public void SetupBang2(DataGridView dgvKetQuaNoiTru)
        {
            _dgvKetQuaNoiTru = dgvKetQuaNoiTru;
            dgvKetQuaNoiTru.AutoGenerateColumns = false;
            dgvKetQuaNoiTru.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvKetQuaNoiTru.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvKetQuaNoiTru.AllowUserToAddRows = false;
            dgvKetQuaNoiTru.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái
            dgvKetQuaNoiTru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự co giãn cột

            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TT", DataPropertyName = "STT", Width = 50, ReadOnly = true });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên khoa", DataPropertyName = "TenKhoa", Width = 250, ReadOnly = true });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kế hoạch", DataPropertyName = "KeHoach_chitieu", Width = 70, ReadOnly = false });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thực hiện", DataPropertyName = "ThucHien_chitieu", Width = 100 });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So với kế hoạch", DataPropertyName = "TyLe_chitieu", Width = 70, ReadOnly = false });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kế hoạch", DataPropertyName = "KeHoach_CongSuat", Width = 70, ReadOnly = false });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thực hiện", DataPropertyName = "ThucHien_CongSuat", Width = 100 });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So với kế hoạch", DataPropertyName = "TyLe_CongSuat", Width = 70, ReadOnly = false });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kế hoạch", DataPropertyName = "KeHoach_BenhAn", Width = 70, ReadOnly = false });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thực hiện", DataPropertyName = "ThucHien_BenhAn", Width = 100 });
            dgvKetQuaNoiTru.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So với kế hoạch", DataPropertyName = "TyLe_BenhAn", Width = 70, ReadOnly = false });

            dgvKetQuaNoiTru.CellEndEdit += DgvBang2_CellEndEdit;
            dgvKetQuaNoiTru.DataSource = KetQuaNoiTruThangBUS.Instance.KhoiTaoDuLieu();

            // Gắn sự kiện để tự động điều chỉnh chiều cao dòng
            dgvKetQuaNoiTru.DataBindingComplete += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaNoiTru);
            dgvKetQuaNoiTru.SizeChanged += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaNoiTru);

            // Gọi ngay khi khởi tạo
            ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaNoiTru);
        }

        private void DgvBang2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_dgvKetQuaNoiTru == null || e.RowIndex < 0) return; // Kiểm tra bảng hợp lệ

                switch (e.ColumnIndex)
                {
                    case 2: // Cập nhật tỷ lệ chỉ tiêu
                    case 3:
                        int keHoach1 = ConvertToInt.Instance.TryParseInt(_dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[2].Value);
                        int thucHien1 = ConvertToInt.Instance.TryParseInt(_dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[3].Value);
                        _dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[4].Value = keHoach1 > 0 ? $"{Math.Floor(thucHien1 * 100.0 / keHoach1):0.##}%" : "-";
                        break;

                    case 5: // Cập nhật tỷ lệ công suất
                    case 6:
                        int keHoach2 = ConvertToInt.Instance.TryParseInt(_dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[5].Value);
                        int thucHien2 = ConvertToInt.Instance.TryParseInt(_dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[6].Value);
                        _dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[7].Value = keHoach2 > 0 ? $"{Math.Floor(thucHien2 * 100.0 / keHoach2):0.##}%" : "-";
                        break;

                    case 8: // Cập nhật tỷ lệ bệnh án
                    case 9:
                        int keHoach3 = ConvertToInt.Instance.TryParseInt(_dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[8].Value);
                        int thucHien3 = ConvertToInt.Instance.TryParseInt(_dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[9].Value);
                        _dgvKetQuaNoiTru.Rows[e.RowIndex].Cells[10].Value = keHoach3 > 0 ? $"{Math.Floor(thucHien3 * 100.0 / keHoach3):0.##}%" : "-";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
