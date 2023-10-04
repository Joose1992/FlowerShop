using CommunityToolkit.Mvvm.ComponentModel;
using FlowerShop.Models;
using FlowerShop.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly FlowerService _flowerService;
        public HomeViewModel(FlowerService flowerService)
        {
            _flowerService = flowerService;
            Flowers = new(_flowerService.GetAllFlowers());
        }

        public ObservableCollection<FlowersModel> Flowers { get; set; }
    }
}
