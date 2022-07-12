using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AccountModRq")]
    [XmlRoot("AccountModRq")]
    public class AccountModRq : Request<AccountMod>
    {
        public AccountMod AccountMod { get; init; }

        internal AccountModRq() { }

        public AccountModRq(AccountMod accountMod)
        {
            AccountMod = accountMod;
        }
    }
}
