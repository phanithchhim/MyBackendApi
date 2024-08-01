using System.Collections.Generic;
using MyBackendApi.Models;

namespace MyBackendApi.Services.Interfaces
{
    public interface IDeliveryService
    {
        IEnumerable<Dilevery> GetAllDeliveries();
        Dilevery GetDeliveryById(int id);
        void AddDelivery(Dilevery delivery);
        void UpdateDelivery(Dilevery delivery);
        void DeleteDelivery(int id);
    }
}
