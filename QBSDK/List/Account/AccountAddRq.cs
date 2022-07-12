using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AccountAddRq")]
    [XmlRoot("AccountAddRq")]
    public class AccountAddRq : Request<AccountAdd>
    {
        public AccountAdd AccountAdd { get; init; }

        internal AccountAddRq() { }

        public AccountAddRq(AccountAdd accountAdd)
        {
            AccountAdd = accountAdd;
        }
    }
}
