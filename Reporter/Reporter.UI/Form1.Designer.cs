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
            tabPage1 = new TabPage();
            dgvBaoCao = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label3 = new Label();
            dgvKetQuaNoiTru = new DataGridView();
            tabPage3 = new TabPage();
            label4 = new Label();
            dgvKetQuaThucHienDV = new DataGridView();
            tabPage4 = new TabPage();
            dgvSoLieuKhoaKhamBenh = new DataGridView();
            label5 = new Label();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaNoiTru).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThucHienDV).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoLieuKhoaKhamBenh).BeginInit();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvBaoCao);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 41);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1753, 1095);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Khám chữa bệnh toàn viện";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToOrderColumns = true;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(0, 110);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 62;
            dgvBaoCao.Size = new Size(1750, 979);
            dgvBaoCao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 57);
            label2.Name = "label2";
            label2.Size = new Size(302, 32);
            label2.TabIndex = 2;
            label2.Text = "Khám chữa bệnh toàn viện";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1761, 1140);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dgvKetQuaNoiTru);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1753, 1102);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kết quả thực hiện kế hoạch của các khoa nội trú";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 69);
            label3.Name = "label3";
            label3.Size = new Size(530, 32);
            label3.TabIndex = 3;
            label3.Text = "Kết quả thực hiện kế hoạch của các khoa nội trú";
            // 
            // dgvKetQuaNoiTru
            // 
            dgvKetQuaNoiTru.AllowUserToAddRows = false;
            dgvKetQuaNoiTru.AllowUserToOrderColumns = true;
            dgvKetQuaNoiTru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQuaNoiTru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaNoiTru.Location = new Point(3, 104);
            dgvKetQuaNoiTru.Name = "dgvKetQuaNoiTru";
            dgvKetQuaNoiTru.RowHeadersWidth = 62;
            dgvKetQuaNoiTru.Size = new Size(1750, 982);
            dgvKetQuaNoiTru.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dgvKetQuaThucHienDV);
            tabPage3.Location = new Point(4, 41);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1753, 1095);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kết quả thục hiện dịch vụ theo yêu cầu";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(504, 32);
            label4.TabIndex = 3;
            label4.Text = "Kết quả thục hiện dịch vụ theo yêu cầu tháng";
            // 
            // dgvKetQuaThucHienDV
            // 
            dgvKetQuaThucHienDV.AllowUserToAddRows = false;
            dgvKetQuaThucHienDV.AllowUserToOrderColumns = true;
            dgvKetQuaThucHienDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQuaThucHienDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThucHienDV.Location = new Point(0, 101);
            dgvKetQuaThucHienDV.Name = "dgvKetQuaThucHienDV";
            dgvKetQuaThucHienDV.RowHeadersWidth = 62;
            dgvKetQuaThucHienDV.Size = new Size(1750, 982);
            dgvKetQuaThucHienDV.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(dgvSoLieuKhoaKhamBenh);
            tabPage4.Location = new Point(4, 41);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1753, 1095);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Số liệu của từng phòng khám khoa Khám bệnh";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSoLieuKhoaKhamBenh
            // 
            dgvSoLieuKhoaKhamBenh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoLieuKhoaKhamBenh.Location = new Point(3, 101);
            dgvSoLieuKhoaKhamBenh.Name = "dgvSoLieuKhoaKhamBenh";
            dgvSoLieuKhoaKhamBenh.RowHeadersWidth = 62;
            dgvSoLieuKhoaKhamBenh.Size = new Size(1747, 991);
            dgvSoLieuKhoaKhamBenh.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 66);
            label5.Name = "label5";
            label5.Size = new Size(520, 32);
            label5.TabIndex = 1;
            label5.Text = "Số liệu của từng phòng khám khoa Khám bệnh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1785, 1164);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo số liệu";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaNoiTru).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThucHienDV).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoLieuKhoaKhamBenh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private Label label1;
        private TabControl tabControl1;
        private Label label2;
        private TabPage tabPage2;
        private Label label3;
        private DataGridView dgvKetQuaNoiTru;
        private TabPage tabPage3;
        private DataGridView dgvKetQuaThucHienDV;
        private Label label4;
        private DataGridView dgvBaoCao;
        private TabPage tabPage4;
        private Label label5;
        private DataGridView dgvSoLieuKhoaKhamBenh;
    }
}
