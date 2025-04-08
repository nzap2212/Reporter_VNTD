using System.Windows.Controls;
using Reporter_wpf.ViewModels;

namespace Reporter_wpf.Views
{
    public partial class PhongKhamYeuCauView : UserControl
    {
        public PhongKhamYeuCauView()
        {
            InitializeComponent();
            
            // Lưu tham chiếu đến DataGrid trong ViewModel
            if (DataContext is PhongKhamYeuCauViewModel viewModel)
            {
                viewModel.DataGrid = PhongKhamYeuCauDataGrid;
            }
        }
    }
} 