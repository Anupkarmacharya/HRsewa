using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HRsewa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Complain1 : Page
    {
        public class HRsewaTable
        {
            public string FullName { get; set; }
            public string id { get; set; }
            public string EmailID { get; set; }
            public double ContactNo { get; set; }
            public int Age { get; set; }
            public string Nationality { get; set; }
            public string Issues { get; set; }

        }
        private MobileServiceCollection<HRsewaTable, HRsewaTable> item;
        private IMobileServiceTable<HRsewaTable> itemsTable =
            App.MobileService.GetTable<HRsewaTable>();
        public Complain1()
        {
            this.InitializeComponent();
        }

        private async Task InsertItem(HRsewaTable complain)
        {
            // This code inserts a new TodoItem into the database. When the operation completes
            // and Mobile App backend has assigned an Id, the item is added to the CollectionView.
            await itemsTable.InsertAsync(complain);
            await new MessageDialog("Data Saved").ShowAsync();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var item = new HRsewaTable { FullName = NameInput.Text };
        // Age = int.Parse(AgeInput.Text
        await InsertItem(item);
        }
    }
    
}
