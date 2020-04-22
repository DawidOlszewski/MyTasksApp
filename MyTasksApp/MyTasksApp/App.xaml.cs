using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyTasksApp.Services;
using MyTasksApp.Views;

namespace MyTasksApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new TodayPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
