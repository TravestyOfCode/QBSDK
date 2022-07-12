using System;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AccountQueryRqTypeMetaData", Namespace = "", AnonymousType = true)]
    public enum MetaData
    {
        NoMetaData,

        MetaDataOnly,

        MetaDataAndResponseData,
    }
}
