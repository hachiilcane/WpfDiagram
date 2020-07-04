using Prism.Mvvm;

namespace WpfDiagram.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "WPF Diagram";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
