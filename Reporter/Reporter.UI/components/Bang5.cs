using Reporter.BUS;
using Reporter.UI.services;

namespace Reporter.UI.components
{
    public class Bang5
    {
        private static Bang5? instance;
        public static Bang5 Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Bang5();
                }
                return instance;
            }
        }
        private Bang5() { }

        private DataGridView? _dgvBang5;
        public void SetupBang5(DataGridView dgvBang5)
        {
            _dgvBang5 = dgvBang5;

            dgvBang5.AutoGenerateColumns = false;
            dgvBang5.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvBang5.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvBang5.AllowUserToAddRows = false;
            dgvBang5.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái
            dgvBang5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự co giãn cột

            dgvBang5.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khoa phòng", DataPropertyName = "PhongKham", ReadOnly = true });
            dgvBang5.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "KH TB/HS", DataPropertyName = "KeHoach_TB_HS", ReadOnly = false });
            dgvBang5.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TB/HS BHYT", DataPropertyName = "TrungBinh_HS_BHYT", ReadOnly = false });
            dgvBang5.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So sánh với chỉ tiêu", DataPropertyName = "SoSanhVoiChiTieu_BHYT", ReadOnly = true });

            dgvBang5.CellEndEdit += DgvBang5_CellEndEdit;
            dgvBang5.DataSource = SoLieuPhongKhamNgoaiTruBUS.Instance.KhoiTaoDuLieu();

            // Gắn sự kiện để tự động điều chỉnh chiều cao dòng
            dgvBang5.DataBindingComplete += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBang5);
            dgvBang5.SizeChanged += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBang5);

            // Gọi ngay khi khởi tạo
            ResizeRowsToFit.Instance.AutoResizeRow(dgvBang5);
        }

        private void DgvBang5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_dgvBang5 == null) return;
            int KH_TB_HS = ConvertToInt.Instance.TryParseInt(_dgvBang5.Rows[e.RowIndex].Cells[1].Value);
            int TB_HS_BHYT = ConvertToInt.Instance.TryParseInt(_dgvBang5.Rows[e.RowIndex].Cells[2].Value);
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                try
                {
                    _dgvBang5.Rows[e.RowIndex].Cells[3].Value = (KH_TB_HS > 0 && TB_HS_BHYT > 0) ? (TB_HS_BHYT * 100 / KH_TB_HS) + "%" : "-";
                }
                catch (Exception ex)
                {
                    _dgvBang5.Rows[e.RowIndex].Cells[5].Value = "-"; // Nếu có lỗi chuyển đổi số, để trống
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
