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
    /// Interaction logic for CH3.xaml
    /// </summary>
    public partial class CH3 : ChildWindow
    {
        private IDialogCoordinator dc;

        public CH3()
        {
            InitializeComponent();
        }

        public CH3(IDialogCoordinator dc)
        {
            InitializeComponent();

            this.dc = dc;
            DataContext = new CW3VM(dc);
        }
    }
}
