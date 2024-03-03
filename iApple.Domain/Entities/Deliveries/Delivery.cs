using iApple.Domain.Commons;

namespace iApple.Domain.Entities.Deliveries;

public class Delivery : Auditable
{
    public string Status { get; set; }
    public string Address { get; set; }
    public DateTime Date {  get; set; }
    public long PurchaseId { get; set; }
    public decimal DeliveryCost { get; set; }
}
