using FlowerShop.Models;

namespace FlowerShop.Services
{
    public class FlowerService
    {
        private readonly static IEnumerable<FlowersModel> _flowers = new List<FlowersModel>()
        {
            new FlowersModel
            {
                Name = "Flower 1",
                Image = "flower_one",
                Price = 39.99m
            },
            new FlowersModel
            {
                Name = "Flower 2",
                Image = "flower_two",
                Price = 19.99m
            },
            new FlowersModel
            {
                Name = "Flower 3",
                Image = "flower_three",
                Price = 49.99m
            },
            new FlowersModel
            {
                Name = "Flower 4",
                Image = "flower_four",
                Price = 14.99m
            },
            new FlowersModel
            {
                Name = "Flower 5",
                Image = "flower_five",
                Price = 9.99m
            },
            new FlowersModel
            {
                Name = "Flower 6",
                Image = "flower_six",
                Price = 9.99m
            },
            new FlowersModel
            {
                Name = "Flower 7",
                Image = "flower_seven",
                Price = 9.99m
            },
            new FlowersModel
            {
                Name = "Flower 8",
                Image = "flower_eight",
                Price = 9.99m
            }
        };

        public IEnumerable<FlowersModel> GetAllFlowers() => _flowers;

        public IEnumerable<FlowersModel> GetPupularFlowers(int count = 3) =>
            _flowers.OrderBy(p => Guid.NewGuid())
            .Take(count);

        public IEnumerable<FlowersModel> SearchFlowers(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _flowers
            : _flowers.Where(f => f.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
    }
}
