using System.Collections.Generic;
using System.ComponentModel;
using RealEstateDataViewer.Models;

namespace RealEstateDataViewer.ViewModels
{
    public class BuildingViewModel : INotifyPropertyChanged
    {
        BuildingService BuildingServiceObj;
        public BuildingViewModel()
        {
            BuildingServiceObj = new BuildingService();
            PopulateBuildingsDataGrid();
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
    }
}
