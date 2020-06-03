using MahappsBug.ViewModels;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.SimpleChildWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MahappsBug
{
    /// <summary>
    /// Interaction logic for CH4.xaml
    /// </summary>
    public partial class CH4 : ChildWindow
    {
        private IDialogCoordinator dialogCoordinator;

        public CH4()
        {
            InitializeComponent();
        }

        public CH4(IDialogCoordinator dialogCoordinator)
        {
            InitializeComponent();

            this.dialogCoordinator = dialogCoordinator;
            DataContext = new CW4VM(dialogCoordinator);
        }
    }
}
