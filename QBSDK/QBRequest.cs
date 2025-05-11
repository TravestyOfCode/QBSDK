using QBSDK.Utilities;
using System.Xml.Linq;

namespace QBSDK;

public abstract class QBRequest<T>
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

    private string? _iteratorID;
    public string? iteratorID
    {
        get => _iteratorID;
        protected set
        {
            _iteratorID = value;
            if (value == null)
            {
                iterator = null;
            }
            else
            {
                iterator = QBSDK.Iterator.Continue;
            }
        }
    }

    protected Iterator? iterator;
    public Iterator? Iterator
    {
        get => iterator;
    }

    protected int? maxReturned;
    public int? MaxReturned
    {
        get => maxReturned;
        set
        {
            maxReturned = value;
            if (value == null)
            {
                iteratorID = null;
                iterator = null;
            }
            else
            {
                if (iteratorID != null)
                {
                    iterator = QBSDK.Iterator.Continue;
                }
                else
                {
                    iterator = QBSDK.Iterator.Start;
                }
            }
        }
    }

    protected XElement? Response;
    public T? Results { get; protected set; }

    public void SetError(long errorCode)
    {
        statusCode = errorCode;
        statusSeverity = "ERROR";
        // TODO: Lookup error message based on statusCode.
        statusMessage = "Unknown error.";
    }

    public virtual XElement ToXElement(string name = nameof(QBRequest<T>))
    {
        return new XElement(name)
            .AddAttribute(requestID)
            .AddAttribute(iteratorID)
            .AddAttribute(iterator);
    }

    public virtual void ParseResponse(XDocument doc)
    {
        Response = doc.Descendants()
            .Where(d => d.HasAttributes && Equals(requestID, d.Attribute(nameof(requestID))?.Value))
            .SingleOrDefault();

        if (Response != null)
        {
            Response.SetFromAttribute(statusCode);
            Response.SetFromAttribute(statusSeverity);
            Response.SetFromAttribute(statusMessage);
            Response.SetFromAttribute(retCount);
            Response.SetFromAttribute(iteratorRemainingCount);
            Response.SetFromAttribute(iteratorID);
        }
    }
}
