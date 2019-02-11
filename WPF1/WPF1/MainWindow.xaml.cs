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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Form> forms = new List<Form>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string name, address;
            int zipCode;
            bool isFormValid = true;

            name = nameBox.Text;
            address = addressBox.Text;
            zipCode = Convert.ToInt32(zipBox.Text);

            if(name == "" || name == string.Empty)
            {
                MessageBox.Show("Please input yourn name");
                nameBox.Focus();
                //return;
                isFormValid = false;
            }
            if (address == "")
            {
                MessageBox.Show("Please input your address");
                isFormValid = false;
            }
            if (isFormValid == false)
            {
                return;
            }

            Form individual = new Form();
            individual.Name = name;
            individual.Address = address;
            individual.ZipCode = zipCode;

            list.Items.Add(individual);
            //list.Items.Add(addressBox.Text);
            //list.Items.Add(zipBox.Text);
        }
    }
}
