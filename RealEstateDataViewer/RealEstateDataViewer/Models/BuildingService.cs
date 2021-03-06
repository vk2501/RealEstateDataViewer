﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateDataViewer.Models
{
    public class BuildingService : IBuildingService
    {
        RealEstateExampleEntities realEstateDataContext;

        public BuildingService()
        {
            realEstateDataContext = new RealEstateExampleEntities();
        }

        /// <summary>
        /// Returns list of buildings
        /// </summary>
        /// <returns></returns>
        public List<BuildingDTO> GetBuildingsList()
        {
            try
            {
                return realEstateDataContext.Buildings.ToList().Select(b => new BuildingDTO
                {
                    BuildingID = b.BuildingID,
                    Address = b.Address.ToString().Trim(),
                    City = b.City.ToString().Trim(),
                    State = b.State.ToString().Trim(),
                    ZipOrPostalCode = b.ZipOrPostalCode.ToString().Trim(),
                    BuildingArea = b.BuildingArea,
                    Occupancy = GetOccupancyValue(b.BuildingID, b.BuildingArea)
                }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Calculate occupancy value
        /// </summary>
        /// <param name="buildingID"></param>
        /// <param name="buildingArea"></param>
        /// <returns></returns>
        public string GetOccupancyValue(int buildingID, int? buildingArea)
        {
            var totalAreaOfSuites = realEstateDataContext.Suites.Where(s => s.BuildingID == buildingID && s.Leases.Count > 0).Select(p => p.SuiteArea).Sum();
            var occupancyValue = totalAreaOfSuites.HasValue ? Decimal.Divide(Convert.ToDecimal(totalAreaOfSuites.Value), Convert.ToDecimal(buildingArea.Value)) : Decimal.Zero;
            return occupancyValue.ToString("0.00");
        }
    }
}
