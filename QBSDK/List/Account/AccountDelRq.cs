using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("ListDelRq")]
    [XmlRoot("ListDelRq")]
    public class AccountDelRq : Request<AccountDel>
    {
        public AccountDel AccountDel { get; init; }

        internal AccountDelRq() { }

        public AccountDelRq(AccountDel accountDel)
        {
            AccountDel = accountDel;
        }
    }
}
