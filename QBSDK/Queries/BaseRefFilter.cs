using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public abstract class BaseRefFilter
    {
        protected List<string> ListID;
        public List<string> ListIDList { get => ListID; }
        
        protected List<string> FullName;
        public List<string> FullNameList { get => FullName; }
        
        public XElement ToXElement(string name)
        {
            XElement filter = new XElement(name);

            if(ListID != null)
            {
                foreach(var id in ListID)
                {
                    filter.Add(new XElement(nameof(ListID), id));
                }
            } else if(FullName != null)
            {
                foreach(var id in FullName)
                {
                    filter.Add(new XElement(nameof(FullName), id));
                }
            }

            return filter;
        }        
    }

    public class ListIDFilter : BaseRefFilter
    {
        public ListIDFilter(params string[] ids)
        {
            ListID = new List<string>();
            foreach(var id in ids)
            {
                ListID.Add(id);
            }
        }
    }

    public class FullNameFilter : BaseRefFilter
    {
        public FullNameFilter(params string[] ids)
        {
            FullName = new List<string>();
            foreach(var id in ids)
            {
                FullName.Add(id);
            }
        }
    }
}
