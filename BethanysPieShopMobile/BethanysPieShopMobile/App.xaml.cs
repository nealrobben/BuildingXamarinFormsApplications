﻿using Xamarin.Forms;

namespace BethanysPieShopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ContentPageView();
            //MainPage = new NavigationPage(new NavigationPageView());
            //MainPage = new TabbedPageView();
            //MainPage = new MasterDetailPageView();
            MainPage = new CarouselPageView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
