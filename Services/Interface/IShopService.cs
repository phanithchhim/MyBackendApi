using System.Collections.Generic;
using MyBackendApi.Models;

namespace MyBackendApi.Services.Interfaces
{
    public interface IShopService
    {
        IEnumerable<Shop> GetAllShops();
        Shop GetShopById(int id);
        void AddShop(Shop shop);
        void UpdateShop(Shop shop);
        void DeleteShop(int id);
    }
}
