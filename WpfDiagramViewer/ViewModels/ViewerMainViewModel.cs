using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace WpfDiagramViewer.ViewModels
{
    public class ViewerMainViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        public ViewerMainViewModel()
        {
            Message = "Viewer Module.";
        }
    }
}
