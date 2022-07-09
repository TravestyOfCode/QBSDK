using System.Xml.Linq;

namespace QBSDK
{
    public interface IQBXMLRq
    {
        public void Parse(XElement ret);

        public XElement ToAddRq(QBCountry qbCountry = QBCountry.US);

        public XElement ToModRq(QBCountry qbCountry = QBCountry.US);

        public XElement ToDelRq(QBCountry qbCountry = QBCountry.US);
    }
}
