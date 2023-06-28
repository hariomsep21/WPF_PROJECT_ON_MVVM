using System.Windows;
using WpfApp23_MVVM.ViewModel;

namespace WpfApp23_MVVM
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWidnowViewModel vm= new MainWidnowViewModel();
            DataContext = vm;
        }
    }
}
