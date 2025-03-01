using System;
using System.Drawing;
using System.Windows.Forms;
using Reporter.BUS;
using Reporter.UI.services;

namespace Reporter.UI.Components
{
    public class Bang1
    {
        private static Bang1 instance;
        public static Bang1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bang1();
                }
                return instance;
            }
        }

        private Bang1() { }

        private DataGridView _dgvBaoCao;

        public void SetupDataGridView(DataGridView dgvBaoCao)
        {
            _dgvBaoCao = dgvBaoCao;

            dgvBaoCao.AutoGenerateColumns = false;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvBaoCao.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.RowHeadersVisible = false; // Ẩn cột số thứ tự bên trái
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự co giãn cột

            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "TT", DataPropertyName = "STT", Width = 50, ReadOnly = true });
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hoạt động", DataPropertyName = "HoatDong", Width = 250, ReadOnly = true });
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đơn vị", DataPropertyName = "DonVi", Width = 70, ReadOnly = false });
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kế hoạch", DataPropertyName = "KeHoach", Width = 100 });
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thực hiện", DataPropertyName = "ThucHien", Width = 100 });
            dgvBaoCao.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỷ lệ thực hiện/KH", DataPropertyName = "TyLeThucHien", Width = 120, ReadOnly = true });

            dgvBaoCao.CellEndEdit += DgvBaoCao_CellEndEdit;
            dgvBaoCao.DataSource = KhamChuaBenhToanVienBUS.Instance.KhoiTaoDuLieu();

            // Gắn sự kiện để tự động điều chỉnh chiều cao dòng
            dgvBaoCao.DataBindingComplete += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBaoCao);
            dgvBaoCao.SizeChanged += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvBaoCao);

            // Gọi ngay khi khởi tạo
            ResizeRowsToFit.Instance.AutoResizeRow(dgvBaoCao);
        }

        // Cập nhật lại cột tỷ lệ sau khi chỉnh sửa
        private void DgvBaoCao_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_dgvBaoCao == null) return;
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4) // Chỉnh sửa cột "Kế hoạch" hoặc "Thực hiện"
            {
                try
                {
                    int keHoach = Convert.ToInt32(_dgvBaoCao.Rows[e.RowIndex].Cells[3].Value);
                    int thucHien = Convert.ToInt32(_dgvBaoCao.Rows[e.RowIndex].Cells[4].Value);
                    _dgvBaoCao.Rows[e.RowIndex].Cells[5].Value = keHoach > 0 ? (thucHien * 100 / keHoach) + "%" : "-";
                }
                catch
                {
                    _dgvBaoCao.Rows[e.RowIndex].Cells[5].Value = "-"; // Nếu có lỗi chuyển đổi số, để trống
                }
            }
        }

        
    }
}
