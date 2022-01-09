using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel.ListColView.ViewModels;

namespace ViewModel.ListColView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TestViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            //dg.CanUserAddRows = true;
            vm = new ViewModels.TestViewModel();
            DataContext = vm;
            dg.ItemsSource = vm.TestListCollectionView;
            //dg.CanUserAddRows = true;
        }

        private void dg_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            /* if((vm.PeopleColl.Last().FirstName ?? "") != "")
                 vm.PeopleColl.Add(new Person());//dg.ItemsSource*/
            //for (int i = 0; i < 3; i++)
            {
                if (vm.TestListCollectionView.IsAddingNew)
                    vm.TestListCollectionView.CommitNew();
                else if (vm.TestListCollectionView.IsEditingItem)
                    vm.TestListCollectionView.CommitEdit();
            }
            vm.TestListCollectionView.Refresh();
            
            ;
            ;
        }

        //private void dg_PreviewKeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.Key == Key.Enter)
        //    {
        //        if(dg.)

        //        //vm.AddNewRowIfNeed();
        //    }
        //}
    }
}
