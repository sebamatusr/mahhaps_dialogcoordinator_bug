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
    public class CW1VM : BaseViewModel
    {
        public IDialogCoordinator dc { get; }
        public IAsyncCommand OpenCW2 { get; set; }
        public IAsyncCommand OpenDialog { get; set; }

        public CW1VM(IDialogCoordinator dc)
        {
            this.dc = dc;
            OpenCW2 = new AsyncCommand(OpenCW1Exec);
            OpenDialog = new AsyncCommand(opendialogexec);

        }

        private async Task<bool> opendialogexec()
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
            return Application.Current.MainWindow.ShowChildWindowAsync<bool>(new CW2(dc));
        }
    }
}
