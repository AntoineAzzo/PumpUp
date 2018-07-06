using BonusLib.Enum;
using System.Collections.Generic;

namespace BonusLib.Models
{
    public class CommonBonusModel
    {
        protected BonusTypeEnum _internalType;

        public int? BonusId { get; set; } = null;

        public BonusTypeEnum Type { get; }

        public IList<RestrictionOptionModel> Restrictions { get; set; }
    }
}