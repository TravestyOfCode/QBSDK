using System.Xml.Linq;

namespace QBSDK
{
    public interface IQBXMLRq
    {
        public void Parse(XElement ret);

        public XElement ToAddRq(QBVersionInfo versionInfo = null);

        public XElement ToModRq(QBVersionInfo versionInfo = null);

        public XElement ToDelRq(QBVersionInfo versionInfo = null);
    }
}
