using Reporter.BUS;
using Reporter.UI.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter.UI.components
{
    public class Bang7
    {
        private static Bang7? instance;
        public static Bang7 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bang7();
                }
                return instance;
            }
        }
        private Bang7() { }

        private DataGridView? _dgvBang7;

        public void SetupBang7(DataGridView dgvBang7)
        {
            _dgvBang7 = dgvBang7;
            dgvBang7.AutoGenerateColumns = false;
            dgvBang7.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvBang7.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvBang7.AllowUserToAddRows = false;
            dgvBang7.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái
            dgvBang7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự co giãn cột

            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT", ReadOnly = true, Width = 20 });
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Phòng khám yêu cầu", DataPropertyName = "PhongKham", ReadOnly = false});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Chỉ tiêu ngày", DataPropertyName = "ChiTieuNgay", ReadOnly = false});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số ngày làm việc", DataPropertyName = "SoNgayLamViec", ReadOnly = false});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tháng", DataPropertyName = "Thang", ReadOnly = false});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So với kế hoạch", DataPropertyName = "TyLe", ReadOnly = true});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng", DataPropertyName = "SoLuong", ReadOnly = false});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ nhập viện", DataPropertyName = "TyLeNhapVien", ReadOnly = true});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "KH TB/HS", DataPropertyName = "KeHoach_TB_HS", ReadOnly = false});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TB/HS", DataPropertyName = "TrungBinh_HS", ReadOnly = false});
            dgvBang7.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "So sánh với KH", DataPropertyName = "SoSanhVoiChiTieu", ReadOnly = true});

            dgvBang7.CellEndEdit += DgvBang7_CellEndEdit;
            dgvBang7.DataSource = SoLieuPhongKhamYeuCauBUS.Instance.KhoiTaoDuLieu();
            
            // Gắn sự kiện để tự động điều chỉnh chiều cao dòng
            dgvBang7.DataBindingComplete += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBang7);
            dgvBang7.SizeChanged += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBang7);

            // Gọi ngay khi khởi tạo
            ResizeRowsToFit.Instance.AutoResizeRow(dgvBang7);
        }

        private void DgvBang7_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_dgvBang7 == null) return;
                int ChiTieuNgay = ConvertToInt.Instance.TryParseInt(_dgvBang7.Rows[e.RowIndex].Cells[2].Value);
                int SoNgaylamViec = ConvertToInt.Instance.TryParseInt(_dgvBang7.Rows[e.RowIndex].Cells[3].Value);
                int Thang = ConvertToInt.Instance.TryParseInt(_dgvBang7.Rows[e.RowIndex].Cells[4].Value);
                int SoLuong = ConvertToInt.Instance.TryParseInt(_dgvBang7.Rows[e.RowIndex].Cells[6].Value);
                int KH_HS = ConvertToInt.Instance.TryParseInt(_dgvBang7.Rows[e.RowIndex].Cells[8].Value);
                int TB_HS = ConvertToInt.Instance.TryParseInt(_dgvBang7.Rows[e.RowIndex].Cells[9].Value);
                switch (e.ColumnIndex)
                {
                    case 2: // Cập nhật chỉ tiêu lượt khám
                    case 3:
                    case 4:
                        _dgvBang7.Rows[e.RowIndex].Cells[5].Value = Thang > 0 ? $"{Math.Floor(Thang * 100.0 / (ChiTieuNgay * SoNgaylamViec)):0.##}%" : "-";
                        break;

                    case 6:  // Cập nhật nhập viện
                        _dgvBang7.Rows[e.RowIndex].Cells[7].Value = SoLuong > 0 ? $"{Math.Floor(SoLuong * 100.0 / Thang):0.##}%" : "-";
                        break;

                    case 8: // Cập nhật chỉ tiêu tài chính đối tượng BHYT
                    case 9:
                        _dgvBang7.Rows[e.RowIndex].Cells[10].Value = TB_HS > 0 ? $"{Math.Floor(TB_HS * 100.0 / KH_HS):0.##}%" : "-";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
