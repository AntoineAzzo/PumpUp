using BonusLib.Concrete;
using BonusLib.Enum;
using BonusLib.Interfaces;
using System;

namespace BonusLib.Factories
{
    public class BonusFactory
    {
        public virtual IBonus CreateBonusFactory(BonusTypeEnum type, IDbConnectionFactory conn)
        {
            switch (type)
            {
                case BonusTypeEnum.WelcomeBonus:
                    return new WelcomeBonus(conn);

                default:
                    throw new Exception("Invalid");
            }
            throw new Exception("Invalid");
        }
    }
}