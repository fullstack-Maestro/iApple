using iApple.Service.DTOs.DebitCard;

namespace iApple.Service.Interfaces;

public interface IDebitcardService
{
    ValueTask<bool> DeleteAsync(int id);
    ValueTask<bool> IsCardExpiredAsync(int id);
    ValueTask<DebitCardViewModel> GetByIdAsync(int id);
    ValueTask<List<DebitCardViewModel>> GetAllCardsAsync();
    ValueTask<DebitCardViewModel> UpgradeBalanceAsync(int id, decimal amount);
    ValueTask<DebitCardViewModel> DegradeBalanceAsync(int id, decimal amount);
    ValueTask<DebitCardViewModel> CreateAsync(DebitCardCreationModel cardCreation);
    ValueTask<DebitCardViewModel> UpdateAsync(int id, DebitCardUpdateModel cardUpdate);
}