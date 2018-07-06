namespace BonusLib.Models
{
    public class WelcomeBonusModel : CommonBonusModel
    {
        public WelcomeBonusModel()
        {
            _internalType = Enum.BonusTypeEnum.WelcomeBonus;
        }

        public int? WelcomeBonusId { get; set; } = null;
    }
}