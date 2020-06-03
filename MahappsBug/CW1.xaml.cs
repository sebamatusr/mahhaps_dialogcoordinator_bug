using MahappsBug.ViewModels;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.SimpleChildWindow;
using System.Linq;
using System.Windows;

namespace MahappsBug
{
    /// <summary>
    /// Interaction logic for CW1.xaml
    /// </summary>
    public partial class CW1 : ChildWindow
    {
        public CW1(IDialogCoordinator coordinator)
        {
            InitializeComponent();
            DataContext = new CW1VM(coordinator);
        }
    }
}
