using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class Contacts
    {
        public string ListID { get; set; }
        
        public DateTime? TimeCreated { get; private set; }

        public DateTime? TimeModified { get; private set; }

        public string EditSequence { get; private set; }
        
        public string Contact { get; set; }

        public string Salutation { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        private List<AdditionalContact> AdditionalContactRef;
        public List<AdditionalContact> AdditionalContactList { get => AdditionalContactRef; set => AdditionalContactRef = value; }

        public void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach(var element in ret.Elements())
            {
                switch(element.Name.LocalName)
                {
                    case nameof(ListID): ListID = element.AsString(); break;
                    case nameof(TimeCreated): TimeCreated = element.AsDateTime(); break;
                    case nameof(TimeModified): TimeModified = element.AsDateTime(); break;
                    case nameof(EditSequence): EditSequence = element.AsString(); break;
                    case nameof(Contact): Contact = element.AsString(); break;
                    case nameof(Salutation): Salutation = element.AsString(); break;
                    case nameof(FirstName): FirstName = element.AsString(); break;
                    case nameof(MiddleName): MiddleName = element.AsString(); break;
                    case nameof(LastName): LastName = element.AsString(); break;
                    case nameof(JobTitle): JobTitle = element.AsString(); break;
                    case nameof(AdditionalContactRef):
                        {
                            AdditionalContactRef ??= new List<AdditionalContact>();
                            AdditionalContactRef.Add(AdditionalContact.Create(element));
                        }
                        break;

                }
            }
        }

        public XElement ToXElement(string name = nameof(Contacts))
        {
            XElement result = new XElement(name);
            result.Add(ListID.ToXElement(nameof(ListID)));
            result.Add(TimeCreated.ToXElement(nameof(TimeCreated)));
            result.Add(TimeModified.ToXElement(nameof(TimeModified)));
            result.Add(EditSequence.ToXElement(nameof(EditSequence)));
            result.Add(Contact.ToXElement(nameof(Contact)));
            result.Add(Salutation.ToXElement(nameof(Salutation)));
            result.Add(FirstName.ToXElement(nameof(FirstName)));
            result.Add(MiddleName.ToXElement(nameof(MiddleName)));
            result.Add(LastName.ToXElement(nameof(LastName)));
            result.Add(JobTitle.ToXElement(nameof(JobTitle)));
            result.Add(AdditionalContactRef.ToXElement(nameof(AdditionalContactRef)));
            return result;
        }

        public override string ToString() => ToXElement().ToString();

        public string ToString(string name) => ToXElement(name).ToString();

        public static Contacts Create(XElement ret)
        {
            if (ret == null)
                return null;

            Contacts result = new Contacts();
            result.Parse(ret);
            return result;
        }

        public static implicit operator Contacts(XElement ret) => Create(ret);
    }

    public static class ContactsExtensions
    {
        public static List<XElement> ToXElement(this List<Contacts> values, string name = nameof(Contacts))
        {
            if (values == null)
                return null;

            List<XElement> results = new List<XElement>();
            foreach (var value in values)
            {
                results.Add(value.ToXElement(name));
            }
            return results;
        }
    }
}
