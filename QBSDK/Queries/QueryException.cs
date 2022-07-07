using System;

namespace QBSDK
{
    public class QueryException : ApplicationException
    {
        public string StatusCode { get; init; }

        public string StatusMessage { get => Message; }

        public QueryException(string statusCode, string statusMessage) : base($"StatusCode: {statusCode}, Message: {statusMessage}")
        {
            StatusCode = statusCode;
        }
    }
}
