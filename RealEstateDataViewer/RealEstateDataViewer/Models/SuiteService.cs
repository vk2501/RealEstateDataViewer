using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDataViewer.Models
{
    public class SuiteService
    {
        RealEstateExampleEntities realEstateDataContext;

        public SuiteService()
        {
            realEstateDataContext = new RealEstateExampleEntities();
        }

        public List<SuiteDTO> GetSuitesList()
        {
            List<SuiteDTO> suitesList = new List<SuiteDTO>();
            try
            {
                suitesList = realEstateDataContext.Suites.ToList().Select(s => new SuiteDTO
                {
                    BuildingID = s.BuildingID,
                    SuiteID = s.SuiteID,
                    SuiteName = s.SuiteName,
                    SuiteArea = s.SuiteArea
                }).ToList();

                return suitesList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
