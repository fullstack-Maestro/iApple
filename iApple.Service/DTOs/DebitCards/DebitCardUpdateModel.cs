namespace iApple.Service.DTOs.DebitCard;

public class DebitCardUpdateModel
{
    public int CSV { get; set; }
    public long Number { get; set; }
    public long UserId { get; set; }
    public decimal Balance { get; set; }
    public string HolderName { get; set; }
    public string ExpiryDate { get; set; }
}
