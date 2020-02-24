using System;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateDataViewer.Models
{
    public class BuildingService
    {
        RealEstateExampleEntities realEstateDataContext;

        public BuildingService()
        {
            realEstateDataContext = new RealEstateExampleEntities();
        }

        public List<BuildingDTO> GetBuildingsList()
        {
            try
            {
                return realEstateDataContext.Buildings.ToList().Select(b => new BuildingDTO
                {
                    BuildingID = b.BuildingID,
                    Address = b.Address,
                    City = b.City,
                    State = b.State,
                    ZipOrPostalCode = b.ZipOrPostalCode,
                    BuildingArea = b.BuildingArea,
                    Occupancy = GetOccupancyPercentage(b.BuildingID, b.BuildingArea)
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal GetOccupancyPercentage(int buildingID, int? buildingArea)
        {
            var totalAreaOfSuites = realEstateDataContext.Suites.Where(s => s.BuildingID == buildingID).Select(p => p.SuiteArea).Sum();
            var occupancyValue = totalAreaOfSuites.HasValue ? Decimal.Divide(Convert.ToDecimal(totalAreaOfSuites.Value), Convert.ToDecimal(buildingArea.Value)) : Decimal.Zero;
            return occupancyValue;
        }
    }
}
