using System;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchScorers
{

    public enum FeatureMatchScorerType { EditDistance }
    public enum FeatureMatchScorerSubType { LevenshteinEditDistance }
    public enum FeatureMatchAddressRangeResultType { Unknown, WithinRange, OutsideRange, }
    public enum FeatureMatchAddressParityResultType { Unknown, CorrectParity, IncorrectParity, }
    public enum FeatureMatchAddressRangePreferredEndResultType { Unknown, HiEnd, LoEnd, }
    public enum FeatureMatchAddressRangePreferredAddressRangeResultType { Unknown, AddressRange, HouseNumber, Super }
    public enum AddressNumberType { Unknown, Number, Fractional}

    
}
