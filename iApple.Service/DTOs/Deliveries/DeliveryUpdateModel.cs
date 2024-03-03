namespace iApple.Service.DTOs.Deliveries;

public class DeliveryUpdateModel
{
    public DateTime Date { get; set; }
    public string Status { get; set; }
    public string Address { get; set; }
    public long PurchaseId { get; set; }
    public decimal DeliveryCost { get; set; }
}