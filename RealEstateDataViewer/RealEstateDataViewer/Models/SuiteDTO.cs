using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RealEstateDataViewer.Models
{
    public class SuiteDTO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int _suiteID;

        public int SuiteID
        {
            get { return _suiteID; }
            set { _suiteID = value; }
        }

        private int _buildingID;

        public int BuildingID
        {
            get { return _buildingID; }
            set { _buildingID = value; }
        }

        private string _suiteName;

        public string SuiteName
        {
            get { return _suiteName; }
            set { _suiteName = value; }
        }

        private int? _suiteArea;

        public int? SuiteArea
        {
            get { return _suiteArea; }
            set { _suiteArea = value; }
        }

    }
}
