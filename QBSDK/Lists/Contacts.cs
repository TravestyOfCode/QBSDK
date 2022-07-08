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

        public void Parse(XElement ContactsRet)
        {
            if (ContactsRet == null)
                return;

            foreach(var element in ContactsRet.Elements())
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
    
        public static Contacts Create(XElement ContactsRet)
        {
            if (ContactsRet == null)
                return null;

            Contacts result = new Contacts();
            result.Parse(ContactsRet);
            return result;
        }
    }

    public static class ContactsExtensions
    {
        public static Contacts AsContacts(this XElement element) => Contacts.Create(element);
        
    }
}
