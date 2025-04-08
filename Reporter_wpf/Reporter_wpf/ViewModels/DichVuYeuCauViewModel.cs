using System.Collections.ObjectModel;
using System.Windows.Controls;
using Reporter_wpf.Models;
using Reporter_wpf.Services;

namespace Reporter_wpf.ViewModels
{
    public class DichVuYeuCauViewModel : ViewModelBase
    {
        private ObservableCollection<KetQuaThucHienDichVuTheoYeuCau> _dichVuYeuCauData;
        private DataGrid _dataGrid;

        public ObservableCollection<KetQuaThucHienDichVuTheoYeuCau> DichVuYeuCauData
        {
            get => _dichVuYeuCauData;
            set => SetProperty(ref _dichVuYeuCauData, value);
        }

        public DataGrid DataGrid
        {
            get => _dataGrid;
            set => SetProperty(ref _dataGrid, value);
        }

        public DichVuYeuCauViewModel()
        {
            DichVuYeuCauData = new ObservableCollection<KetQuaThucHienDichVuTheoYeuCau>();
        }

        public void LoadData()
        {
            DichVuYeuCauData = DataService.Instance.GetDichVuYeuCauData();
        }

        public void Reset()
        {
            DichVuYeuCauData.Clear();
        }
    }
} 