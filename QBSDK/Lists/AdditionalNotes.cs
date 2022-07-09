using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class AdditionalNotes
    {
        public int? NoteID { get; private set; }

        public DateTime? Date { get; set; }

        public string Note { get; set; }

        public void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach(var element in ret.Elements())
            {
                switch(element.Name.LocalName)
                {
                    case nameof(NoteID): NoteID = element.AsInt(); break;
                    case nameof(Date): Date = element.AsDateTime(); break;
                    case nameof(Note): Note = element.AsString(); break;
                }
            }
        }

        public XElement ToXElement(string name = nameof(AdditionalNotes))
        {
            XElement result = new XElement(name);
            result.Add(NoteID.ToXElement(nameof(NoteID)));
            result.Add(Date.ToXElement(nameof(Date)));
            result.Add(Note.ToXElement(nameof(Note)));
            return result;
        }

        public override string ToString() => ToXElement().ToString();

        public string ToString(string name) => ToXElement(name).ToString();        

        public static AdditionalNotes Create(XElement ret)
        {
            if (ret == null)
                return null;

            AdditionalNotes result = new AdditionalNotes();
            result.Parse(ret);
            return result;
        }

        public static implicit operator AdditionalNotes(XElement ret) => Create(ret);
    }

    public static class AdditionalNoteExtensions
    {
        public static List<XElement> ToXElement(this List<AdditionalNotes> values, string name = nameof(AdditionalNotes))
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
