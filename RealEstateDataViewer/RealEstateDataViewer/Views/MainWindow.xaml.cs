using System.Windows;
using RealEstateDataViewer.ViewModels;

namespace RealEstateDataViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BuildingViewModel BuildingsViewModel;
        public MainWindow()
        {
            this.WindowState = WindowState.Maximized;
            InitializeComponent();
            BuildingsViewModel = new BuildingViewModel();
            this.DataContext = BuildingsViewModel;
        }
    }
}
