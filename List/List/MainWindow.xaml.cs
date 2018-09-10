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

namespace List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbx_Item_GotFocus(object sender, EventArgs e)
        {
            tbx_Item.Text = "";
            tbx_Item.Opacity = 1;
        }

        private void btn_ADD_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_Item.Text == "")
            {

            }
            else
            { 
                lbx_List.Items.Add(tbx_Item.Text);
                tbx_default();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_Item.Text == "")
            {
                lbx_List.Items.Remove(lbx_List.SelectedItem);
            }
            else
            {
                lbx_List.Items.Remove(tbx_Item.Text);
                tbx_default();
            }
        }
        private void tbx_default()
        {
            tbx_Item.Opacity = 0.5;
            tbx_Item.Text = "Item Name";
        }

    }
}
