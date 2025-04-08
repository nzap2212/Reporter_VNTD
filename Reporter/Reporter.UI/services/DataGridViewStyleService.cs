using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reporter.UI.services
{
    public class DataGridViewStyleService
    {
        private static DataGridViewStyleService instance;
        public static DataGridViewStyleService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataGridViewStyleService();
                }
                return instance;
            }
        }
        private DataGridViewStyleService() { }

        // Áp dụng style hiện đại cho DataGridView
        public void ApplyModernStyle(DataGridView dgv)
        {
            // Thiết lập style cơ bản
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Thiết lập font
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            
            // Thiết lập màu sắc
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            
            // Thiết lập chiều cao header
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            
            // Thiết lập style cho các dòng lẻ/chẵn
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            
            // Thiết lập style cho các ô được chọn
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        // Highlight các ô có thể chỉnh sửa
        public void HighlightEditableCells(DataGridView dgv, params int[] editableColumnIndexes)
        {
            foreach (int colIndex in editableColumnIndexes)
            {
                if (colIndex >= 0 && colIndex < dgv.Columns.Count)
                {
                    dgv.Columns[colIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
                    dgv.Columns[colIndex].ReadOnly = false;
                }
            }
            
            // Các cột khác sẽ là readonly
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (!editableColumnIndexes.Contains(i))
                {
                    dgv.Columns[i].ReadOnly = true;
                }
            }
        }
        
        // Thiết lập căn lề cho các cột
        public void SetColumnAlignment(DataGridView dgv, DataGridViewContentAlignment alignment, params int[] columnIndexes)
        {
            foreach (int colIndex in columnIndexes)
            {
                if (colIndex >= 0 && colIndex < dgv.Columns.Count)
                {
                    dgv.Columns[colIndex].DefaultCellStyle.Alignment = alignment;
                }
            }
        }
    }
} 