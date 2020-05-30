using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Data;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


namespace XFAppCenterPractice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start(
                "ios={Your App Secret};android={f158d610-ae63-483e-8678-12d683ac38c7};uwp={Your App Secret}",
                typeof(Analytics),
                typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
