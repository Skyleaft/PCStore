using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;
using PCStore.viewPage;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            content.Children.Clear();
            UserControl usc = null;

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "listViewSetting":
                    usc = new page_setting();
                    content.Children.Add(usc);

                    break;
                case "ItemCreate":
                    
                    break;
                default:
                    break;
            }
        }



        private void MenuToggleButton_Checked(object sender, RoutedEventArgs e)
        {

            
        }

        private void MenuToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuToggleButton.IsChecked == true)
            {
                Storyboard sb = this.FindResource("menu_open") as Storyboard;
                sb.Begin();
            }
            else
            {
                Storyboard sb = this.FindResource("menu_close") as Storyboard;
                sb.Begin();
            }
        }
    }
}
