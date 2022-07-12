using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AccountType", Namespace = "", AnonymousType = true)]
    [XmlRoot("AccountType", Namespace = "")]
    public enum AccountType
    {
        AccountsPayable,

        AccountsReceivable,

        Bank,

        CostOfGoodsSold,

        CreditCard,

        Equity,

        Expense,

        FixedAsset,

        Income,

        LongTermLiability,

        NonPosting,

        OtherAsset,

        OtherCurrentAsset,

        OtherCurrentLiability,

        OtherExpense,

        OtherIncome,
    }
}
