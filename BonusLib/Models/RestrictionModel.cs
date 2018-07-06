using System.Collections.Generic;

namespace BonusLib.Models
{
    public class RestrictionOptionModel
    {
        public int? RestrictionOptionId { get; set; } = null;
        public int RestrictionType { get; set; }
        public bool IsIncluded { get; set; }
        public IList<RestrictionValueModel> RestrictionValues { get; set; }
    }
}