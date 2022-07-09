using System.Linq;
using System.Xml.Linq;

namespace QBSDK
{
    public abstract class QBListObject : QBObject, IQBList
    {
        public string ListID { get => ID; set => ID = value; }

        public string Name { get; set; }

        public string FullName
        {
            get => ParentRef == null ? Name : ParentRef.FullName + ':' + Name;
            set
            {
                // Check for setting empty value
                if (string.IsNullOrEmpty(value))
                {
                    ParentRef = null;
                    Name = null;
                    return;
                }

                // Check for index of last ':' character
                int idx = value.LastIndexOf(':');

                if (idx != -1) // We have a parent portion
                {
                    ParentRef = new BaseRef(value[..idx]);
                    Name = value[(idx + 1)..];
                }
                else // We don't have any parent
                {
                    Name = value;
                }
            }
        }

        public bool? IsActive { get; set; }

        public BaseRef ParentRef { get; set; }

        public int Sublevel => FullName.Count(c => c == ':');

        public override void Parse(XElement ret)
        {
            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(ListID): ListID = element.AsString(); break;
                    case nameof(EditSequence): EditSequence = element.AsString(); break;
                    case nameof(TimeCreated): TimeCreated = element.AsDateTime(); break;
                    case nameof(TimeModified): TimeModified = element.AsDateTime(); break;
                    case nameof(Name): Name = element.AsString(); break;
                    case nameof(IsActive): IsActive = element.AsBool(); break;
                    case nameof(ParentRef): ParentRef = element; break;
                }
            }
        }

    }
}
