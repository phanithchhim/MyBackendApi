using MyBackendApi.Data;
using MyBackendApi.Models;
using MyBackendApi.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyBackendApi.Services.Implementations
{
    public class ShopService : IShopService
    {
        private readonly AppDbContext _context;

        public ShopService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Shop> GetAllShops()
        {
            return _context.Shops.ToList();
        }

        public Shop GetShopById(int id)
        {
            return _context.Shops.Find(id);
        }

        public void AddShop(Shop shop)
        {
            _context.Shops.Add(shop);
            _context.SaveChanges();
        }

        public void UpdateShop(Shop shop)
        {
            _context.Shops.Update(shop);
            _context.SaveChanges();
        }

        public void DeleteShop(int id)
        {
            var shop = _context.Shops.Find(id);
            if (shop != null)
            {
                _context.Shops.Remove(shop);
                _context.SaveChanges();
            }
        }
    }
}


//using System.Collections.Generic;
//using System.Linq;
//using MyBackendApi.Data;
//using MyBackendApi.Models;
//using MyBackendApi.Services.Interfaces;

//namespace MyBackendApi.Services.Implementations
//{
//    public class ShopService : IShopService
//    {
//        private readonly AppDbContext _context;

//        public ShopService(AppDbContext context)
//        {
//            _context = context;
//        }

//        public Shop? GetShopById(int id)
//        {
//            // Ensure null handling
//            var shop = _context.Shops.Find(id);
//            if (shop == null)
//            {
//                // Log or handle the null case appropriately
//                return null; // or throw an exception
//            }
//            return shop;
//        }

//        public IEnumerable<Shop> GetAllShops()
//        {
//            return _context.Shops.ToList(); // Assume no nulls in the list
//        }

//        public void AddShop(Shop shop)
//        {
//            _context.Shops.Add(shop);
//            _context.SaveChanges();
//        }

//        public void UpdateShop(Shop shop)
//        {
//            _context.Shops.Update(shop);
//            _context.SaveChanges();
//        }

//        public void DeleteShop(int id)
//        {
//            var shop = _context.Shops.Find(id);
//            if (shop != null)
//            {
//                _context.Shops.Remove(shop);
//                _context.SaveChanges();
//            }
//        }
//    }
//}

