using iApple.Domain.Commons;

namespace iApple.Domain.Entities.DebitCards;
public class DebitCard : Auditable
{
    public int CSV { get; set; }
    public long Number { get; set; }
    public long UserId { get; set; }
    public decimal Balance { get; set; }
    public string HolderName { get; set; }
    public string ExpiryDate { get; set; }
}