using System.Windows.Controls;
using Reporter_wpf.ViewModels;

namespace Reporter_wpf.Views
{
    public partial class KetQuaNoiTruView : UserControl
    {
        public KetQuaNoiTruView()
        {
            InitializeComponent();
            
            // Lưu tham chiếu đến DataGrid trong ViewModel
            if (DataContext is KetQuaNoiTruViewModel viewModel)
            {
                viewModel.DataGrid = KetQuaNoiTruDataGrid;
            }
        }
    }
} 