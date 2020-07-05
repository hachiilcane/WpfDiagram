using WpfDiagramViewer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace WpfDiagramViewer
{
    public class WpfDiagramViewerModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewerMainView>();
        }
    }
}