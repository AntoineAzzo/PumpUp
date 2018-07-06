using BonusLib.Interfaces;
using BonusLib.Models;
using System;
using Dapper;

namespace BonusLib.Abstarctions
{
    public abstract class Bonus : IBonus
    {
        public static IDbConnectionFactory _conn;
        public bool SaveBonus(CommonBonusModel bonus)
        {
            if (SaveCommon(bonus))
            {
                if (SaveLocal(bonus))
                    return true;
            }
            return false;
        }

        public abstract CommonBonusModel GetLocal(int BonusId);

        public abstract void UpdateBonusLocal();

        public abstract void InsertBonusLocal();

        private bool SaveCommon(CommonBonusModel bonus)
        {
            var bonusid = bonus.BonusId;
            if (bonus.BonusId == null)
            {
                InsertBonusCommon();
                InsertBonusRestrictions();
            }
            else
            {
                UpdateBonusCommon();
                UpdateBonusRestrictions();
            }
            return true;
        }

        private void UpdateBonusRestrictions()
        {
            throw new NotImplementedException();
        }

        private void InsertBonusRestrictions()
        {
            throw new NotImplementedException();
        }

        private bool SaveLocal(CommonBonusModel bonus)

        {
            if (bonus.BonusId == null)
            {
                InsertBonusLocal();
            }
            else
            {
                UpdateBonusLocal();
            }
            return true;
        }

        private void UpdateBonusCommon()
        {
            throw new NotImplementedException();
        }

        private void InsertBonusCommon()
        {
            var cnn = _conn.CreateDbConnection();
            cnn.Query("");

            throw new NotImplementedException();
        }

        public CommonBonusModel GetBonus(int BonusId)
        {
            throw new NotImplementedException();
        }
    }
}