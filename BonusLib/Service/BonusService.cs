using BonusLib.Concrete;
using BonusLib.Factories;
using BonusLib.Interfaces;
using BonusLib.Models;

namespace BonusLib.Service
{
    public class BonusService
    {
        private static IDbConnectionFactory _conn;

        public BonusService() : this(_conn ?? new DBConnectionFactory())
        {

        }

        private BonusService(IDbConnectionFactory conn)
        {
            _conn = conn;
        }
        public bool SaveService(CommonBonusModel bonus)
        {
            var actionBonus = new BonusFactory().CreateBonusFactory(bonus.Type, _conn);

            switch (bonus.Type)
            {
                case Enum.BonusTypeEnum.WelcomeBonus:
                    return actionBonus.SaveBonus(new WelcomeBonusModel { BonusId = 1, WelcomeBonusId = 1 });
            }

            return false;
        }
    }
}