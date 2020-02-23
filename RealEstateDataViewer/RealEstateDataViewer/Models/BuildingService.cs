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
            List<BuildingDTO> buildingsList = new List<BuildingDTO>();
            try
            {
                var buildingsQuery = from building in realEstateDataContext.Buildings
                                     select new BuildingDTO
                                     {
                                         BuildingID = building.BuildingID,
                                         Address = building.Address,
                                         City = building.City,
                                         State = building.State,
                                         ZipOrPostalCode = building.ZipOrPostalCode,
                                         BuildingArea = building.BuildingArea
                                     };
                return buildingsQuery.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
