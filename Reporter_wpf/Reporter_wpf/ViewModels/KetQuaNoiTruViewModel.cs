using System.Collections.ObjectModel;
using System.Windows.Controls;
using Reporter_wpf.Models;
using Reporter_wpf.Services;

namespace Reporter_wpf.ViewModels
{
    public class KetQuaNoiTruViewModel : ViewModelBase
    {
        private ObservableCollection<KetQuaNoiTruThang> _ketQuaNoiTruData;
        private DataGrid _dataGrid;

        public ObservableCollection<KetQuaNoiTruThang> KetQuaNoiTruData
        {
            get => _ketQuaNoiTruData;
            set => SetProperty(ref _ketQuaNoiTruData, value);
        }

        public DataGrid DataGrid
        {
            get => _dataGrid;
            set => SetProperty(ref _dataGrid, value);
        }

        public KetQuaNoiTruViewModel()
        {
            KetQuaNoiTruData = new ObservableCollection<KetQuaNoiTruThang>();
        }

        public void LoadData()
        {
            KetQuaNoiTruData = DataService.Instance.GetKetQuaNoiTruData();
        }

        public void Reset()
        {
            KetQuaNoiTruData.Clear();
        }
    }
} 