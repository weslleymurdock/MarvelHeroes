using MarvelHeroes.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MarvelHeroes.ViewModels
{
    /// <summary>
    /// View Model for Hero item in HeroPage, inherits <see cref="ViewModelBase" />
    /// </summary>
    public class HeroViewModel : ViewModelBase
    {
        private int id;
        private string description;
        private string name;
        private string thumbnail;

        public ICommand PreviousPageCommand 
        {
            get => new Command(async () => await ExecutePreviousPageCommand()); 
        }
        public ICommand HeroPageCommand
        {
            get => new Command(async () => await ExecuteHeroPageCommand());
        }

        public string Description
        {
            get => this.description; set => SetProperty(ref this.description, value, nameof(Description));
        }
        public int Id
        {
            get => this.id; set => SetProperty(ref this.id, value, nameof(Id));
        }

        public string Name
        {
            get => this.name; set => SetProperty(ref this.name, value, nameof(Name));
        }
         
        public string Thumbnail
        {
            get => this.thumbnail; set => SetProperty(ref this.thumbnail, value, nameof(Thumbnail));
        }

        private async Task ExecutePreviousPageCommand()
        {
             await App.Navigation.PopAsync();
        }

        private async Task ExecuteHeroPageCommand()
        { 
            await App.Navigation.PushAsync(new HeroPage() { BindingContext = this });
        }

    }
}
