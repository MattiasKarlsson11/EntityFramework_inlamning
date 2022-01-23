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
using EntityFramework.Services;

namespace EntityFramework.Views
{
    /// <summary>
    /// Interaction logic for Viewcustomers.xaml
    /// </summary>
    public partial class Viewcustomers : UserControl
    {
        private readonly IUserService userService = new UserService();
        public Viewcustomers()
        {
            InitializeComponent();
            lvCustomers.Items.Clear();
            foreach (var user in userService.GetAll())
            {
                lvCustomers.Items.Add(user);
            }
        }
    }
}
