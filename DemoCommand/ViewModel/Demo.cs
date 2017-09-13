using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoCommand.ViewModel
{
    internal class Demo : INotifyPropertyChanged
    {
        private string _id;
        public event PropertyChangedEventHandler PropertyChanged;
        public DemoCommand Command { get; set; } = new DemoCommand();

        public string Id
        {
            get => _id;
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged();
                }
                Command.OnCanExecuteChanged();
            }

        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
