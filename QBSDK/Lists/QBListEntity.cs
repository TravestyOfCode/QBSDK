using QBSDK.Utilities;
using System.Xml.Linq;

namespace QBSDK;

public abstract class QBListEntity
{
    public int Id;

    public string? ListID;

    public DateTime? TimeCreated;

    public DateTime? TimeModified;

    public string? EditSequence;

    public string? Name;

    public bool? IsActive;

    protected QBListEntity() { }

    protected QBListEntity(XElement element)
    {
        element.SetFromElement(out ListID);
        element.SetFromElement(out TimeCreated);
        element.SetFromElement(out TimeModified);
        element.SetFromElement(out EditSequence);
        element.SetFromElement(out Name);
        element.SetFromElement(out IsActive);
    }
}
