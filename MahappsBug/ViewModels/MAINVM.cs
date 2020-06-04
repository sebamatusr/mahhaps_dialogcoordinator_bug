using AsyncAwaitBestPractices.MVVM;
using MahappsBug;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.SimpleChildWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MahappsBug.ViewModels
{
    public class MAINVM : BaseViewModel
    {
        public IDialogCoordinator dc { get; }
        public IAsyncCommand OpenCW1 { get; set; }

        public MAINVM(IDialogCoordinator dc)
        {
            this.dc = dc;
            OpenCW1 = new AsyncCommand(OpenCW1Exec);
        }

        private Task OpenCW1Exec()
        {
            return Application.Current.MainWindow.ShowChildWindowAsync<bool>(new CW1(dc));
        }
    }
}
