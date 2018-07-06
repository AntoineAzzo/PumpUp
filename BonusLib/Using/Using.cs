using BonusLib.Models;

namespace BonusLib.Using
{
    internal class Using
    {
        public void Test()
        {
            var welcomebonus = new WelcomeBonusModel();

            new Service.BonusService().SaveService(welcomebonus);
        }
    }
}