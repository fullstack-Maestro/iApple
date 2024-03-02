using iApple.Domain.Commons;

namespace iApple.Domain.Entities.Order;

public class Order : Auditable
{
    public long UserId { get; set; }
    public long DeviceId { get; set; }
    public long Quantity { get; set; }
}