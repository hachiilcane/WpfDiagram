using Prism.Ioc;
using WpfDiagram.Views;
using System.Windows;
using Prism.Modularity;
using WpfDiagramViewer;
using Prism.Regions;

namespace WpfDiagram
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<WpfDiagramViewerModule>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var regionMan = Container.Resolve<IRegionManager>();
            regionMan.RegisterViewWithRegion("ContentRegion", typeof(WpfDiagramViewer.Views.ViewerMainView));
        }
    }
}
