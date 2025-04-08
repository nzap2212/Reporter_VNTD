using System.Collections.ObjectModel;
using System.Windows.Controls;
using Reporter_wpf.Models;
using Reporter_wpf.Services;

namespace Reporter_wpf.ViewModels
{
    public class KhoaKhamBenhViewModel : ViewModelBase
    {
        private ObservableCollection<SoLieuPhongKhamKhoaKhamBenh> _khoaKhamBenhData;
        private DataGrid _dataGrid;

        public ObservableCollection<SoLieuPhongKhamKhoaKhamBenh> KhoaKhamBenhData
        {
            get => _khoaKhamBenhData;
            set => SetProperty(ref _khoaKhamBenhData, value);
        }

        public DataGrid DataGrid
        {
            get => _dataGrid;
            set => SetProperty(ref _dataGrid, value);
        }

        public KhoaKhamBenhViewModel()
        {
            KhoaKhamBenhData = new ObservableCollection<SoLieuPhongKhamKhoaKhamBenh>();
        }

        public void LoadData()
        {
            KhoaKhamBenhData = DataService.Instance.GetKhoaKhamBenhData();
        }

        public void Reset()
        {
            KhoaKhamBenhData.Clear();
        }
    }
} 