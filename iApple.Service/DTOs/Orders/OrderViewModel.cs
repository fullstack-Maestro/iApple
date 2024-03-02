namespace iApple.Service.DTOs.Orders;

public class OrderViewModel
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long DeviceId { get; set; }
    public long Quantity { get; set; }
}