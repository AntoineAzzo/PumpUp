using BonusLib.Abstarctions;
using BonusLib.Interfaces;
using BonusLib.Models;
using Dapper;
using System;

namespace BonusLib.Concrete
{
    internal class WelcomeBonus : Bonus
    {
        public WelcomeBonus(IDbConnectionFactory conn)
        {
            _conn = conn;
        }

        public override CommonBonusModel GetLocal(int BonusId)
        {
            return new WelcomeBonusModel();
        }

        public override void InsertBonusLocal()
        {
            
            var cnn = _conn.CreateDbConnection();
            cnn.Query("");
        }

        public override void UpdateBonusLocal()
        {
            throw new NotImplementedException();
        }
    }
}