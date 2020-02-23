using System.ComponentModel;

namespace RealEstateDataViewer.Models
{
    public class BuildingDTO : INotifyPropertyChanged
    {
        private int buildingID;
        public int BuildingID 
        {
            get { return buildingID; }
            set { buildingID = value; }
        }
        private string address { get; set; }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string zipOrPostalCode;
        public string ZipOrPostalCode
        {
            get { return zipOrPostalCode; }
            set { zipOrPostalCode = value; }
        }
        private int? buildingArea;
        public int? BuildingArea
        {
            get { return buildingArea; }
            set { buildingArea = value; }
        }
        private decimal occupancy;
        public decimal Occupancy
        {
            get { return occupancy; }
            set { occupancy = value; }
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
