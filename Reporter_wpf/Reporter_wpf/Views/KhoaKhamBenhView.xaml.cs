using System.Windows.Controls;
using Reporter_wpf.ViewModels;

namespace Reporter_wpf.Views
{
    public partial class KhoaKhamBenhView : UserControl
    {
        public KhoaKhamBenhView()
        {
            InitializeComponent();
            
            // Lưu tham chiếu đến DataGrid trong ViewModel
            if (DataContext is KhoaKhamBenhViewModel viewModel)
            {
                viewModel.DataGrid = KhoaKhamBenhDataGrid;
            }
        }
    }
} 