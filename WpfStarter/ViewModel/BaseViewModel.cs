using System;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Input;

namespace it.starter.ViewModel
{
    public class BaseViewModel : DependencyObject, INotifyPropertyChanged
    {
        public virtual string NameClass
        {
            get { return "BaseViewModel"; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyProperty(string property)
        {
            if (ViewModelChildren != null)
                ViewModelChildren.NotifyProperty("");

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));


        }

        public Window View { get; set; }

        public UserControl ContentParent { get; set; }
        public BaseViewModel ViewModelParent { get; set; }
        public BaseViewModel ViewModelChildren { get; set; }

        private UserControl _content;

        public void Invalidate()
        {
            Execute(delegate ()
            {
                CommandManager.InvalidateRequerySuggested();
            });
        }

        public UserControl Content
        {
            get { return _content; }
            set
            {
                _content = value;
                NotifyProperty("Content");
            }
        }

        public void Execute(Action action)
        {
            try
            {
                Dispatcher dispatcherApplication = Application.Current.Dispatcher;
                dispatcherApplication.Invoke(action);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
