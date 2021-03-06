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
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using App1.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Category : Page
    {
        public Category()
        {
            this.InitializeComponent();

            getcategory();
        }

        public async void getcategory()
        {
            List<CategoryData> lsCategory = new List<CategoryData>();
            CategoryService service = new CategoryService();
            for (int id = 1; id < 6; id++)
            {
                CategoryRoot catagoryRootdata = await service.getCategoryPage(id);
                if (catagoryRootdata != null)
                {
                    lsCategory.Add(catagoryRootdata.data);
                }
            }
            MNItems.ItemsSource = lsCategory;


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;

        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var foodId = (int)((Grid)sender).Tag;
            System.Diagnostics.Debug.WriteLine("foodId :" + foodId);
            Layout.staticFrame.Navigate(typeof(Pages.DetailFood), foodId);
        }
    }
}
