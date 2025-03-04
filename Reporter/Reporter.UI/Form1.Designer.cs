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
            dgvBang6 = new DataGridView();
            dgvBang5 = new DataGridView();
            label5 = new Label();
            dgvSoLieuKhoaKhamBenh = new DataGridView();
            tabPage5 = new TabPage();
            dgvBang7 = new DataGridView();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaNoiTru).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaThucHienDV).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBang6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBang5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSoLieuKhoaKhamBenh).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBang7).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(dgvBaoCao);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1569, 1094);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Khám chữa bệnh toàn viện";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToOrderColumns = true;
            dgvBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(6, 62);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 62;
            dgvBaoCao.Size = new Size(1557, 961);
            dgvBaoCao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 31);
            label2.Name = "label2";
            label2.Size = new Size(244, 28);
            label2.TabIndex = 2;
            label2.Text = "Khám chữa bệnh toàn viện";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(3, 289);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1577, 1135);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dgvKetQuaNoiTru);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1590, 1102);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kết quả thực hiện kế hoạch của các khoa nội trú";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 38);
            label3.Name = "label3";
            label3.Size = new Size(427, 28);
            label3.TabIndex = 3;
            label3.Text = "Kết quả thực hiện kế hoạch của các khoa nội trú";
            // 
            // dgvKetQuaNoiTru
            // 
            dgvKetQuaNoiTru.AllowUserToAddRows = false;
            dgvKetQuaNoiTru.AllowUserToOrderColumns = true;
            dgvKetQuaNoiTru.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKetQuaNoiTru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQuaNoiTru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaNoiTru.Location = new Point(3, 69);
            dgvKetQuaNoiTru.Name = "dgvKetQuaNoiTru";
            dgvKetQuaNoiTru.RowHeadersWidth = 62;
            dgvKetQuaNoiTru.Size = new Size(1581, 966);
            dgvKetQuaNoiTru.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.AutoScroll = true;
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dgvKetQuaThucHienDV);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1590, 1102);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kết quả thục hiện dịch vụ theo yêu cầu";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 30);
            label4.Name = "label4";
            label4.Size = new Size(404, 28);
            label4.TabIndex = 3;
            label4.Text = "Kết quả thục hiện dịch vụ theo yêu cầu tháng";
            // 
            // dgvKetQuaThucHienDV
            // 
            dgvKetQuaThucHienDV.AllowUserToAddRows = false;
            dgvKetQuaThucHienDV.AllowUserToOrderColumns = true;
            dgvKetQuaThucHienDV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKetQuaThucHienDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQuaThucHienDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaThucHienDV.Location = new Point(0, 61);
            dgvKetQuaThucHienDV.Name = "dgvKetQuaThucHienDV";
            dgvKetQuaThucHienDV.RowHeadersWidth = 62;
            dgvKetQuaThucHienDV.Size = new Size(1584, 966);
            dgvKetQuaThucHienDV.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.AutoScroll = true;
            tabPage4.Controls.Add(dgvBang6);
            tabPage4.Controls.Add(dgvBang5);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(dgvSoLieuKhoaKhamBenh);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1590, 1102);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Số liệu của từng phòng khám khoa Khám bệnh";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvBang6
            // 
            dgvBang6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBang6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBang6.Location = new Point(6, 1479);
            dgvBang6.Name = "dgvBang6";
            dgvBang6.RowHeadersWidth = 62;
            dgvBang6.Size = new Size(1514, 500);
            dgvBang6.TabIndex = 3;
            // 
            // dgvBang5
            // 
            dgvBang5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBang5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBang5.Location = new Point(6, 942);
            dgvBang5.Name = "dgvBang5";
            dgvBang5.RowHeadersWidth = 62;
            dgvBang5.Size = new Size(1514, 500);
            dgvBang5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 25);
            label5.Name = "label5";
            label5.Size = new Size(421, 28);
            label5.TabIndex = 1;
            label5.Text = "Số liệu của từng phòng khám khoa Khám bệnh";
            // 
            // dgvSoLieuKhoaKhamBenh
            // 
            dgvSoLieuKhoaKhamBenh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSoLieuKhoaKhamBenh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoLieuKhoaKhamBenh.Location = new Point(6, 56);
            dgvSoLieuKhoaKhamBenh.Name = "dgvSoLieuKhoaKhamBenh";
            dgvSoLieuKhoaKhamBenh.RowHeadersWidth = 62;
            dgvSoLieuKhoaKhamBenh.Size = new Size(1514, 861);
            dgvSoLieuKhoaKhamBenh.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvBang7);
            tabPage5.Location = new Point(4, 37);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1569, 1094);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Số liệu phòng khám yêu cầu";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvBang7
            // 
            dgvBang7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBang7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBang7.Location = new Point(3, 25);
            dgvBang7.Name = "dgvBang7";
            dgvBang7.RowHeadersWidth = 51;
            dgvBang7.Size = new Size(1560, 732);
            dgvBang7.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 261);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Báo cáo số liệu";
            // 
            // button2
            // 
            button2.Location = new Point(354, 202);
            button2.Name = "button2";
            button2.Size = new Size(296, 40);
            button2.TabIndex = 4;
            button2.Text = "Xuất báo cáo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(41, 202);
            button1.Name = "button1";
            button1.Size = new Size(287, 40);
            button1.TabIndex = 2;
            button1.Text = "Chỉnh sửa số liệu";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(234, 130);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(416, 34);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(234, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(416, 34);
            dateTimePicker1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 135);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 1;
            label7.Text = "Đến ngày:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 62);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 0;
            label6.Text = "Số liệu từ ngày:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1730, 1015);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1764, 1039);
            Controls.Add(panel1);
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
            ((System.ComponentModel.ISupportInitialize)dgvBang6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBang5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSoLieuKhoaKhamBenh).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBang7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
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
        private DataGridView dgvBang6;
        private DataGridView dgvBang5;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private TabPage tabPage5;
        private DataGridView dgvBang7;
    }
}
