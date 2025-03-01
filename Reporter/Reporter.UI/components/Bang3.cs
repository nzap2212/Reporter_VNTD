using Reporter.BUS;
using Reporter.UI.services;

namespace Reporter.UI.components
{
    public class Bang3
    {
        private static Bang3 instance;
        public static Bang3 Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Bang3();
                }
                return instance;
            }
        }
        private Bang3() { }

        private DataGridView _dgvKetQuaThucHien;
        
        public void SetupBang3(DataGridView dgvKetQuaThucHienDV)
        {
            _dgvKetQuaThucHien = dgvKetQuaThucHienDV;
            dgvKetQuaThucHienDV.AutoGenerateColumns = false;
            dgvKetQuaThucHienDV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvKetQuaThucHienDV.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvKetQuaThucHienDV.AllowUserToAddRows = false;

            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TT", DataPropertyName = "STT", Width = 50, ReadOnly = true });
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên khoa", DataPropertyName = "TenKhoa", ReadOnly = true });
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng", DataPropertyName = "Tong", ReadOnly = true });
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chọn PTV", DataPropertyName = "ChonPTV", ReadOnly = false });
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mổ sớm", DataPropertyName = "MoSom", ReadOnly = false });
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Gói PT", DataPropertyName = "GoiPT", ReadOnly = false });

            dgvKetQuaThucHienDV.CellEndEdit += DgvKetQuaThucHienDichVu_CellEndEdit;
            dgvKetQuaThucHienDV.DataSource = KetQuaThucHienDichVuTheoYeuCauBUS.Instance.KhoiTaoDuLieu();

            // Gắn sự kiện để tự động điều chỉnh chiều cao dòng
            dgvKetQuaThucHienDV.DataBindingComplete += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaThucHienDV);
            dgvKetQuaThucHienDV.SizeChanged += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaThucHienDV);

            // Gọi ngay khi khởi tạo
            ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaThucHienDV);
        }

        private void DgvKetQuaThucHienDichVu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_dgvKetQuaThucHien == null) return; // Đảm bảo DataGridView hợp lệ
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5) // Chỉnh sửa cột "Kế hoạch" hoặc "Thực hiện"
            {
                try
                {
                    int chonPTV = ConvertToInt.Instance.TryParseInt(_dgvKetQuaThucHien.Rows[e.RowIndex].Cells[3].Value);
                    int moSom = ConvertToInt.Instance.TryParseInt(_dgvKetQuaThucHien.Rows[e.RowIndex].Cells[4].Value);
                    int goiPT = ConvertToInt.Instance.TryParseInt(_dgvKetQuaThucHien.Rows[e.RowIndex].Cells[5].Value);
                    _dgvKetQuaThucHien.Rows[e.RowIndex].Cells[2].Value = (chonPTV + moSom + goiPT).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
