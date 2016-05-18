using System.Windows.Input;
using Caliburn.Micro;
using GalaSoft.MvvmLight.Command;

namespace CaliburnSampleApp
{
    public class MainPageViewModel : PropertyChangedBase
    {
        private string messageBlock;

        public MainPageViewModel()
        {
            MessageBlock = "Click a button to see a result here.";
        }

        public ICommand BindingButtonCommand => new RelayCommand(BindingButtonAction);

        private void BindingButtonAction()
        {
            MessageBlock = "BindingButton Clicked";
        }

        public void MessageAttachHandler()
        {
            MessageBlock = "MessageAttach Clicked";
        }

        public void ConventionButton()
        {
            MessageBlock = "Convention Button Clicked";
        }

        public string MessageBlock
        {
            get { return messageBlock; }
            set
            {
                if (value == messageBlock) return;
                messageBlock = value;
                NotifyOfPropertyChange();
            }
        }
        
    }
}