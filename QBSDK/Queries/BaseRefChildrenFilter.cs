using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class BaseRefChildrenFilter
    {
        private List<string> ListID;
        public List<string> ListIDList
        {
            get => ListID;

            set
            {
                if (FullName != null)
                    throw new InvalidOperationException("Unable to set ListIDList with an active FullNameList filter.");
                if (listIDWithChildren != null)
                    throw new InvalidOperationException("Unable to set ListIDList with an active ListIDWithChildren filter.");
                if (fullNameWithChildren != null)
                    throw new InvalidOperationException("Unable to set ListIDList with an active FullNameWithChildren filter.");

                ListID = value;
            }
        }

        private List<string> FullName;
        public List<string> FullNameList
        {
            get => FullName;
            set
            {
                if (ListID != null)
                    throw new InvalidOperationException("Unable to set FullNameList with an active ListIDList filter.");

                if (listIDWithChildren != null)
                    throw new InvalidOperationException("Unable to set FullNameList with an active ListIDWithChildren filter.");

                if (fullNameWithChildren != null)
                    throw new InvalidOperationException("Unable to set FullNameList with an active FullNameWithChildren filter.");

                FullName = value;
            }
        }

        private string listIDWithChildren;
        public string ListIDWithChildren
        {
            get => listIDWithChildren;
            set
            {
                if (ListID != null)
                    throw new InvalidOperationException("Unable to set ListIDWithChildren with an active ListIDList filter.");
                if (FullName != null)
                    throw new InvalidOperationException("Unable to set ListIDWithChildren with an active FullNameList filter.");
                if (fullNameWithChildren != null)
                    throw new InvalidOperationException("Unable to set ListIDWithChildren with an active FullNameWithChildren filter.");

                listIDWithChildren = value;
            }
        }

        private string fullNameWithChildren;
        public string FullNameWithChildren
        {
            get => fullNameWithChildren;
            set
            {
                if (ListID != null)
                    throw new InvalidOperationException("Unable to set FullNameWithChildren with an active ListIDList filter.");
                if (FullName != null)
                    throw new InvalidOperationException("Unable to set FullNameWithChildren with an active FullNameList filter.");
                if (listIDWithChildren != null)
                    throw new InvalidOperationException("Unable to set FullNameWithChildren with an active ListIDWithChildren filter.");

                fullNameWithChildren = value;
            }
        }

        public XElement ToXElement(string name)
        {
            XElement result = new XElement(name);
            if(ListID != null)
            {
                result.Add(ListID.ToXElementList(nameof(ListID)));
            }
            else if(FullName != null)
            {
                result.Add(FullName.ToXElementList(nameof(FullName)));
            }
            else if(listIDWithChildren != null)
            {
                result.Add(listIDWithChildren.ToXElement(nameof(ListIDWithChildren)));
            }
            else if(fullNameWithChildren != null)
            {
                result.Add(fullNameWithChildren.ToXElement(nameof(FullNameWithChildren)));
            }

            return result;
        }
    }
}
