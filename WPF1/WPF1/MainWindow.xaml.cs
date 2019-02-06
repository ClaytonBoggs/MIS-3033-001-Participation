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
            Form individual = new Form();
            individual.Name = nameBox.Text;
            individual.Address = addressBox.Text;
            individual.ZipCode = Convert.ToInt32(zipBox.Text);
            list.Items.Add(nameBox.Text);
            list.Items.Add(addressBox.Text);
            list.Items.Add(zipBox.Text);
        }
    }
}
