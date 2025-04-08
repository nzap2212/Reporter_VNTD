using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Reporter.UI.services
{
    public class WordExportService
    {
        private static WordExportService instance;
        public static WordExportService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WordExportService();
                }
                return instance;
            }
        }
        private WordExportService() { }

        public void ExportToWord(
            DataGridView dgvBaoCao,
            DataGridView dgvKetQuaNoiTru,
            DataGridView dgvKetQuaThucHienDV,
            DataGridView dgvSoLieuKhoaKhamBenh,
            DataGridView dgvBang5,
            DataGridView dgvBang6,
            DataGridView dgvBang7,
            DateTime tuNgay,
            DateTime denNgay)
        {
            // Hiển thị hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                FileName = $"Báo cáo số liệu {tuNgay:dd-MM-yyyy} đến {denNgay:dd-MM-yyyy}.docx"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = saveFileDialog.FileName;

            // Khởi tạo Word application
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                // Tạo document mới
                Word.Document doc = wordApp.Documents.Add();
                
                // Thiết lập page setup
                doc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                doc.PageSetup.TopMargin = wordApp.InchesToPoints(0.5f);
                doc.PageSetup.BottomMargin = wordApp.InchesToPoints(0.5f);
                doc.PageSetup.LeftMargin = wordApp.InchesToPoints(0.5f);
                doc.PageSetup.RightMargin = wordApp.InchesToPoints(0.5f);

                // Thêm tiêu đề báo cáo
                Paragraph titlePara = doc.Content.Paragraphs.Add();
                titlePara.Range.Text = "BÁO CÁO SỐ LIỆU BỆNH VIỆN";
                titlePara.Range.Font.Name = "Times New Roman";
                titlePara.Range.Font.Size = 16;
                titlePara.Range.Font.Bold = 1;
                titlePara.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                titlePara.Range.InsertParagraphAfter();

                // Thêm thông tin thời gian
                Paragraph datePara = doc.Content.Paragraphs.Add();
                datePara.Range.Text = $"Từ ngày: {tuNgay:dd/MM/yyyy} đến ngày: {denNgay:dd/MM/yyyy}";
                datePara.Range.Font.Name = "Times New Roman";
                datePara.Range.Font.Size = 12;
                datePara.Range.Font.Bold = 0;
                datePara.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                datePara.Range.InsertParagraphAfter();
                
                // Thêm khoảng trống
                Paragraph spacePara = doc.Content.Paragraphs.Add();
                spacePara.Range.Text = "";
                spacePara.Range.InsertParagraphAfter();

                // Thêm các bảng dữ liệu
                AddTableToDocument(doc, "BẢNG 1: KHÁM CHỮA BỆNH TOÀN VIỆN", dgvBaoCao);
                AddTableToDocument(doc, "BẢNG 2: KẾT QUẢ NỘI TRÚ THEO THÁNG", dgvKetQuaNoiTru);
                AddTableToDocument(doc, "BẢNG 3: KẾT QUẢ THỰC HIỆN DỊCH VỤ THEO YÊU CẦU", dgvKetQuaThucHienDV);
                AddTableToDocument(doc, "BẢNG 4: SỐ LIỆU PHÒNG KHÁM KHOA KHÁM BỆNH", dgvSoLieuKhoaKhamBenh);
                AddTableToDocument(doc, "BẢNG 5: SỐ LIỆU PHÒNG KHÁM NGOẠI TRÚ", dgvBang5);
                AddTableToDocument(doc, "BẢNG 6: SỐ LIỆU PHÒNG KHÁM CẤP CỨU", dgvBang6);
                AddTableToDocument(doc, "BẢNG 7: SỐ LIỆU PHÒNG KHÁM YÊU CẦU", dgvBang7);

                // Thêm chân trang
                AddFooter(doc);

                // Lưu document
                doc.SaveAs2(filePath);
                doc.Close();
                
                // Hỏi người dùng có muốn mở file không
                if (MessageBox.Show("Xuất báo cáo thành công! Bạn có muốn mở file không?", "Thông báo", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất báo cáo: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                wordApp.Quit();
                ReleaseComObject(wordApp);
            }
        }

        private void AddTableToDocument(Word.Document doc, string tableTitle, DataGridView dgv)
        {
            if (dgv.Rows.Count == 0 || dgv.Columns.Count == 0)
                return;

            // Thêm tiêu đề bảng
            Paragraph tableTitlePara = doc.Content.Paragraphs.Add();
            tableTitlePara.Range.Text = tableTitle;
            tableTitlePara.Range.Font.Name = "Times New Roman";
            tableTitlePara.Range.Font.Size = 12;
            tableTitlePara.Range.Font.Bold = 1;
            tableTitlePara.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            tableTitlePara.Range.InsertParagraphAfter();

            // Tạo bảng
            Word.Table table = doc.Tables.Add(
                tableTitlePara.Range, 
                dgv.Rows.Count + 1, 
                dgv.Columns.Count, 
                WdDefaultTableBehavior.wdWord9TableBehavior, 
                WdAutoFitBehavior.wdAutoFitWindow);

            // Định dạng bảng
            table.Borders.Enable = 1;
            table.AllowAutoFit = true;
            table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow);
            table.Range.Font.Name = "Times New Roman";
            table.Range.Font.Size = 10;

            // Thêm tiêu đề cột
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                if (dgv.Columns[col].Visible)
                {
                    table.Cell(1, col + 1).Range.Text = dgv.Columns[col].HeaderText;
                    table.Cell(1, col + 1).Range.Font.Bold = 1;
                }
            }

            // Thêm dữ liệu
            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    if (dgv.Columns[col].Visible)
                    {
                        var value = dgv.Rows[row].Cells[col].Value;
                        table.Cell(row + 2, col + 1).Range.Text = value != null ? value.ToString() : "";
                    }
                }
            }

            // Căn giữa tiêu đề cột
            table.Rows[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            
            // Thêm khoảng trống sau bảng
            Paragraph afterTablePara = doc.Content.Paragraphs.Add();
            afterTablePara.Range.Text = "";
            afterTablePara.Range.InsertParagraphAfter();
        }

        private void AddFooter(Word.Document doc)
        {
            // Thêm chân trang
            Word.Section section = doc.Sections[1];
            Word.Range footerRange = section.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            footerRange.Text = $"Báo cáo được tạo ngày {DateTime.Now:dd/MM/yyyy HH:mm}";
            footerRange.Font.Name = "Times New Roman";
            footerRange.Font.Size = 8;
            footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
        }

        private void ReleaseComObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
} 