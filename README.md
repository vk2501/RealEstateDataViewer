# RealEstateDataViewer
=======================

Stage-10: Implemented dependency injection
Files updated
RealEstateDataViewer/RealEstateDataViewer/App.xaml
RealEstateDataViewer/RealEstateDataViewer/App.xaml.cs
RealEstateDataViewer/RealEstateDataViewer/Models/BuildingService.cs
RealEstateDataViewer/RealEstateDataViewer/Models/SuiteService.cs
RealEstateDataViewer/RealEstateDataViewer/RealEstateDataViewer.csproj
RealEstateDataViewer/RealEstateDataViewer/ViewModels/BuildingViewModel.cs
RealEstateDataViewer/RealEstateDataViewer/Views/MainWindow.xaml.cs
RealEstateDataViewer/RealEstateDataViewer/packages.config

-- New files --
RealEstateDataViewer/RealEstateDataViewer/Models/IBuildingService.cs
RealEstateDataViewer/RealEstateDataViewer/Models/ISuiteService.cs
RealEstateDataViewer/packages/System.Runtime.CompilerServices.Unsafe.4.5.2/
RealEstateDataViewer/packages/Unity.5.11.4/

Stage-9: Exception handling implementing DispatcherUnhandledException
Files updated 
1. RealEstateDataViewer/RealEstateDataViewer/App.xaml
2. RealEstateDataViewer/RealEstateDataViewer/App.xaml.cs


Stage-8: Implemented no records found to datagrids
Files updated 
1. RealEstateDataViewer/RealEstateDataViewer/Views/MainWindow.xaml

Stage-7: Datgrids more styling, code clean up and comments
Files updated 
1. RealEstateDataViewer/RealEstateDataViewer/Commands/DataGridSelectionChangedCommand.cs
2. RealEstateDataViewer/RealEstateDataViewer/Models/BuildingDTO.cs
3. RealEstateDataViewer/RealEstateDataViewer/Models/BuildingService.cs
4. RealEstateDataViewer/RealEstateDataViewer/Models/LeaseDTO.cs
5. RealEstateDataViewer/RealEstateDataViewer/Models/SuiteDTO.cs
6. RealEstateDataViewer/RealEstateDataViewer/Models/SuiteService.cs
7. RealEstateDataViewer/RealEstateDataViewer/ViewModels/BuildingViewModel.cs
8. RealEstateDataViewer/RealEstateDataViewer/Views/MainWindow.xaml


Stage-6: Datgrids styling and added logo
Files updated 
1. RealEstateDataViewer/RealEstateDataViewer/Models/BuildingDTO.cs
2. RealEstateDataViewer/RealEstateDataViewer/Models/BuildingService.cs
3. RealEstateDataViewer/RealEstateDataViewer/Models/SuiteService.cs
4. RealEstateDataViewer/RealEstateDataViewer/RealEstateDataViewer.csproj
5. RealEstateDataViewer/RealEstateDataViewer/Views/MainWindow.xaml


Stage-5: Implemented displaying leases for each suite under row details
Files updated 
1. RealEstateDataViewer/RealEstateDataViewer/Models/LeaseDTO.cs
2. RealEstateDataViewer/RealEstateDataViewer/Models/SuiteDTO.cs
3. RealEstateDataViewer/RealEstateDataViewer/Models/SuiteService.cs
4. RealEstateDataViewer/RealEstateDataViewer/Views/MainWindow.xaml

Stage-4: Implemented populating Suites(right) datagrid on double clicking any building record
Files updated 
1. RealEstateDataViewer/RealEstateDataViewer/Models/BuildingService.cs
2. RealEstateDataViewer/RealEstateDataViewer/RealEstateDataViewer.csproj
3. RealEstateDataViewer/RealEstateDataViewer/ViewModels/BuildingViewModel.cs
4. RealEstateDataViewer/RealEstateDataViewer/Views/MainWindow.xaml
--New files--
1. new file:   RealEstateDataViewer/RealEstateDataViewer/Commands/DataGridSelectionChangedCommand.cs
2. new file:   RealEstateDataViewer/RealEstateDataViewer/Models/LeaseDTO.cs
3. new file:   RealEstateDataViewer/RealEstateDataViewer/Models/SuiteDTO.cs
4. new file:   RealEstateDataViewer/RealEstateDataViewer/Models/SuiteService.cs

Stage-3: Some code cleanup and style to building datagrid
Files updated 
1. RealEstateDataViewer/RealEstateDataViewer/Models/BuildingDTO.cs
2. RealEstateDataViewer/RealEstateDataViewer/Views/MainWindow.xaml

Stage-2: Implemented Occupency field to Buildings data grid 
Files updated 
1. RealEstateDataViewer/RealEstateDataViewer/Models/BuildingDTO.cs
2. RealEstateDataViewer/RealEstateDataViewer/Models/BuildingService.cs
3. RealEstateDataViewer/RealEstateDataViewer/Views/MainWindow.xaml

Stage-1: Implemented MVVM layout and Populated Buildings DataGrid
1. MVVM layout
2. Entify framework - Database first
3. Populating buildings datagrid
