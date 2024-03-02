using iApple.Domain.Commons;

namespace iApple.Domain.Entities.Purchase;
public class Purchase : Auditable
{
    public long UserId { get; set; }
    public long CardId { get; set; }
    public long OrderId { get; set; }
    public decimal TotalAmount { get; set; }
}