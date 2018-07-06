using BonusLib.Models;

namespace BonusLib
{
    public interface IBonus
    {
        bool SaveBonus(CommonBonusModel Bonus);

        CommonBonusModel GetBonus(int BonusId);
    }
}