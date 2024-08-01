using System.Collections.Generic;
using System.Linq;
using MyBackendApi.Data;
using MyBackendApi.Models;
using MyBackendApi.Services.Interface;
using MyBackendApi.Services.Interfaces;

namespace MyBackendApi.Services.Implementations
{
    public class DeliveryService : IDeliveryService
    {
        private readonly AppDbContext _context;

        public DeliveryService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Dilevery> GetAllDeliveries()
        {
            return _context.Deliveries.ToList();
        }

        public Dilevery GetDeliveryById(int id)
        {
            return _context.Deliveries.Find(id);
        }

        public void AddDelivery(Dilevery delivery)
        {
            _context.Deliveries.Add(delivery);
            _context.SaveChanges();
        }

        public void UpdateDelivery(Dilevery delivery)
        {
            _context.Deliveries.Update(delivery);
            _context.SaveChanges();
        }

        public void DeleteDelivery(int id)
        {
            var delivery = _context.Deliveries.Find(id);
            if (delivery != null)
            {
                _context.Deliveries.Remove(delivery);
                _context.SaveChanges();
            }
        }
    }
}
