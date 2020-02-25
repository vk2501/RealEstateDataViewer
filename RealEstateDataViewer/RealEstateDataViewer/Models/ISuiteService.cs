using System.Collections.Generic;

namespace RealEstateDataViewer.Models
{
    public interface ISuiteService
    {
        List<SuiteDTO> GetSuitesList();
    }
}