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

        public void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach(var element in ret.Elements())
            {
                switch(element.Name.LocalName)
                {
                    case nameof(ListID):ListID = element.AsString(); break;
                    case nameof(FullName): FullName = element.AsString(); break;
                }
            }
        }

        public XElement ToXElement(string name = nameof(BaseRef))
        {
            XElement result = new XElement(name);

            if (ListID != null)
                result.Add(new XElement(nameof(ListID), ListID));
            else if (FullName != null)
                result.Add(new XElement(nameof(FullName), FullName));

            return result;
        }

        public override string ToString() => ToXElement().ToString();

        public string ToString(string name) => ToXElement(name).ToString();

        public static BaseRef Create(XElement ret)
        {
            if (ret == null)
                return null;

            BaseRef result = new BaseRef();
            result.Parse(ret);
            return result;
        }

        public static implicit operator BaseRef(XElement ret) => Create(ret);
    }
}
