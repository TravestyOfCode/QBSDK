using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class AdditionalContact
    {
        public string ContactName { get; set; }

        public string ContactValue { get; set; }

        public void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(ContactName): ContactName = element.AsString(); break;
                    case nameof(ContactValue): ContactValue = element.AsString(); break;
                }
            }
        }

        public XElement ToXElement(string name = nameof(AdditionalContact))
        {
            XElement result = new XElement(name);
            result.Add(ContactName.ToXElement(nameof(ContactName)));
            result.Add(ContactValue.ToXElement(nameof(ContactValue)));
            return result;
        }

        public override string ToString() => ToXElement().ToString();

        public string ToString(string name) => ToXElement(name).ToString();        

        public static AdditionalContact Create(XElement ret)
        {
            if (ret == null)
                return null;

            AdditionalContact result = new AdditionalContact();
            result.Parse(ret);
            return result;
        }

        public static implicit operator AdditionalContact(XElement ret) => Create(ret);
    }

    public static class AdditionalContactExtensions
    {
        public static List<XElement> ToXElement(this List<AdditionalContact> values, string name = nameof(AdditionalContact))
        {
            if (values == null)
                return null;

            List<XElement> results = new List<XElement>();
            foreach(var value in values)
            {
                results.Add(value.ToXElement(name));
            }
            return results;
        }
    }
}
