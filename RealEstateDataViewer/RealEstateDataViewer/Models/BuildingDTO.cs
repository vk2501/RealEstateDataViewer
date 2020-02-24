using System.ComponentModel;

namespace RealEstateDataViewer.Models
{
    public class BuildingDTO : INotifyPropertyChanged
    {
        private int _buildingID;
        public int BuildingID 
        {
            get { return _buildingID; }
            set { _buildingID = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        private string _zipOrPostalCode;
        public string ZipOrPostalCode
        {
            get { return _zipOrPostalCode; }
            set { _zipOrPostalCode = value; }
        }

        private int? _buildingArea;
        public int? BuildingArea
        {
            get { return _buildingArea; }
            set { _buildingArea = value; }
        }

        private string _occupancy;
        public string Occupancy
        {
            get { return _occupancy; }
            set { _occupancy = value; }
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
