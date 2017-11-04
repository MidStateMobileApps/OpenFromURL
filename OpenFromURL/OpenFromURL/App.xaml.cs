using Xamarin.Forms;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Akavache;
using System.Collections.Generic;

namespace OpenFromURL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Task.Run(() =>
            {
                OnStart();
            });

            MainPage = new NavigationPage(new OpenFromURLPage());
        }

        protected async override void OnStart()
        {
            //await BlobCache.UserAccount.InsertObject("AppName", "Cranker");

            try {
                var schools = await BlobCache.UserAccount.GetObject<IEnumerable<WTCSSchool>>("WTCSSChools"); 
            }
            catch (KeyNotFoundException ex)
            {
                List<WTCSSchool> schools = WTCSSchool.WTCSSChools;
                await BlobCache.UserAccount.InsertObject("WTCSSChools", schools); 
            }

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
