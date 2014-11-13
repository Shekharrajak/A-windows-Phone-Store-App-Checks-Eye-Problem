using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace contrast
{
    public partial class wateryEye : PhoneApplicationPage
    {
        public wateryEye()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            water.Navigate(new Uri ("http://www.healthline.com/health/watery-eyes"));
        }
    }
}