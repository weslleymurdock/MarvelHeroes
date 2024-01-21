using CommunityToolkit.Mvvm.DependencyInjection;
using MarvelHeroes.Infrastructure.Interfaces;
using MarvelHeroes.Infrastructure.Services;
using MarvelHeroes.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;
using Refit;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.ViewModels;
using MarvelHeroes.Infrastructure.Managers;
namespace MarvelHeroes
{
    public sealed partial class App : Application
    {
        private bool _initialized = false;

        public static INavigation Navigation;
        public App()
        {
            InitializeComponent();
            // Register services
            if (_initialized)
            {
                return;
            }

            Ioc.Default.ConfigureServices(
                    new ServiceCollection()
                    //Services
                    .AddSingleton<IMarvelPublicApi, MarvelPublicApi>() 
                    .AddSingleton<ICharacterService, CharacterServiceStub>()
                    //.AddSingleton(RestService.For<IMarvelPublicApi>("https://gateway.marvel.com/"))
                    //ViewModels
                    .AddTransient<ViewModelBase>() 
                    .AddTransient<HeroViewModel>()
                    .AddTransient<MainPageViewModel>() 
                    .BuildServiceProvider());
            
            _initialized = true;

            MainPage = new NavigationPage(new MainPage());
            Navigation = MainPage.Navigation;
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
