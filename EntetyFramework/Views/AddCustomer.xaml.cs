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
using EntityFramework.Database;
using EntityFramework.Services;

namespace EntityFramework.Views
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : UserControl
    {
        private readonly IUserService userService = new UserService();
        public AddCustomer()
        {
            
            InitializeComponent();
            EmtyFields();
        }

        private void TextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (
                !string.IsNullOrEmpty(AddCustomerFirstName.Text) &&
                !string.IsNullOrEmpty(AddCustomerLastName.Text) &&
                !string.IsNullOrEmpty(AddCustomerEmail.Text) &&
                !string.IsNullOrEmpty(AddCustomerPhoneNumber.Text) &&
                !string.IsNullOrEmpty(AddAdress.Text) &&
                !string.IsNullOrEmpty(AddPostalCode.Text) &&
                !string.IsNullOrEmpty(AddCity.Text) &&
                !string.IsNullOrEmpty(AddCountry.Text)
                )
            {
                if (userService.Create(AddCustomerFirstName.Text, AddCustomerLastName.Text, AddCustomerEmail.Text, AddCustomerPhoneNumber.Text, AddAdress.Text, AddPostalCode.Text, AddCity.Text, AddCountry.Text))
                    EmtyFields();
                else
                    CustomerLabelError.Content = "This email is already registerd";          
            }
        }
        private void EmtyFields()
        {
            AddCustomerFirstName.Text = "";
            AddCustomerLastName.Text = "";
            AddCustomerEmail.Text = "";
            AddCustomerPhoneNumber.Text = "";
            AddAdress.Text = "";
            AddPostalCode.Text = "";
            AddCity.Text = "";
            AddCountry.Text = "";
        }
        
    }
}
