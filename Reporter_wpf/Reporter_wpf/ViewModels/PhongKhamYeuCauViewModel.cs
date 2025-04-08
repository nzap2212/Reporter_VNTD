using System.Collections.ObjectModel;
using System.Windows.Controls;
using Reporter_wpf.Models;
using Reporter_wpf.Services;

namespace Reporter_wpf.ViewModels
{
    public class PhongKhamYeuCauViewModel : ViewModelBase
    {
        private ObservableCollection<SoLieuPhongKhamYeuCau> _phongKhamYeuCauData;
        private DataGrid _dataGrid;

        public ObservableCollection<SoLieuPhongKhamYeuCau> PhongKhamYeuCauData
        {
            get => _phongKhamYeuCauData;
            set => SetProperty(ref _phongKhamYeuCauData, value);
        }

        public DataGrid DataGrid
        {
            get => _dataGrid;
            set => SetProperty(ref _dataGrid, value);
        }

        public PhongKhamYeuCauViewModel()
        {
            PhongKhamYeuCauData = new ObservableCollection<SoLieuPhongKhamYeuCau>();
        }

        public void LoadData()
        {
            PhongKhamYeuCauData = DataService.Instance.GetPhongKhamYeuCauData();
        }

        public void Reset()
        {
            PhongKhamYeuCauData.Clear();
        }
    }
} 