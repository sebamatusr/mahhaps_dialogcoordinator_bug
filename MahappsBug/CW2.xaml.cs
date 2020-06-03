using MahappsBug.ViewModels;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.SimpleChildWindow;
using System.Windows;

namespace MahappsBug
{
    /// <summary>
    /// Interaction logic for CW2.xaml
    /// </summary>
    public partial class CW2 : ChildWindow
    {
        private IDialogCoordinator dc;

        public CW2()
        {
            InitializeComponent();
        }

        public CW2(IDialogCoordinator dc)
        {
            InitializeComponent();

            this.dc = dc;
            DataContext = new CW2VM(dc);
        }

    }
}
