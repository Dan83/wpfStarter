using it.starter.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace it.starter.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        private void InitializeCommands()
        {
            #region COMMANDs

            AboutCommand = new DelegateCommand(ExecuteAboutCommand, CanAboutCommand);

            #endregion
        }

        public MainViewModel()
        {
            //Initialize all commands
            InitializeCommands();

        }



    }
}
