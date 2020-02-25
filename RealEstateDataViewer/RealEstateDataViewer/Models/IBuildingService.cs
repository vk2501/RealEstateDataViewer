using System.Collections.Generic;

namespace RealEstateDataViewer.Models
{
    public interface IBuildingService
    {
        List<BuildingDTO> GetBuildingsList();
    }
}