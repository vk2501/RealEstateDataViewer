using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using RealEstateDataViewer.Commands;
using RealEstateDataViewer.Models;
using System.Linq;
using System.Collections.ObjectModel;

namespace RealEstateDataViewer.ViewModels
{
    public class BuildingViewModel : INotifyPropertyChanged
    {
        BuildingService BuildingServiceObj;
        SuiteService SuiteServiceObj;
        /// <summary>
        /// Constructor
        /// </summary>
        public BuildingViewModel()
        {
            BuildingServiceObj = new BuildingService();
            SuiteServiceObj = new SuiteService();
            PopulateBuildingsDataGrid();
            SelectedBuilding = new Building();
            _populateSuitesCommand = new DataGridSelectionChangedCommand(PopulateSuites, CanExecuteMethod);
        }

        private List<BuildingDTO> buildingsList;
        public List<BuildingDTO> BuildingsList
        {
            get { return buildingsList; }
            set { buildingsList = value; OnPropertyChanged("BuildingsList"); }
        }

        private void PopulateBuildingsDataGrid()
        {
            BuildingsList = BuildingServiceObj.GetBuildingsList();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Building _selectedBuilding;
        public Building SelectedBuilding
        {
            get { return _selectedBuilding; }
            set { _selectedBuilding = value; OnPropertyChanged("SelectedBuilding"); }
        }

        private DataGridSelectionChangedCommand _populateSuitesCommand;

        public DataGridSelectionChangedCommand PopulateSuitesCommand
        {
            get { return _populateSuitesCommand; }
            set { _populateSuitesCommand = value; }
        }

        private bool CanExecuteMethod(object parameter)
        {
            return true;
        }

        private ObservableCollection<SuiteDTO> _suitesList;
        public ObservableCollection<SuiteDTO> SuitesList
        {
            get { return _suitesList; }
            set { _suitesList = value; OnPropertyChanged("SuitesList"); }
        }

        private void PopulateSuitesDataGrid()
        {
            SuitesList = new ObservableCollection<SuiteDTO>(SuiteServiceObj.GetSuitesList());
        }

        /// <summary>
        /// Populates Suites for the given building Id
        /// </summary>
        /// <param name="parameter"></param>
        private void PopulateSuites(object parameter)
        {
            PopulateSuitesDataGrid();
            var selectedBuilding = parameter as BuildingDTO;
            var tempSuitesList = SuitesList.Where(b => b.BuildingID == selectedBuilding.BuildingID).ToList();
            SuitesList = new ObservableCollection<SuiteDTO>(tempSuitesList);
        }
    }
}
