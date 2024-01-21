using MarvelHeroes.ViewModels;
using Xamarin.Forms; 
using MarvelHeroes.Infrastructure.Services;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Client;
using MarvelHeroes.Infrastructure.Managers;
using System;
using Xamarin.Forms.Shapes;

namespace MarvelHeroes.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ApiClient client = new ApiClient();
            client.SetApiKey(UserSecretsManager.Settings["PublicKey"]);
            client.SetHash(UserSecretsManager.Settings["PrivateKey"]);
            BindingContext = ViewModel = new MainPageViewModel(new CharacterServiceStub(new MarvelPublicApi(client)));
        }
 
    }
}
