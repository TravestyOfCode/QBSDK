using System;

namespace QBSDK.Lists
{
    public interface IQBList : IQBXMLRq
    {
        public string ListID { get; set; }

        public DateTime? TimeCreated { get; }

        public DateTime? TimeModified { get; }
        
        public string EditSequence { get; }
        
        public string Name { get; set; }
        
        public string FullName { get; }
        
        public bool? IsActive { get; set; }
        
        public BaseRef ParentRef { get; set; }
        
        public int Sublevel { get; }
    }
}