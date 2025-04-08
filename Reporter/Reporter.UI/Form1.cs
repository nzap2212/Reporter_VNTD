using Reporter.BUS;
using Reporter.UI.components;
using Reporter.UI.Components;
using Reporter.UI.services;
using System.Drawing.Drawing2D;

namespace Reporter.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomUI();
        }
        
        private void InitializeCustomUI()
        {
            // Thiết lập giao diện hiện đại
            this.Text = "Báo Cáo Số Liệu Bệnh Viện";
            try
            {
                this.Icon = new Icon(Path.Combine(Application.StartupPath, "Assets", "icon", "MainAppLogo.ico"));
            }
            catch { /* Bỏ qua nếu không tìm thấy icon */ }
            
            // Thiết lập màu sắc và font chữ
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            
            // Thiết lập DateTimePicker
            ngayvaoDP.Format = DateTimePickerFormat.Custom;
            ngayvaoDP.CustomFormat = "dd/MM/yyyy";
            ngayraDP.Format = DateTimePickerFormat.Custom;
            ngayraDP.CustomFormat = "dd/MM/yyyy";
            
            // Thiết lập nút tìm kiếm
            ApplyButtonStyle(button1);
            ApplyButtonStyle(button2);
            ApplyButtonStyle(btnExportWord);
            
            // Thiết lập TabControl
            ApplyTabControlStyle(tabControl1);
            
            // Thiết lập ngày mặc định
            ngayvaoDP.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ngày đầu tháng
            ngayraDP.Value = DateTime.Now;
            
            // Thiết lập status strip
            statusLabel.Text = "Sẵn sàng";
        }
        
        private void ApplyButtonStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(0, 120, 215);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(10, 5, 10, 5);
            
            // Thêm hiệu ứng hover
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(0, 100, 190);
            };
            
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.FromArgb(0, 120, 215);
            };
        }
        
        private void ApplyTabControlStyle(TabControl tabControl)
        {
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(120, 40);
            tabControl.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            
            // Thiết lập style cho các tab
            foreach (TabPage tab in tabControl.TabPages)
            {
                tab.BackColor = Color.White;
                tab.Padding = new Padding(15);
            }
        }
        
        // Xem báo cáo số liệu
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                string a = (ngayvaoDP.Value).ToString("dd/MM/yyyy") + " 00:00:00";
                string b = (ngayraDP.Value).ToString("dd/MM/yyyy") + " 23:59:59";

                Bang1.Instance.SetupDataGridView(dgvBaoCao);
                Bang2.Instance.SetupBang2(dgvKetQuaNoiTru);
                Bang3.Instance.SetupBang3(dgvKetQuaThucHienDV);
                Bang4.Instance.SetupBang4(dgvSoLieuKhoaKhamBenh);
                Bang5.Instance.SetupBang5(dgvBang5);
                Bang6.Instance.SetupBang6(dgvBang6, a, b);
                Bang7.Instance.SetupBang7(dgvBang7);
                
                statusLabel.Text = "Đã tải dữ liệu thành công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Lỗi khi tải dữ liệu";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        
        // Làm mới dữ liệu
        private void button2_Click(object sender, EventArgs e)
        {
            // Reset các DataGridView
            dgvBaoCao.DataSource = null;
            dgvKetQuaNoiTru.DataSource = null;
            dgvKetQuaThucHienDV.DataSource = null;
            dgvSoLieuKhoaKhamBenh.DataSource = null;
            dgvBang5.DataSource = null;
            dgvBang6.DataSource = null;
            dgvBang7.DataSource = null;
            
            // Reset ngày
            ngayvaoDP.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            ngayraDP.Value = DateTime.Now;
            
            statusLabel.Text = "Đã làm mới dữ liệu";
        }
        
        // Xuất báo cáo ra Word
        private void btnExportWord_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã có dữ liệu chưa
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng tải dữ liệu trước khi xuất báo cáo!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            Cursor = Cursors.WaitCursor;
            statusLabel.Text = "Đang xuất báo cáo...";
            
            try
            {
                // Gọi service xuất Word
                WordExportService.Instance.ExportToWord(
                    dgvBaoCao, 
                    dgvKetQuaNoiTru, 
                    dgvKetQuaThucHienDV, 
                    dgvSoLieuKhoaKhamBenh, 
                    dgvBang5, 
                    dgvBang6, 
                    dgvBang7,
                    ngayvaoDP.Value,
                    ngayraDP.Value
                );
                
                statusLabel.Text = "Đã xuất báo cáo thành công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Lỗi khi xuất báo cáo";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}

