using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace QBSDK
{
    [Serializable()]
    public abstract class Request<T>
    {
        [XmlIgnore()]
        public Type EntityType { get; init; } = typeof(T);

        [XmlAttribute("requestID")]
        public string RequestID { get; set; }

        private readonly XmlWriterSettings settings = new XmlWriterSettings()
        {
            Indent = true,
            Encoding = Encoding.UTF8,
            OmitXmlDeclaration = true
        };

        private readonly XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces(new []{XmlQualifiedName.Empty});

        public override string ToString()
        {
            XmlSerializer serialize = new XmlSerializer(GetType());
            StringBuilder builder = new StringBuilder();
            using (XmlWriter writer = XmlWriter.Create(builder, settings))
            {
                serialize.Serialize(writer, this, namespaces);               
            }

            return builder.ToString();
        }
    }
}
