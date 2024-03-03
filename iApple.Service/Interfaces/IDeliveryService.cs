using iApple.Service.DTOs.Deliveries;

namespace iApple.Service.Interfaces;

public interface IDeliveryService
{
    ValueTask<bool> DeleteAsync(int id);
    ValueTask<bool> MarkAsDelivered(int userId);
    ValueTask<DeliveryViewModel> GetByIdAsync(int id);
    ValueTask<List<DeliveryViewModel>> GetAllDeliveryReportsAsync();
    ValueTask<DeliveryViewModel> UpdateAddressAsync(int id, string  address);
    ValueTask<DeliveryViewModel> CreateAsync(DeliveryCreationModel deliveryCreation);
}