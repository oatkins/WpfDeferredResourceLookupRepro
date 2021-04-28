using System;
using System.Windows.Input;

namespace WpfDeferredResourceLookupRepro.ViewModels
{
    public sealed class RelayCommand : ICommand
    {
        private bool _canExecute = true;
        private readonly Action _executeAction;

        public RelayCommand(Action executeAction)
        {
            _executeAction = executeAction;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute
        {
            get => _canExecute;
            set
            {
                if (_canExecute != value)
                {
                    _canExecute = value;
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        bool ICommand.CanExecute(object parameter) => _canExecute;

        public void Execute(object parameter) => _executeAction?.Invoke();
    }
}
