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
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Popups;
//using System.Windows.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HRsewa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NHRC : Page
    {
        public NHRC()
        {
            this.InitializeComponent();
        }

        private async void Pushpin_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e )
        {
            MessageDialog dialog = new MessageDialog("Hello from Seattle.");
            await dialog.ShowAsync();
        }
    }
    //protected override void OnNavigatedTo(NavigationEventArgs e)
    //{
    //}

    
}

