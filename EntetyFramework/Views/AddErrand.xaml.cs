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
using EntityFramework.Models;

namespace EntityFramework.Views
{
    /// <summary>
    /// Interaction logic for AddErrand.xaml
    /// </summary>
    public partial class AddErrand : UserControl
    {
        private readonly IUserService userService = new UserService();
        private readonly IErrandServices errandServices = new ErrandServices();
        public AddErrand()
        {
            InitializeComponent();
            CBCustomer.SelectedValuePath = "Key";
            CBCustomer.DisplayMemberPath = "Value";
            EmptyFields();

            PopulateRoles();
        }


        private void AddErrandBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(AddErrandTitle.Text) &&
               !string.IsNullOrEmpty(AddErrandDescription.Text)&&
               !string.IsNullOrEmpty(AddErrandStatus.Text))
            {
                if (errandServices.Create(AddErrandTitle.Text, AddErrandDescription.Text, AddErrandStatus.Text, (int)CBCustomer.SelectedValue))
                {
                    EmptyFields();
                }
                
            }
        }
        private void EmptyFields()
        {
            AddErrandTitle.Text = "";
            AddErrandDescription.Text = "";
            AddErrandStatus.Text = "";

        }
        private void PopulateRoles()
        {
            CBCustomer.Items.Clear();
            foreach(var customer in userService.GetAll())
                CBCustomer.Items.Add(new KeyValuePair<int, string>(customer.Id, customer.CustomerFullName));
           
        }
    }
}
