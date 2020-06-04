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
    public class CW3VM : BaseViewModel
    {
        public IDialogCoordinator dc { get; }
        public IAsyncCommand OpenCW4 { get; set; }
        public IAsyncCommand OpenDialog { get; set; }

        public CW3VM(IDialogCoordinator dc)
        {
            this.dc = dc;
            OpenCW4 = new AsyncCommand(OpenCW1Exec);
            OpenDialog = new AsyncCommand(OpenDialogExec);
        }

        private async Task<bool> OpenDialogExec()
        {
            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "Aceptar",
                AnimateShow = false,
                AnimateHide = false,
            };

            var result = await dc.ShowMessageAsync(
                this,
                "title",
                "label",
                MessageDialogStyle.Affirmative,
                mySettings);

            return result == MessageDialogResult.Affirmative;
        }

        private Task OpenCW1Exec()
        {
            return Application.Current.MainWindow.ShowChildWindowAsync<bool>(new CH4(dc));
        }
    }
}
