using System.Collections.ObjectModel;
using System.Windows.Controls;
using Reporter_wpf.Models;
using Reporter_wpf.Services;

namespace Reporter_wpf.ViewModels
{
    public class KhamChuaBenhViewModel : ViewModelBase
    {
        private ObservableCollection<KhamChuaBenhToanVien> _khamChuaBenhData;
        private DataGrid _dataGrid;

        public ObservableCollection<KhamChuaBenhToanVien> KhamChuaBenhData
        {
            get => _khamChuaBenhData;
            set => SetProperty(ref _khamChuaBenhData, value);
        }

        public DataGrid DataGrid
        {
            get => _dataGrid;
            set => SetProperty(ref _dataGrid, value);
        }

        public KhamChuaBenhViewModel()
        {
            KhamChuaBenhData = new ObservableCollection<KhamChuaBenhToanVien>();
        }

        public void LoadData()
        {
            KhamChuaBenhData = DataService.Instance.GetKhamChuaBenhData();
        }

        public void Reset()
        {
            KhamChuaBenhData.Clear();
        }
    }
} 