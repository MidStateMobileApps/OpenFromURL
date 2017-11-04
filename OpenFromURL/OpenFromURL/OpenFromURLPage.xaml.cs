using System.Collections.Generic;
using Xamarin.Forms;
using Akavache;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace OpenFromURL
{
    public partial class OpenFromURLPage : ContentPage
    {
        public OpenFromURLPage()
        {
            InitializeComponent();
            lister.ItemSelected += Lister_ItemSelected;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Device.StartTimer(TimeSpan.FromMilliseconds(250), () =>
            {
                Task.Factory.StartNew(async () =>
                {
                    await HandleFunc();
                });
                return false;
            });

        }

        async Task<bool> HandleFunc()
        {
            var schools = await BlobCache.UserAccount.GetObject<IEnumerable<WTCSSchool>>("WTCSSChools");
            Device.BeginInvokeOnMainThread(() =>
            {
                lister.ItemsSource = schools;
            });

            return false;
        }

        void Lister_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string sName = (e.SelectedItem as WTCSSchool).url;
            Navigation.PushAsync(new Webber(sName));
        }
    }
}
