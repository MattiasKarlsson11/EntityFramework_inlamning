using EntityFramework.Services;
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

namespace EntityFramework.Views
{
    /// <summary>
    /// Interaction logic for ViewErrand.xaml
    /// </summary>
    public partial class ViewErrand : UserControl
    {
        
        private readonly IErrandServices errandServices = new ErrandServices();
        public ViewErrand()
        {
            InitializeComponent();
            lvErrands.Items.Clear();
            foreach (var errand in errandServices.GetAll())
            {
                lvErrands.Items.Add(errand);
            }
        }
    }
}
