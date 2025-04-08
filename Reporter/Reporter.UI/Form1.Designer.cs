namespace Reporter.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvKetQuaNoiTru = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvKetQuaThucHienDV = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSoLieuKhoaKhamBenh = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvBang5 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvBang6 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgvBang7 = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ngayvaoDP = new System.Windows.Forms.DateTimePicker();
            this.ngayraDP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExportWord = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaNoiTru).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThucHienDV).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoLieuKhoaKhamBenh).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBang5).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBang6).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBang7).BeginInit();
            groupBox1.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new Point(3, 289);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(1672, 1094);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dgvBaoCao);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new Padding(3);
            this.tabPage1.Size = new Size(1664, 1049);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khám chữa bệnh toàn viện";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToOrderColumns = true;
            this.dgvBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new Point(6, 62);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 62;
            this.dgvBaoCao.Size = new Size(1652, 981);
            this.dgvBaoCao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new Size(302, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khám chữa bệnh toàn viện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0, 38);
            this.label1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dgvKetQuaNoiTru);
            this.tabPage2.Location = new Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new Padding(3);
            this.tabPage2.Size = new Size(1664, 1049);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kết quả thực hiện kế hoạch của các khoa nội trú";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvKetQuaNoiTru
            // 
            this.dgvKetQuaNoiTru.AllowUserToAddRows = false;
            this.dgvKetQuaNoiTru.AllowUserToOrderColumns = true;
            this.dgvKetQuaNoiTru.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvKetQuaNoiTru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaNoiTru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaNoiTru.Location = new Point(3, 69);
            this.dgvKetQuaNoiTru.Name = "dgvKetQuaNoiTru";
            this.dgvKetQuaNoiTru.RowHeadersWidth = 62;
            this.dgvKetQuaNoiTru.Size = new Size(1655, 959);
            this.dgvKetQuaNoiTru.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.dgvKetQuaThucHienDV);
            this.tabPage3.Location = new Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new Padding(3);
            this.tabPage3.Size = new Size(1664, 1049);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kết quả thục hiện dịch vụ theo yêu cầu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvKetQuaThucHienDV
            // 
            this.dgvKetQuaThucHienDV.AllowUserToAddRows = false;
            this.dgvKetQuaThucHienDV.AllowUserToOrderColumns = true;
            this.dgvKetQuaThucHienDV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvKetQuaThucHienDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaThucHienDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaThucHienDV.Location = new Point(0, 61);
            this.dgvKetQuaThucHienDV.Name = "dgvKetQuaThucHienDV";
            this.dgvKetQuaThucHienDV.RowHeadersWidth = 62;
            this.dgvKetQuaThucHienDV.Size = new Size(1658, 959);
            this.dgvKetQuaThucHienDV.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.dgvSoLieuKhoaKhamBenh);
            this.tabPage4.Location = new Point(4, 41);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new Padding(3);
            this.tabPage4.Size = new Size(1664, 1049);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Số liệu của từng phòng khám khoa Khám bệnh";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSoLieuKhoaKhamBenh
            // 
            this.dgvSoLieuKhoaKhamBenh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvSoLieuKhoaKhamBenh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoLieuKhoaKhamBenh.Location = new Point(6, 56);
            this.dgvSoLieuKhoaKhamBenh.Name = "dgvSoLieuKhoaKhamBenh";
            this.dgvSoLieuKhoaKhamBenh.RowHeadersWidth = 62;
            this.dgvSoLieuKhoaKhamBenh.Size = new Size(1626, 861);
            this.dgvSoLieuKhoaKhamBenh.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvBang5);
            this.tabPage5.Location = new Point(4, 41);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new Padding(3);
            this.tabPage5.Size = new Size(1664, 1049);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Số liệu phòng khám yêu cầu";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvBang5
            // 
            this.dgvBang5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvBang5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBang5.Location = new Point(6, 942);
            this.dgvBang5.Name = "dgvBang5";
            this.dgvBang5.RowHeadersWidth = 62;
            this.dgvBang5.Size = new Size(1228, 500);
            this.dgvBang5.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgvBang6);
            this.tabPage6.Location = new Point(4, 41);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new Padding(3);
            this.tabPage6.Size = new Size(1664, 1049);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Phòng khám cấp cứu";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvBang6
            // 
            this.dgvBang6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvBang6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBang6.Location = new Point(6, 1479);
            this.dgvBang6.Name = "dgvBang6";
            this.dgvBang6.RowHeadersWidth = 62;
            this.dgvBang6.Size = new Size(1228, 500);
            this.dgvBang6.TabIndex = 3;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dgvBang7);
            this.tabPage7.Location = new Point(4, 41);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new Padding(3);
            this.tabPage7.Size = new Size(1664, 1049);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Phòng khám yêu cầu";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dgvBang7
            // 
            this.dgvBang7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvBang7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBang7.Location = new Point(0, 129);
            this.dgvBang7.Name = "dgvBang7";
            this.dgvBang7.RowHeadersWidth = 51;
            this.dgvBang7.Size = new Size(1655, 732);
            this.dgvBang7.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Height = 100;
            this.panelTop.BackColor = Color.White;
            this.panelTop.Padding = new Padding(15);
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Controls.Add(this.btnExportWord);
            this.panelTop.Location = new Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(1730, 1015);
            this.panelTop.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ngayvaoDP);
            this.groupBox1.Controls.Add(this.ngayraDP);
            this.groupBox1.Location = new Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(672, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian báo cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new Size(122, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            // 
            // ngayvaoDP
            // 
            this.ngayvaoDP.CustomFormat = "yyyy-MM-dd";
            this.ngayvaoDP.Format = DateTimePickerFormat.Custom;
            this.ngayvaoDP.Location = new Point(100, 25);
            this.ngayvaoDP.Name = "ngayvaoDP";
            this.ngayvaoDP.Size = new Size(150, 39);
            this.ngayvaoDP.TabIndex = 2;
            this.ngayvaoDP.Value = DateTime.Now.AddDays(-30);
            // 
            // ngayraDP
            // 
            this.ngayraDP.CustomFormat = "yyyy-MM-dd";
            this.ngayraDP.Format = DateTimePickerFormat.Custom;
            this.ngayraDP.Location = new Point(100, 55);
            this.ngayraDP.Name = "ngayraDP";
            this.ngayraDP.Size = new Size(150, 39);
            this.ngayraDP.TabIndex = 3;
            this.ngayraDP.Value = DateTime.Now;
            // 
            // button1
            // 
            this.button1.Location = new Point(420, 25);
            this.button1.Name = "button1";
            this.button1.Size = new Size(120, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xem báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new Point(550, 25);
            this.button2.Name = "button2";
            this.button2.Size = new Size(120, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExportWord
            // 
            this.btnExportWord.Location = new Point(680, 25);
            this.btnExportWord.Name = "btnExportWord";
            this.btnExportWord.Size = new Size(120, 40);
            this.btnExportWord.TabIndex = 6;
            this.btnExportWord.Text = "Xuất Word";
            this.btnExportWord.UseVisualStyleBackColor = true;
            this.btnExportWord.Click += new System.EventHandler(this.btnExportWord_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1730, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Text = "Sẵn sàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1764, 1039);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusStrip1);
            this.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Margin = new Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Báo cáo số liệu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvBaoCao).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvKetQuaNoiTru).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvKetQuaThucHienDV).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvSoLieuKhoaKhamBenh).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvBang5).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvBang6).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvBang7).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvKetQuaNoiTru;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvKetQuaThucHienDV;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvSoLieuKhoaKhamBenh;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvBang5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvBang6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dgvBang7;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ngayvaoDP;
        private System.Windows.Forms.DateTimePicker ngayraDP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExportWord;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}
