using it.starter.view;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace it.starter.ViewModel
{
    public partial class MainViewModel
    {

        #region COMMANDs

        /// <summary>
        /// About window
        /// </summary>
        public ICommand AboutCommand { get; set; }

        #endregion

        private bool CanAboutCommand(object obj)
        {

            return true;
        }

        private void ExecuteAboutCommand(object obj)
        {
            AboutView aboutView = new AboutView();
            aboutView.ShowDialog();

        }

    }
}