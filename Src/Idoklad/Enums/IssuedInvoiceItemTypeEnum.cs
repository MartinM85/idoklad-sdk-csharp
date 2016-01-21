﻿using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    /// <summary>
    /// Číselník typů položky dokladu
    /// </summary>
    /// <summary xml:lang="en">
    /// Invoice item types
    /// </summary>
    [DataContract]
    public enum IssuedInvoiceItemTypeEnum
    {
        /// <summary>
        /// Normální položka faktury
        /// </summary>
        [EnumMember(Value = "0")]
        ItemTypeNormal = 0,

        /// <summary>
        /// Zaokrouhlovací typ polozky
        /// </summary>
        [EnumMember(Value = "1")]
        ItemTypeRound = 1,

        /// <summary>
        /// Odpočtová položka
        /// </summary>
        /// <summary xml:lang="en">
        /// Reduced item for accounted by proforma invoices
        /// </summary>
        [EnumMember(Value = "2")]
        ItemTypeReduce = 2,

        /// <summary>
        /// Slevová položka
        /// </summary>
        [EnumMember(Value = "3")]
        ItemTypeDiscount = 3
    }
}