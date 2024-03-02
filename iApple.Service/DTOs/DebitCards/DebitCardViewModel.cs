namespace iApple.Service.DTOs.DebitCard;

public class DebitCardViewModel
{
    public long Id { get; set; }
    public int CSV { get; set; }
    public long Number { get; set; }
    public long UserId { get; set; }
    public decimal Balance { get; set; }
    public string HolderName { get; set; }
    public string ExpiryDate { get; set; }
}