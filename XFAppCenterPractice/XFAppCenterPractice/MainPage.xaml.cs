using Microsoft.AppCenter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFAppCenterPractice.Models;

namespace XFAppCenterPractice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            User user = new User { Name = "Alex", Email = "alex@appcenter.ms", PhoneNumber = "+1-(855)-555-5555" };
            var a = await Data.CreateAsync(user.Id.ToString(), user, DefaultPartitions.UserDocuments);

        }
    }
}
