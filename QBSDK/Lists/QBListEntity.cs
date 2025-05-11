using QBSDK.Utilities;
using System.Xml.Linq;

namespace QBSDK;

public abstract class QBListEntity
{
    public int Id { get; set; }

    public string? ListID { get; set; }

    public DateTime? TimeCreated { get; set; }

    public DateTime? TimeModified { get; set; }

    public string? EditSequence { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    protected QBListEntity() { }

    protected QBListEntity(XElement element)
    {
        element.SetFromElement(ListID);
        element.SetFromElement(TimeCreated);
        element.SetFromElement(TimeModified);
        element.SetFromElement(EditSequence);
        element.SetFromElement(Name);
        element.SetFromElement(IsActive);
    }
}
