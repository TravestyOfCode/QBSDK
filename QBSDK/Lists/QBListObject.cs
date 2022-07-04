using System.Linq;
using System.Xml.Linq;

namespace QBSDK.Lists
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

        public override XElement ToAddRq(QBVersionInfo versionInfo = null)
        {
            XElement AddRq = new XElement(nameof(AddRq));

            AddRq.Add(ListID?.AsXElement(nameof(ListID)));
            AddRq.Add(Name?.AsXElement(nameof(Name)));
            AddRq.Add(IsActive?.AsXElement(nameof(IsActive)));
            AddRq.Add(ParentRef?.AsXElement(nameof(ParentRef)));

            return AddRq;
        }

        public override XElement ToModRq(QBVersionInfo versionInfo = null)
        {
            XElement ModRq = new XElement(nameof(ModRq));

            ModRq.Add(ListID?.AsXElement(nameof(ListID)));
            ModRq.Add(Name?.AsXElement(nameof(Name)));
            ModRq.Add(IsActive?.AsXElement(nameof(IsActive)));
            ModRq.Add(ParentRef?.AsXElement(nameof(ParentRef)));

            return ModRq;
        }

        public override XElement ToDelRq(QBVersionInfo versionInfo = null)
        {
            XElement ListDelRq = new XElement(nameof(ListDelRq));
            ListDelRq.Add(ListID?.AsXElement(nameof(ListID)));
            return ListDelRq;
        }

        public override void Parse(XElement ret)
        {
            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(ListID): ListID = element.AsString(); break;
                    case nameof(Name): Name = element.AsString(); break;
                    case nameof(IsActive): IsActive = element.AsBool(); break;
                    case nameof(ParentRef): ParentRef = element.AsBaseRef(); break;
                }
            }
        }

    }
}
