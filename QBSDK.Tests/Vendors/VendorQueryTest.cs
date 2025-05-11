using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace QBSDK.Tests.Vendors;

public class VendorQueryTest(ITestOutputHelper output)
{
    [Fact]
    public void VendorQueryProducesCorrectXElement()
    {
        var rq = new VendorQueryRq()
        {
            ListID = ["ABc123"]
        };

        var result = rq.ToXElement();

        Assert.Equal(nameof(VendorQueryRq), result.Name.LocalName);
        Assert.Null(result.Element("MaxReturned"));
        Assert.NotNull(result.Element("ListID"));

        output.WriteLine(result.ToString());

    }

    [Fact]
    public void VendorQueryProcessRequest()
    {
        var loggerFactory = LoggerFactory.Create(c => c.SetMinimumLevel(LogLevel.Debug));
        var conn = new QBConnection(loggerFactory.CreateLogger<QBConnection>());
        var rq = new VendorQueryRq();

        conn.ProcessRequest(rq);

        Assert.Equal(0, rq.StatusCode);

    }
}
