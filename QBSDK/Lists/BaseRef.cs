using System.Xml.Linq;

namespace QBSDK
{
    public class BaseRef
    {
        public string ListID { get; set; }
        public string FullName { get; set; }

        public bool IsEmpty => ListID == null && FullName == null;

        public BaseRef()
        {

        }
        public BaseRef(string fullName) : this()
        {
            FullName = fullName;
        }

        public void Parse(XElement BaseRef)
        {
            if (BaseRef == null)
                return;

            foreach(var element in BaseRef.Elements())
            {
                switch(element.Name.LocalName)
                {
                    case nameof(ListID):ListID = element.AsString(); break;
                    case nameof(FullName): FullName = element.AsString(); break;
                }
            }
        }

        public static BaseRef Create(XElement BaseRef)
        {
            if (BaseRef == null)
                return null;

            BaseRef result = new BaseRef();
            result.Parse(BaseRef);
            return result;
        }
    }

    public static class BaseRefExtensions
    {
        public static BaseRef AsBaseRef(this XElement element)
        {
            if (element == null)
            {
                return null;
            }

            BaseRef result = new BaseRef();

            foreach (XElement subElement in element.Elements())
            {
                switch (subElement.Name.LocalName)
                {
                    case nameof(result.ListID): result.ListID = subElement.AsString(); break;
                    case nameof(result.FullName): result.FullName = subElement.AsString(); break;
                }
            }

            if (result.IsEmpty)
            {
                return null;
            }

            return result;
        }

        public static XElement ToXElement(this BaseRef value, string name)
        {
            if (value == null)
                return null;

            XElement result = new XElement(name);

            if (value.ListID != null)
                result.Add(new XElement(nameof(value.ListID), value.ListID));
            else if (value.FullName != null)
                result.Add(new XElement(nameof(value.FullName), value.FullName));

            return result;
        }
    }
}
