using QBSDK.Utilities;
using System.Xml.Linq;

namespace QBSDK;

internal abstract class QBRequest
{
    protected long? statusCode;
    public long? StatusCode => StatusCode;

    protected string? statusSeverity;
    public string? StatusSeverity => statusSeverity;

    protected string? statusMessage;
    public string? StatusMessage => statusMessage;

    protected string? requestID;
    public string? RequestID { get => requestID; internal set => requestID = value; }

    protected int? retCount;
    public int? ReturnedCount => retCount;

    protected int? iteratorRemainingCount;
    public int? RemainingCount => iteratorRemainingCount;

    protected string? iteratorID;

    public void SetError(long errorCode)
    {
        statusCode = errorCode;
        statusSeverity = "ERROR";
        // TODO: Lookup error message based on statusCode.
        statusMessage = "Unknown error.";
    }

    public abstract XElement ToXElement();

    public virtual void ParseResponse(XDocument doc)
    {
        var Rs = doc.Descendants()
            .Where(d => d.HasAttributes && Equals(requestID, d.Attribute(nameof(requestID))?.Value))
            .SingleOrDefault();

        if (Rs != null)
        {
            Rs.SetFromAttribute(out statusCode);
            Rs.SetFromAttribute(out statusSeverity);
            Rs.SetFromAttribute(out statusMessage);
            Rs.SetFromAttribute(out retCount);
            Rs.SetFromAttribute(out iteratorRemainingCount);
            Rs.SetFromAttribute(out iteratorID);
        }
    }
}
