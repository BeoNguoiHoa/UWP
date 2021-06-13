using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App1.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public static Frame staticFrame;
        public Layout()
        {
            this.InitializeComponent();
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            
            MN.Items.Add(new MenuItem { Name = "Home", MenuPage = "home" });
            MN.Items.Add(new MenuItem { Name = "Category", MenuPage = "category" });
            MN.Items.Add(new MenuItem { Name = "Delivery", MenuPage = "delivery" });
            MN.Items.Add(new MenuItem { Name = "Collection", MenuPage = "collection" });


        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e) 
        {
            staticFrame = MainFrame;
            MenuItem item = MN.SelectedItem as MenuItem;
           
            switch (item.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(Pages.DemoFetchApi), "day la trang chu"); break;
                case "category": MainFrame.Navigate(typeof(Pages.Category), "day la trang chu"); break;
                case "delivery": MainFrame.Navigate(typeof(Pages.Delivery), "Delivery"); break;
                case "collection": MainFrame.Navigate(typeof(Pages.Collection), "Delivery"); break;


            }
        }
    }
}
