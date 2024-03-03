using iApple.Service.DTOs.Orders;

namespace iApple.Service.Interfaces;

public interface IOrderService
{
    ValueTask<bool> DeleteAsync(int id);
    ValueTask<OrderViewModel> GetByIdAsync(int id);
    ValueTask<List<OrderViewModel>> GetAllOrdersAsync();
    ValueTask<List<OrderViewModel>> GetUserOrders(int userId);
    ValueTask<OrderViewModel> CreateAsync(OrderCreationModel orderCreation);
    ValueTask<OrderViewModel> UpdateAsync(int id, OrderUpdateModel orderUpdate);
}