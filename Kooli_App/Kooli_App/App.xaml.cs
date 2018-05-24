using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Kooli_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage() { BarTextColor = Color.White };
        }

        protected override void OnStart()
        {
            AppCenter.Start("uwp=2b72cf37-1caa-4790-a28a-cdcf7b6dfe26;" +
                  "android={Your Android App secret here}" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics));
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
