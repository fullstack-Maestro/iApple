namespace iApple.Service.DTOs.Purchases;

public class PurchaseCreationModel
{
    public long UserId { get; set; }
    public long CardId { get; set; }
    public long OrderId { get; set; }
    public decimal TotalAmount { get; set; }
}