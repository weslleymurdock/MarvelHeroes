using CommunityToolkit.Mvvm.ComponentModel; 
namespace MarvelHeroes.ViewModels
{
    /// <summary>
    /// Base Classe with inheriths from <see cref="ObservableObject" /> to act as an base for all View Models
    /// </summary>
    public class ViewModelBase : ObservableObject
    {
        private bool isBusy;

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                SetProperty(ref isBusy, value, nameof(IsBusy));
            }
        }

    }
}
