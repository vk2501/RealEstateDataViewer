﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDataViewer.Models
{
    public class SuiteService : ISuiteService
    {
        RealEstateExampleEntities realEstateDataContext;

        public SuiteService()
        {
            realEstateDataContext = new RealEstateExampleEntities();
        }

        /// <summary>
        /// Returns complete list of Suites
        /// </summary>
        /// <returns></returns>
        public List<SuiteDTO> GetSuitesList()
        {
            List<SuiteDTO> suitesList = new List<SuiteDTO>();
            try
            {
                suitesList = realEstateDataContext.Suites.ToList().Select(s => new SuiteDTO
                {
                    BuildingID = s.BuildingID,
                    SuiteID = s.SuiteID,
                    SuiteName = s.SuiteName.ToString().Trim(),
                    SuiteArea = s.SuiteArea,
                    LeasesList = GetLeasesList(s.BuildingID, s.SuiteID),
                    Vacant = CheckVacancy(s.BuildingID, s.SuiteID)
                }).ToList();

                return suitesList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<LeaseDTO> GetLeasesList(int buildingID, int suiteID)
        {
            var filsteredLeases = realEstateDataContext.Leases.Where(l => l.BuildingID == buildingID && l.SuiteID == suiteID).ToList();

            return filsteredLeases.Select(l => new LeaseDTO
            {
                BuildingID = l.BuildingID,
                SuiteID = l.SuiteID,
                LeaseID = l.LeaseID,
                TenantName = l.TenantName,
                LeaseBegin = l.LeaseBegin,
                LeaseExpiration = l.LeaseExpiration,
                RentPerMonth = l.RentPerMonth
            }).ToList();
        }

        private string CheckVacancy(int buildingID, int suiteID)
        {
            string returnValue = "Vacant";
            var filsteredLeases = realEstateDataContext.Leases.Where(l => l.BuildingID == buildingID && l.SuiteID == suiteID).ToList();
            if (filsteredLeases.Count != 0)
            {
                returnValue = "-";
            }
            return returnValue;
        }
    }
}
