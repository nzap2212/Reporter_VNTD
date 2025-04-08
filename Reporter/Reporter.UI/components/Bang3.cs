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
            
            // Thiết lập style hiện đại
            dgvKetQuaThucHienDV.BorderStyle = BorderStyle.None;
            dgvKetQuaThucHienDV.BackgroundColor = Color.White;
            dgvKetQuaThucHienDV.GridColor = Color.FromArgb(230, 230, 230);
            dgvKetQuaThucHienDV.RowHeadersVisible = false;
            dgvKetQuaThucHienDV.AllowUserToAddRows = false;
            dgvKetQuaThucHienDV.AllowUserToDeleteRows = false;
            dgvKetQuaThucHienDV.AllowUserToResizeRows = false;
            dgvKetQuaThucHienDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQuaThucHienDV.MultiSelect = false;
            
            // Thiết lập font
            dgvKetQuaThucHienDV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKetQuaThucHienDV.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            
            // Thiết lập màu sắc
            dgvKetQuaThucHienDV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvKetQuaThucHienDV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKetQuaThucHienDV.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvKetQuaThucHienDV.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            
            // Thiết lập chiều cao header
            dgvKetQuaThucHienDV.ColumnHeadersHeight = 40;
            dgvKetQuaThucHienDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            
            // Thiết lập style cho các dòng lẻ/chẵn
            dgvKetQuaThucHienDV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            
            // Thiết lập các cột
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { 
                HeaderText = "TT", 
                DataPropertyName = "STT", 
                Width = 50, 
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { 
                HeaderText = "Tên khoa", 
                DataPropertyName = "TenKhoa", 
                Width = 200,
                ReadOnly = true 
            });
            
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { 
                HeaderText = "Tổng", 
                DataPropertyName = "Tong", 
                Width = 80,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { 
                HeaderText = "Chọn PTV", 
                DataPropertyName = "ChonPTV", 
                Width = 100,
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle { 
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    BackColor = Color.FromArgb(255, 255, 220) // Highlight các ô có thể sửa
                }
            });
            
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { 
                HeaderText = "Mổ sớm", 
                DataPropertyName = "MoSom", 
                Width = 100,
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle { 
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    BackColor = Color.FromArgb(255, 255, 220) // Highlight các ô có thể sửa
                }
            });
            
            dgvKetQuaThucHienDV.Columns.Add(new DataGridViewTextBoxColumn { 
                HeaderText = "Gói PT", 
                DataPropertyName = "GoiPT", 
                Width = 100,
                ReadOnly = false,
                DefaultCellStyle = new DataGridViewCellStyle { 
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    BackColor = Color.FromArgb(255, 255, 220) // Highlight các ô có thể sửa
                }
            });

            // Gắn sự kiện
            dgvKetQuaThucHienDV.CellEndEdit += DgvKetQuaThucHienDichVu_CellEndEdit;
            dgvKetQuaThucHienDV.DataSource = KetQuaThucHienDichVuTheoYeuCauBUS.Instance.KhoiTaoDuLieu();

            // Gắn sự kiện để tự động điều chỉnh chiều cao dòng
            dgvKetQuaThucHienDV.DataBindingComplete += (s, e) => {
                ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaThucHienDV);
                StyleDataGridView(dgvKetQuaThucHienDV);
            };
            
            dgvKetQuaThucHienDV.SizeChanged += (s, e) => ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaThucHienDV);

            // Gọi ngay khi khởi tạo
            ResizeRowsToFit.Instance.AutoResizeRow(dgvKetQuaThucHienDV);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            // Thêm style cho các dòng sau khi binding dữ liệu
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = 35; // Chiều cao đồng nhất
            }
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
                    
                    // Highlight dòng vừa sửa
                    _dgvKetQuaThucHien.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                    
                    // Sau 1 giây, trở lại màu bình thường
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1000;
                    timer.Tick += (s, args) => {
                        _dgvKetQuaThucHien.Rows[e.RowIndex].DefaultCellStyle.BackColor = 
                            e.RowIndex % 2 == 0 ? Color.White : Color.FromArgb(245, 245, 245);
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
