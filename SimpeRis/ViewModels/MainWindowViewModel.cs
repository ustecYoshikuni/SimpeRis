using Prism.Mvvm;

namespace SimpeRis.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "超簡易RIS";
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
