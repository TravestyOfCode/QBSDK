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

        public static AdditionalContact Create(XElement ret)
        {
            if (ret == null)
                return null;

            AdditionalContact result = new AdditionalContact();
            result.Parse(ret);
            return result;
        }
    }

    public static class AdditionalContactExtensions
    {
        public static AdditionalContact AsAdditionalContact(this XElement ret) => AdditionalContact.Create(ret);
        
    }
}
