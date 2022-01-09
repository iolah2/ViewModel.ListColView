using GalaSoft.MvvmLight;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ViewModel.ListColView.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        public ObservableCollection<Person> PeopleColl { get => _peopleColl; set { _peopleColl = value; RaisePropertyChanged(); } }
        public ListCollectionView TestListCollectionView { get => _collView; }
        private ObservableCollection<Person> _peopleColl;
        private ListCollectionView _collView;

        public TestViewModel()
        {
            
            PeopleColl = new ObservableCollection<Person>
            {
                new Person("Alma","Kiss","Hongrie"),
                new Person("Balga","Nagy","Angletterie"),
                new Person("Alma","Kiss","Hongrie"),
            };
            _collView = (ListCollectionView)CollectionViewSource.GetDefaultView(PeopleColl);

        }

        public void AddNewRowIfNeed()
        {
            if (true)
            {

            }
        }
    }
}
