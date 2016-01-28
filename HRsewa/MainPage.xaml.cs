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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HRsewa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Home));
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                switch (radioButton.Tag.ToString())
                {
                    case "Home":
                        MainFrame.Navigate(typeof(Home));
                        break;
                    //case "Job":
                    //    MainFrame.Navigate(typeof(Job));
                    //    break;
                    //case "Policies":
                    //    MainFrame.Navigate(typeof(Policies));
                    //    break;
                    case "OrganizationList":
                        MainFrame.Navigate(typeof(ListofOrganization));
                        break;
                    case "Complain":
                        MainFrame.Navigate(typeof(Complain2));
                        break;
                        //case "Contact":
                        //    MainFrame.Navigate(typeof(Contact));
                        //    break;

                }
                MySplitView.IsPaneOpen = false;

            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            this.MySplitView.IsPaneOpen = this.MySplitView.IsPaneOpen ? false : true;
        }
    }
}
