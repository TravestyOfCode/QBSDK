using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace QBSDK
{
    internal static class XmlSettings
    {
        internal static XmlWriterSettings WriterSettings = new XmlWriterSettings()
        {
            Encoding = Encoding.UTF8,
            Indent = true,
            OmitXmlDeclaration = true
        };

        internal static XmlSerializerNamespaces Namespaces = new XmlSerializerNamespaces(new [] { XmlQualifiedName.Empty });
        
            
    }
}
