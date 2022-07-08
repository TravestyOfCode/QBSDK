using System;
using System.Xml.Linq;

namespace QBSDK
{
    public class AdditionalNote
    {
        public int? NoteID { get; private set; }

        public DateTime? Date { get; set; }

        public string Note { get; set; }

        public void Parse(XElement AdditionalNotesRet)
        {
            if (AdditionalNotesRet == null)
                return;

            foreach(var element in AdditionalNotesRet.Elements())
            {
                switch(element.Name.LocalName)
                {
                    case nameof(NoteID): NoteID = element.AsInt(); break;
                    case nameof(Date): Date = element.AsDateTime(); break;
                    case nameof(Note): Note = element.AsString(); break;
                }
            }
        }

        public static AdditionalNote Create(XElement AdditionalNotesRet)
        {
            if (AdditionalNotesRet == null)
                return null;

            AdditionalNote result = new AdditionalNote();
            result.Parse(AdditionalNotesRet);
            return result;
        }
    }

    public static class AddtionalNoteExtensions
    {
        public static AdditionalNote AsAdditionalNote(this XElement element) => AdditionalNote.Create(element);
    }
}
