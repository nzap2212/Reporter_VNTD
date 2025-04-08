using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Data;
using System.Reflection;
using System.Windows.Media;

namespace Reporter_wpf.Services
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
            DataGrid khamChuaBenhGrid,
            DataGrid ketQuaNoiTruGrid,
            DataGrid dichVuYeuCauGrid,
            DataGrid khoaKhamBenhGrid,
            DataGrid phongKhamNgoaiTruGrid,
            DataGrid phongKhamCapCuuGrid,
            DataGrid phongKhamYeuCauGrid,
            DateTime startDate,
            DateTime endDate)
        {
            try
            {
                Console.WriteLine("Starting Word export...");
                
                // Tạo SaveFileDialog để chọn nơi lưu file
                Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
                saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
                saveFileDialog.DefaultExt = ".docx";
                saveFileDialog.FileName = $"BaoCaoSoLieu_{startDate:dd-MM-yyyy}_den_{endDate:dd-MM-yyyy}";
                
                if (saveFileDialog.ShowDialog() == true)
                {
                    Console.WriteLine($"Saving to file: {saveFileDialog.FileName}");

            // Khởi tạo Word application
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = false;

                // Tạo document mới
                    Document doc = wordApp.Documents.Add();
                    
                    // Thêm tiêu đề
                Paragraph titlePara = doc.Content.Paragraphs.Add();
                titlePara.Range.Text = "BÁO CÁO SỐ LIỆU BỆNH VIỆN";
                titlePara.Range.Font.Size = 16;
                titlePara.Range.Font.Bold = 1;
                    titlePara.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                titlePara.Range.InsertParagraphAfter();

                // Thêm thông tin thời gian
                Paragraph datePara = doc.Content.Paragraphs.Add();
                    datePara.Range.Text = $"Từ ngày: {startDate:dd/MM/yyyy} đến ngày: {endDate:dd/MM/yyyy}";
                datePara.Range.Font.Size = 12;
                    datePara.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                datePara.Range.InsertParagraphAfter();
                
                // Thêm khoảng trống
                Paragraph spacePara = doc.Content.Paragraphs.Add();
                spacePara.Range.Text = "";
                spacePara.Range.InsertParagraphAfter();

                    // Xuất dữ liệu từ các DataGrid
                    if (khamChuaBenhGrid != null && khamChuaBenhGrid.Items.Count > 0)
                    {
                        ExportDataGridToWord(doc, khamChuaBenhGrid, "KHÁM CHỮA BỆNH TOÀN VIỆN");
                    }
                    
                    if (ketQuaNoiTruGrid != null && ketQuaNoiTruGrid.Items.Count > 0)
                    {
                        ExportDataGridToWord(doc, ketQuaNoiTruGrid, "KẾT QUẢ NỘI TRÚ THEO THÁNG");
                    }
                    
                    if (dichVuYeuCauGrid != null && dichVuYeuCauGrid.Items.Count > 0)
                    {
                        ExportDataGridToWord(doc, dichVuYeuCauGrid, "DỊCH VỤ THEO YÊU CẦU");
                    }
                    
                    if (khoaKhamBenhGrid != null && khoaKhamBenhGrid.Items.Count > 0)
                    {
                        ExportDataGridToWord(doc, khoaKhamBenhGrid, "KHOA KHÁM BỆNH");
                    }
                    
                    if (phongKhamNgoaiTruGrid != null && phongKhamNgoaiTruGrid.Items.Count > 0)
                    {
                        ExportDataGridToWord(doc, phongKhamNgoaiTruGrid, "PHÒNG KHÁM NGOẠI TRÚ");
                    }
                    
                    if (phongKhamCapCuuGrid != null && phongKhamCapCuuGrid.Items.Count > 0)
                    {
                        ExportDataGridToWord(doc, phongKhamCapCuuGrid, "PHÒNG KHÁM CẤP CỨU");
                    }
                    
                    if (phongKhamYeuCauGrid != null && phongKhamYeuCauGrid.Items.Count > 0)
                    {
                        ExportDataGridToWord(doc, phongKhamYeuCauGrid, "PHÒNG KHÁM YÊU CẦU");
                    }

                // Lưu document
                    doc.SaveAs2(saveFileDialog.FileName);
                doc.Close();
                    wordApp.Quit();
                    
                    // Hiển thị thông báo thành công
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                    // Mở file vừa tạo
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ExportToWord: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show($"Lỗi khi xuất báo cáo: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExportDataGridToWord(Document doc, DataGrid dataGrid, string title)
        {
            try
            {
                Console.WriteLine($"Exporting DataGrid: {title}");
                
                // Thêm tiêu đề phần
                Paragraph sectionTitlePara = doc.Content.Paragraphs.Add();
                sectionTitlePara.Range.Text = title;
                sectionTitlePara.Range.Font.Size = 14;
                sectionTitlePara.Range.Font.Bold = 1;
                sectionTitlePara.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                sectionTitlePara.Range.InsertParagraphAfter();

            // Tạo bảng
                Table table = doc.Tables.Add(sectionTitlePara.Range, dataGrid.Items.Count + 1, dataGrid.Columns.Count);
            table.Borders.Enable = 1;
            table.AllowAutoFit = true;

                // Thêm header
                for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                    if (dataGrid.Columns[i].Header != null)
                {
                        table.Cell(1, i + 1).Range.Text = dataGrid.Columns[i].Header.ToString();
                        table.Cell(1, i + 1).Range.Font.Bold = 1;
                        table.Cell(1, i + 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                }
            }

            // Thêm dữ liệu
                for (int i = 0; i < dataGrid.Items.Count; i++)
            {
                    var item = dataGrid.Items[i];
                                                                                                      
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                        var column = dataGrid.Columns[j];
                        
                        // Kiểm tra loại cột
                        if (column is DataGridBoundColumn boundColumn)
                    {
                            var binding = boundColumn.Binding as System.Windows.Data.Binding;
                            
                        if (binding != null)
                        {
                                var propertyPath = binding.Path.Path;
                                var propertyValue = GetPropertyValue(item, propertyPath);
                                
                                if (propertyValue != null)
                                {
                                    table.Cell(i + 2, j + 1).Range.Text = propertyValue.ToString();
                                    
                                    // Căn phải cho các cột số
                                    if (propertyValue is int || propertyValue is double || propertyValue is decimal)
                                    {
                                        table.Cell(i + 2, j + 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Đối với các loại cột khác, bạn có thể bỏ qua hoặc xử lý theo cách khác
                            Console.WriteLine($"Skipping column of type: {column.GetType().Name}");
                        }
                    }
                }
                
                // Tự động điều chỉnh kích thước cột
                table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitContent);
            
            // Thêm khoảng trống sau bảng
            Paragraph afterTablePara = doc.Content.Paragraphs.Add();
            afterTablePara.Range.Text = "";
            afterTablePara.Range.InsertParagraphAfter();
                
                Console.WriteLine($"Exported DataGrid: {title} successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in ExportDataGridToWord: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private object GetPropertyValue(object obj, string propertyPath)
        {
            try
            {
                string[] parts = propertyPath.Split('.');
                object value = obj;
                
                foreach (string part in parts)
                {
                    if (value == null) return null;
                    
                    Type type = value.GetType();
                    PropertyInfo propertyInfo = type.GetProperty(part);
                    
                    if (propertyInfo == null) return null;
                    
                    value = propertyInfo.GetValue(value);
                }
                
                return value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetPropertyValue: {ex.Message}");
                return null;
            }
        }

        // Helper method để tìm kiếm phần tử con trong một phần tử cha
        private T FindChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            // Tìm kiếm trực tiếp
            if (parent == null) return null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                
                // Kiểm tra nếu phần tử con là loại T và có tên phù hợp
                if (child is T typedChild && (child as FrameworkElement)?.Name == childName)
                {
                    return typedChild;
                }

                // Tìm kiếm đệ quy
                var result = FindChild<T>(child, childName);
                if (result != null)
                {
                    return result;
                }
            }
            
            return null;
        }
    }
} 