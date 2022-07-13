using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    [XmlType("AdditionalNotesRet", Namespace="", AnonymousType=true)]
    [XmlRoot("AdditionalNotesRet", Namespace="")]
    public class AdditionalNotes
    {        
        [Required()]
        [XmlElement("NoteID")]
        public int NoteID { get; set; }
        
        [Required()]
        [XmlElement("Date")]
        public DateTime Date { get; set; }
        
        [MaxLength(4095)]
        [Required()]
        [XmlElement("Note")]
        public string Note { get; set; }
    }
}
