using System.Runtime.Serialization;
using IdokladSdk.Attributes;

namespace IdokladSdk.Enums
{
    /// <summary>
    /// Typy DPH
    /// </summary>
    /// <summary>
    /// Possible vat rate values
    /// </summary>
    [DataContract]
    public enum VatRateTypeEnum
    {
        /// <summary>
        /// Sn�en� sazba
        /// </summary>
        [EnumMember(Value = "0")]
        [Rank(1)]
        Reduced1
            = 0,

        /// <summary>
        /// Z�kladn� sazba
        /// </summary>
        [EnumMember(Value = "1")]
        [Rank(3)]
        Basic = 1,

        /// <summary>
        /// Nulov� sazba
        /// </summary>
        [EnumMember(Value = "2")]
        [Rank(0)]
        Zero = 2,

        /// <summary>
        /// Sn�en� sazba 2
        /// </summary>
        [EnumMember(Value = "3")]
        [Rank(2)]
        Reduced2 = 3
    }
}