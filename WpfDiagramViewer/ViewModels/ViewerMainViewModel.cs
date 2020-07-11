using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using WpfDiagram.Core.Mvvm;

namespace WpfDiagramViewer.ViewModels
{
    public class ViewerMainViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        public ViewerMainViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Message = "Viewer Module.";
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);
        }
    }
}
