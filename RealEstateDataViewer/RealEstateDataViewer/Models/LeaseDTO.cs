using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RealEstateDataViewer.Models
{
    public class LeaseDTO : INotifyPropertyChanged
    {
        private int _buildingID;
        public int BuildingID
        {
            get { return _buildingID; }
            set { _buildingID = value; }
        }

        private int _leaseID;
		public int LeaseID
        {
			get { return _leaseID; }
			set { _leaseID = value; }
		}

        private int _suiteID;
        public int SuiteID
        {
            get { return _suiteID; }
            set { _suiteID = value; }
        }

        private string _tenantName;
        public string TenantName
        {
            get { return _tenantName; }
            set { _tenantName = value; }
        }

        private DateTime? _leaseBegin;
        public DateTime? LeaseBegin
        {
            get { return _leaseBegin; }
            set { _leaseBegin = value; }
        }

        private DateTime? _leaseExpiration;
        public DateTime? LeaseExpiration
        {
            get { return _leaseExpiration; }
            set { _leaseExpiration = value; }
        }

        private double? _rentPerMonth;
        public double? RentPerMonth
        {
            get { return _rentPerMonth; }
            set { _rentPerMonth = value; }
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
