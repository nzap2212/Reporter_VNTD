

using Reporter.BUS;
using Reporter.UI.services;

namespace Reporter.UI.components
{
    public class Bang4
    {
        private static Bang4 instance;
        public static Bang4 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bang4();
                }
                return instance;
            }
        }

        private Bang4() { }

        private DataGridView _dgvBang4;

        public void SetupBang4(DataGridView dgvBang4)
        {
            _dgvBang4 = dgvBang4;

            dgvBang4.AutoGenerateColumns = false;
            dgvBang4.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvBang4.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvBang4.AllowUserToAddRows = false;
            dgvBang4.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái
            dgvBang4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự co giãn cột

            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng khám", DataPropertyName = "PhongKham", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chỉ tiêu ngày", DataPropertyName = "ChiTieuNgay", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số ngày làm việc", DataPropertyName = "SoNgayLamViec", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tháng", DataPropertyName = "Thang", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So với kế hoạch", DataPropertyName = "TyLe", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng", DataPropertyName = "SoLuong", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ nhập viện", DataPropertyName = "TyLeNhapVien", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "KH TB/HS", DataPropertyName = "KeHoach_HS", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TB/HS BHYT", DataPropertyName = "TrungBinh_HS", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So sánh với chỉ tiêu", DataPropertyName = "SoSanhVoiChiTieu", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "KH TB/HS", DataPropertyName = "KeHoach_TB_HS", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TB/HS VP", DataPropertyName = "TrungBinh_HS_VP", ReadOnly = true });
            dgvBang4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So sánh với chỉ tiêu", DataPropertyName = "SoSanhVoiChiTieu_VP", ReadOnly = true });

            dgvBang4.CellEndEdit += DgvBang4_CellEndEdit;
            dgvBang4.DataSource = SoLieuPhongKhamKhoaKhamBenhBUS.Instance.KhoiTaoDuLieu();

            // Gắn sự kiện để tự động điều chỉnh chiều cao dòng
            dgvBang4.DataBindingComplete += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBang4);
            dgvBang4.SizeChanged += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBang4);

            // Gọi ngay khi khởi tạo
            ResizeRowsToFit.Instance.AutoResizeRow(dgvBang4);
        }

        private void DgvBang4_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_dgvBang4 == null || e.RowIndex < 0) return;
                int ChiTieuNgay = ConvertToInt.Instance.TryParseInt(_dgvBang4.Rows[e.RowIndex].Cells[2].Value);
                int Thang = ConvertToInt.Instance.TryParseInt(_dgvBang4.Rows[e.RowIndex].Cells[3].Value);
                int SoNgaylamViec = ConvertToInt.Instance.TryParseInt(_dgvBang4.Rows[e.RowIndex].Cells[4].Value);
                int SoLuong = ConvertToInt.Instance.TryParseInt(_dgvBang4.Rows[e.RowIndex].Cells[6].Value);
                int KH_HS = ConvertToInt.Instance.TryParseInt(_dgvBang4.Rows[e.RowIndex].Cells[8].Value);
                int TB_HS = ConvertToInt.Instance.TryParseInt(_dgvBang4.Rows[e.RowIndex].Cells[9].Value); 
                int KH_VP = ConvertToInt.Instance.TryParseInt(_dgvBang4.Rows[e.RowIndex].Cells[8].Value);
                int TB_VP = ConvertToInt.Instance.TryParseInt(_dgvBang4.Rows[e.RowIndex].Cells[9].Value);

                switch (e.ColumnIndex)
                {
                    case 2: // Cập nhật chỉ tiêu lượt khám
                    case 3:
                    case 4:
                        _dgvBang4.Rows[e.RowIndex].Cells[5].Value = Thang > 0 ? $"{Math.Floor(Thang * 100.0 / (ChiTieuNgay * SoNgaylamViec)):0.##}%" : "-";
                        break;

                    case 6:  // Cập nhật nhập viện
                        _dgvBang4.Rows[e.RowIndex].Cells[7].Value = SoLuong > 0 ? $"{Math.Floor(SoLuong * 100.0 / Thang):0.##}%" : "-";
                        break;

                    case 8: // Cập nhật chỉ tiêu tài chính đối tượng BHYT
                    case 9:
                        _dgvBang4.Rows[e.RowIndex].Cells[10].Value = TB_HS > 0 ? $"{Math.Floor(TB_HS * 100.0 / KH_HS):0.##}%" : "-";
                        break;

                    case 11: // cập nhật chỉ tiêu tài chính đối tượng vp
                    case 12:
                        _dgvBang4.Rows[e.RowIndex].Cells[13].Value = TB_VP > 0 ? $"{Math.Floor(TB_VP * 100.0 / KH_VP):0.##}%" : "-";
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
