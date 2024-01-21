using Akavache;
using MarvelHeroes.Infrastructure.Interfaces;
using MarvelHeroes.Infrastructure.Services;
using MarvelHeroes.SDK.Model;
using MarvelHeroes.Views;
using Paging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MarvelHeroes.ViewModels
{
    /// <summary>
    /// View Model for Main Page, inherits <see cref="ViewModelBase" />
    /// </summary>
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ICharacterService _service;
        private readonly PagingInfo _pagingInfo;

        private int currentPage = 1;
        private string firstLabel = "1";
        private string secondLabel = "2";
        private string thirdLabel = "3";
        private Color firstLabelColor = Color.FromHex("d42026");
        private Color firstLabelTextColor = Color.White;
        private Color secondLabelColor = Color.White;
        private Color secondLabelTextColor = Color.FromHex("d42026");
        private Color thirdLabelColor = Color.White;
        private Color thirdLabelTextColor = Color.FromHex("d42026");

        private string searchText = string.Empty;
        private ObservableCollection<HeroViewModel> heroes;

        public string FirstLabel
        {
            get => firstLabel;
            set => SetProperty(ref firstLabel, value);
        }
        public string SecondLabel
        {
            get => secondLabel;
            set => SetProperty(ref secondLabel, value);
        }
        public string ThirdLabel
        {
            get => thirdLabel;
            set => SetProperty(ref thirdLabel, value);
        }

        public Color FirstLabelColor
        {
            get => firstLabelColor;
            set => SetProperty(ref firstLabelColor, value);
        }
        public Color SecondLabelColor
        {
            get => secondLabelColor;
            set => SetProperty(ref secondLabelColor, value);
        }
        public Color ThirdLabelColor
        {
            get => thirdLabelColor;
            set => SetProperty(ref thirdLabelColor, value);
        }
        public Color FirstLabelTextColor
        {
            get => firstLabelTextColor;
            set => SetProperty(ref firstLabelTextColor, value);
        }
        public Color SecondLabelTextColor
        {
            get => secondLabelTextColor;
            set => SetProperty(ref secondLabelTextColor, value);
        }
        public Color ThirdLabelTextColor
        {
            get => thirdLabelTextColor;
            set => SetProperty(ref thirdLabelTextColor, value);
        }
        public int CurrentPage
        {
            get => currentPage;
            set => SetProperty(ref currentPage, value, nameof(CurrentPage));
        }

        public string SearchText
        {
            get => searchText;
            set => SetProperty(ref searchText, value, nameof(SearchText));
        }

        public ObservableCollection<HeroViewModel> Heroes
        {
            get => heroes;
            set => SetProperty(ref heroes, value, nameof(Heroes));
        }

        public ICommand SearchByNameCommand
        {
            get => new Command(async () => await ExecuteSearchByNameCommand());
        }


        public ICommand PreviousPageCommand
        {
            get => new Command(async () => await ExecutePreviousPageCommand());
        }

        public ICommand NextPageCommand
        {
            get => new Command(async () => await ExecuteNextPageCommand());
        }


        public ICommand RefreshCommand
        {
            get => new Command(async () => await ExecuteRefreshCommand());
        }
        public int Limit { get; private set; }

        public MainPageViewModel(ICharacterService service)
        {
            this._service = service;
            this._pagingInfo = new PagingInfo
            {
                CurrentPage = currentPage,
                ItemsPerPage = 4,
            };
            Task.Run(async () => await LoadData());
        }

        private async Task ExecuteNextPageCommand()
        {
            
            //do not increment last page
            if (CurrentPage < Limit)
            {
                CurrentPage++;
            }
            
            // do not update labels on navigation to the last page 
            if (CurrentPage > 1 && CurrentPage <= (Limit - 1))
            {
                FirstLabelColor = Color.White;
                SecondLabelColor = Color.FromHex("d42026");
                ThirdLabelColor = Color.White;
                FirstLabel = (CurrentPage - 1).ToString();
                SecondLabel = (CurrentPage).ToString();
                ThirdLabel = (CurrentPage + 1).ToString();
                FirstLabelTextColor = Color.FromHex("d42026");
                SecondLabelTextColor = Color.White;
                ThirdLabelTextColor = Color.FromHex("d42026");
            }

            //on navigation to last page update only colors
            if (CurrentPage == Limit)
            {
                FirstLabelColor = Color.White;
                SecondLabelColor = Color.White;
                ThirdLabelColor = Color.FromHex("d42026");
                FirstLabelTextColor = Color.FromHex("d42026");
                SecondLabelTextColor =Color.FromHex("d42026");
                ThirdLabelTextColor = Color.White;
            }
            this._pagingInfo.CurrentPage = CurrentPage;

            await DoSearch();
        }
        private async Task ExecutePreviousPageCommand()
        {
            //do not decrement first page
            if (CurrentPage > 1)
            {
                CurrentPage--;
                FirstLabelColor = Color.White;
                SecondLabelColor = Color.FromHex("d42026");
                ThirdLabelColor = Color.White;
                FirstLabelTextColor = Color.FromHex("d42026");
                SecondLabelTextColor = Color.White;
                ThirdLabelTextColor = Color.FromHex("d42026");
            }

            if (CurrentPage == 1)
            {
                FirstLabelColor = Color.FromHex("d42026");
                SecondLabelColor = Color.White;
                ThirdLabelColor = Color.White;
                FirstLabelTextColor = Color.White;
                SecondLabelTextColor = Color.FromHex("d42026");
                ThirdLabelTextColor = Color.FromHex("d42026");
            }

            if (CurrentPage <= 2)
            {
                FirstLabel = CurrentPage == 1 ? (CurrentPage).ToString() : (CurrentPage - 1).ToString();
                SecondLabel = CurrentPage == 1 ? (CurrentPage + 1).ToString() : (CurrentPage).ToString();
                ThirdLabel = CurrentPage == 1 ? (CurrentPage + 2).ToString() : (CurrentPage + 1).ToString();
                this._pagingInfo.CurrentPage = CurrentPage;
                await DoSearch();
                return;
            }
            
            if (CurrentPage > 2 && CurrentPage <= Limit)
            {
                FirstLabel = (CurrentPage - 1).ToString();
                SecondLabel = (CurrentPage).ToString();
                ThirdLabel = (CurrentPage + 1).ToString();
                this._pagingInfo.CurrentPage = CurrentPage;
                await DoSearch();
                return;
            }
        }
   
        private async Task DoSearch()
        {
            if (string.IsNullOrEmpty(SearchText) || string.IsNullOrWhiteSpace(SearchText))
            {
                await Task.Run(async () => await LoadData(null, 4, CurrentPage * 4));
                return;
            }
            if (!string.IsNullOrEmpty(SearchText) && !string.IsNullOrWhiteSpace(SearchText))
            {
                await Task.Run(async () => await LoadData(SearchText, 4, CurrentPage * 4));
                return;
            }
        }
         
        private async Task ExecuteRefreshCommand() =>
            await LoadData(string.IsNullOrEmpty(SearchText) || string.IsNullOrWhiteSpace(SearchText) ?
                null : SearchText,
                4,
                CurrentPage * 4 - 4);

        private async Task ExecuteSearchByNameCommand() => await Task.Run(SearchData);
        
        public void SearchData()
        {
            IsBusy = true;

            var characters = _service.GetCharacters(SearchText, 4, 0);
            Heroes = new ObservableCollection<HeroViewModel>
                    (from h in characters.OrderBy(x => x.Id)
                     select new HeroViewModel()
                     {
                         Id = h.Id.Value,
                         Name = h.Name,
                         Thumbnail = h.Thumbnail.Path + "." + h.Thumbnail.Extension,
                         Description = h.Description
                     });

            IsBusy = false;
        }

        public async Task LoadData(string filter = null, int limit = 0, int offset = 0)
        {
            IsBusy = true;
            var cache = Akavache.BlobCache.LocalMachine;
            var cachedCharacters = cache.GetAndFetchLatest("CharacterList" + filter,
                async () => await _service.GetPagedCharactersAsync(new PagingInfo
                {
                    CurrentPage = currentPage,
                    ItemsPerPage = 4,
                }),
                ofset =>
                {
                    TimeSpan elapsed = DateTimeOffset.Now - ofset;
                    return elapsed > new TimeSpan(hours: 0, minutes: 10, seconds: 0);
                });

            var result = await cachedCharacters.Where(p => CurrentPage == p.CurrentPage).FirstOrDefaultAsync();

            if (result != null)
            {
                Limit = result.TotalPages;
                Heroes = new ObservableCollection<HeroViewModel>(
                    (from h in result.Items.OrderBy(x => x.Id)
                     select new HeroViewModel()
                     {
                         Id = h.Id.Value,
                         Thumbnail = h.Thumbnail.Path + "." + h.Thumbnail.Extension,
                         Name = h.Name,
                         Description = h.Description
                     })); 
                IsBusy = false;
                return;
            }

            if (result is null || result.TotalCount == 0)
            {
                PaginationSet<Character> characters = await _service.GetPagedCharactersAsync(new PagingInfo
                {
                    CurrentPage = currentPage,
                    ItemsPerPage = 4,
                });
                Limit = characters.TotalPages;
                Heroes = new ObservableCollection<HeroViewModel>
                    (from h in characters.Items.OrderBy(x => x.Id)
                     select new HeroViewModel()
                     {
                         Id = h.Id.Value,
                         Name = h.Name,
                         Thumbnail = h.Thumbnail.Path + "." + h.Thumbnail.Extension,
                         Description = h.Description
                     });
                IsBusy = false;
                return;

            } 
        }
    }
}
