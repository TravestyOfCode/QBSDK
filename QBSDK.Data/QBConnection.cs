using QBSDK.Data.Utilities;
using QBXMLRP2Lib;

namespace QBSDK.Data;

public class QBConnection(ILogger<QBConnection> logger) : IDisposable
{
    private IRequestProcessor5? rp;
    private string? ticket;
    private bool disposedValue;

    /// <summary>
    /// The Id and Name of the app that will appear when QB asks to grant access
    /// to the SDK.
    /// </summary>
    public string AppId { get; set; } = "QBSDK";

    /// <summary>
    /// The QB file to connect to. Leave empty for the currently open file.
    /// </summary>
    public string? QBFile { get; set; }


    /// <summary>
    /// Sends a QBXML request string to QB via the QB SDK.
    /// </summary>
    /// <param name="request">The string QBXML request to process.</param>
    /// <returns>The response from the QB SDK or null if there was an error.</returns>
    public string? ProcessRequest(string request)
    {
        if (Open())
        {
            // Open returning true ensures rp is not null.
            return rp!.ProcessRequest(ticket, request);
        }

        return null;
    }

    /// <summary>
    /// Tries to open a connection to the QB application and the requested
    /// QBFile.
    /// </summary>
    /// <returns>true if the connection was successful, otherwise false.</returns>
    private bool Open()
    {
        try
        {
            if (IsCorrectFileOpen())
            {
                return true;
            }

            Close();

            rp = new RequestProcessor3();
            rp.OpenConnection2(AppId, AppId, QBXMLRPConnectionType.localQBD);
            ticket = rp.BeginSession(QBFile, QBFileMode.qbFileOpenDoNotCare);

            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unexpected error trying to connect to QB.");
        }

        return false;
    }

    /// <summary>
    /// Checks to see if we have an existing connection and if so, if it
    /// is the same as the one we are wanting to not waste time reopening.
    /// </summary>
    /// <returns>true if the current QB file matches the QBFile property.</returns>
    private bool IsCorrectFileOpen()
    {
        // If we don't have a rp or ticket, we don't have a connection.
        if (rp == null || ticket.IsNullOrWhiteSpace())
        {
            return false;
        }

        try
        {
            var currentCompany = rp.GetCurrentCompanyFileName(ticket);

            // If QBFile is empty or null, we don't care which file is open.
            if (QBFile.IsNullOrWhiteSpace())
            {
                return true;
            }

            return Equals(System.IO.Path.GetFullPath(QBFile!), System.IO.Path.GetFullPath(currentCompany));
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unexpected error trying to get current QB company file.");
            return false;
        }
    }

    /// <summary>
    /// Ends and closed the connection with QB. Ensures rp and ticket are null.
    /// </summary>
    private void Close()
    {
        EndSession();
        CloseConnection();
    }

    /// <summary>
    /// Ends the session with the QB file, if any. Ensures ticket is null.
    /// </summary>
    private void EndSession()
    {
        try
        {
            // We should never have a situation with a ticket but no rp.
            if (rp != null && ticket.IsNotNullOrWhiteSpace())
            {
                rp.EndSession(ticket);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unexpected error ending session with QB.");
        }
        finally
        {
            ticket = null;
        }
    }

    /// <summary>
    /// Closed the connection to the QB application, if any. Ensures rp is null.
    /// </summary>
    private void CloseConnection()
    {
        try
        {
            rp?.CloseConnection();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unexpected error closing connection to QB.");
        }
        finally
        {
            rp = null;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // Dispose managed state (managed objects)
            }

            // Free unmanaged resources (unmanaged objects) and override finalizer
            Close();

            disposedValue = true;
        }
    }

    // Override finalizer only as 'Dispose(bool disposing)' has code to free unmanaged resources
    ~QBConnection()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
