using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlowerShop.Models;
using FlowerShop.Services;
using System.Collections.ObjectModel;

namespace FlowerShop.ViewModels
{
    [QueryProperty(nameof(FromSearch), nameof(FromSearch))]
    public partial class FlowersDetailsViewModels : ObservableObject
    {
        private readonly FlowerService _flowerService;
        public FlowersDetailsViewModels(FlowerService flowerService)
        {
            _flowerService = flowerService;
            Flowers = new(_flowerService.GetAllFlowers());
        }
        public ObservableCollection<FlowersModel> Flowers { get; set; }

        [ObservableProperty]
        private bool _fromSearch;

        [ObservableProperty]
        private bool _searching;

        [RelayCommand]
        private async Task SearchFlowers(string searchTerm)
        {
            Flowers.Clear();
            Searching = true;
            foreach(var flower in _flowerService.SearchFlowers(searchTerm))
            {
                Flowers.Add(flower);
            }
            Searching = false;
        }


    }
}
