using Sample3.Model;
using Sample3.Utility;
using System.Windows;

namespace Sample3.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private RelayCommand _cmdPrint;
        private EMailModel _model = new EMailModel();

        public MainWindowViewModel()
        {
            // TODO
        }

        //  TODO CmdPrint Property

        public string ContentText
        {
            get { return _model.Content; }
            set
            {
                _model.Content = value;
                OnPropertyChanged("ContentText");
            }
        }

        private void Execute_Print()
        {
            MessageBox.Show("Dokument wird gedruckt.", "Drucken");
            ContentText = "";
        }

        private bool CanExecute_Print()
        {
             return ContentText != "";
        }
    }
}
