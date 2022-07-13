using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("DataExtRet", Namespace="", AnonymousType=true)]
    [XmlRoot("DataExtRet", Namespace="")]
    public class DataExt
    {        
        [RegularExpression("0|(\\{[0-9a-fA-F]{8}(\\-([0-9a-fA-F]{4})){3}\\-[0-9a-fA-F]{12}\\})")]
        [XmlElement("OwnerID")]
        public string OwnerID { get; set; }
        
        [MaxLength(31)]
        [Required()]
        [XmlElement("DataExtName")]
        public string DataExtName { get; set; }
        
        [Required()]
        [XmlElement("DataExtType")]
        public DataExtType DataExtType { get; set; }
        
        [Required()]
        [XmlElement("DataExtValue")]
        public string DataExtValue { get; set; }

        public DataExt()
        {
            DataExtType = DataExtType.STR255TYPE;
        }
    }
}
