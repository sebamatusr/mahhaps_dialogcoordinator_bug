using AsyncAwaitBestPractices.MVVM;
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
    public class CW4VM : BaseViewModel
    {
        public IDialogCoordinator dc { get; }
        public IAsyncCommand OpenDialog { get; set; }

        public CW4VM(IDialogCoordinator dc)
        {
            this.dc = dc;
            OpenDialog = new AsyncCommand(OpenCW1Exec);
        }

        private async Task<bool> OpenCW1Exec()
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
    }
}
