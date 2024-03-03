namespace iApple.Service.DTOs.Orders;

public class OrderUpdateModel
{
    public long UserId { get; set; }
    public long DeviceId { get; set; }
    public long Quantity { get; set; }
}