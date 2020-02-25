using RealEstateDataViewer.Models;
using RealEstateDataViewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Unity;

namespace RealEstateDataViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IBuildingService, BuildingService>();
            container.RegisterType<ISuiteService, SuiteService>();

            var buildingsViewModel = container.Resolve<BuildingViewModel>();
            var window = new MainWindow { DataContext = buildingsViewModel };
            window.Show();

            Current.DispatcherUnhandledException += new DispatcherUnhandledExceptionEventHandler(Current_DispatcherUnhandledException);
            DispatcherUnhandledException += new DispatcherUnhandledExceptionEventHandler(App_DispatcherUnhandledException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            DisplayError(e);
            // Signal that we handled things--prevents Application from exiting
            e.Handled = true;
        }

        void Current_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            DisplayError(e);
            e.Handled = true;
        }

        void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            DisplayError(e);
            e.Handled = true;
        }

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var isTerminating = e.IsTerminating;
        }
        
        private void DisplayError(DispatcherUnhandledExceptionEventArgs e)
        {
            string friendlyMsg = string.Format("RealEstateDataViewer error handler: {0}", e.Exception.Message);
            string caption = "Error";
            MessageBox.Show(friendlyMsg, caption, MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
