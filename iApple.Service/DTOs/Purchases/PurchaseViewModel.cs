namespace iApple.Service.DTOs.Purchases;

public class PurchaseViewModel
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long CardId { get; set; }
    public long OrderId { get; set; }
    public decimal TotalAmount { get; set; }
}