using System.Xml.Linq;

namespace QBSDK
{
    public class AdditionalContact
    {
        public string ContactName { get; set; }

        public string ContactValue { get; set; }

        public void Parse(XElement AdditionalContactRet)
        {
            if (AdditionalContactRet == null)
                return;

            foreach (var element in AdditionalContactRet.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(ContactName): ContactName = element.AsString(); break;
                    case nameof(ContactValue): ContactValue = element.AsString(); break;
                }
            }
        }

        public static AdditionalContact Create(XElement AdditionalContactRef)
        {
            if (AdditionalContactRef == null)
                return null;

            AdditionalContact result = new AdditionalContact();
            result.Parse(AdditionalContactRef);
            return result;
        }
    }

    public static class AdditionalContactExtensions
    {
        public static AdditionalContact AsAdditionalContact(this XElement element) => AdditionalContact.Create(element);
        
    }
}
