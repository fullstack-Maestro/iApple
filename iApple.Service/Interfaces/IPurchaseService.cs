using iApple.Service.DTOs.Purchases;

namespace iApple.Service.Interfaces;

public interface IPurchaseService
{
    ValueTask<bool> DeleteAsync(int id);
    ValueTask<PurchaseViewModel> GetByIdAsync(int id);
    ValueTask<List<PurchaseViewModel>> GetAllPurchasesAsync();
    ValueTask<PurchaseViewModel> CreateAsync(PurchaseCreationModel purchaseCreation);
    ValueTask<PurchaseViewModel> UpdateAsync(int id, PurchaseUpdateModel purchaseUpdate);
}
