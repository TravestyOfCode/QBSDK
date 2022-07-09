using System.Collections.Generic;
using System.Xml.Linq;

namespace QBSDK
{
    public class AddressBlock
    {
        public string Addr1 { get; set; }

        public string Addr2 { get; set; }

        public string Addr3 { get; set; }

        public string Addr4 { get; set; }

        public string Addr5 { get; set; }

        public void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(Addr1): Addr1 = element.AsString(); break;
                    case nameof(Addr2): Addr2 = element.AsString(); break;
                    case nameof(Addr3): Addr3 = element.AsString(); break;
                    case nameof(Addr4): Addr4 = element.AsString(); break;
                    case nameof(Addr5): Addr5 = element.AsString(); break;
                }
            }
        }

        public XElement ToXElement(string name = nameof(AddressBlock))
        {
            XElement result = new XElement(name);
            result.Add(Addr1?.ToXElement(nameof(Addr1)));
            result.Add(Addr2?.ToXElement(nameof(Addr2)));
            result.Add(Addr3?.ToXElement(nameof(Addr3)));
            result.Add(Addr4?.ToXElement(nameof(Addr4)));
            result.Add(Addr5?.ToXElement(nameof(Addr5)));
            return result;
        }

        public override string ToString() => ToXElement().ToString();

        public string ToString(string name) => ToXElement(name).ToString();

        public static AddressBlock Create(XElement ret)
        {
            if (ret == null)
                return null;

            AddressBlock result = new AddressBlock();
            result.Parse(ret);
            return result;
        }

        public static implicit operator AddressBlock(XElement ret) => Create(ret);
    }

    public class Address : AddressBlock
    {
        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Note { get; set; }

        public new void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(Addr1): Addr1 = element.AsString(); break;
                    case nameof(Addr2): Addr2 = element.AsString(); break;
                    case nameof(Addr3): Addr3 = element.AsString(); break;
                    case nameof(Addr4): Addr4 = element.AsString(); break;
                    case nameof(Addr5): Addr5 = element.AsString(); break;
                    case nameof(City): City = element.AsString(); break;
                    case nameof(State): State = element.AsString(); break;
                    case nameof(PostalCode): PostalCode = element.AsString(); break;
                    case nameof(Country): Country = element.AsString(); break;
                    case nameof(Note): Note = element.AsString(); break;
                }
            }
        }

        public new XElement ToXElement(string name = nameof(Address))
        {
            XElement result = new XElement(name);
            result.Add(Addr1?.ToXElement(nameof(Addr1)));
            result.Add(Addr2?.ToXElement(nameof(Addr2)));
            result.Add(Addr3?.ToXElement(nameof(Addr3)));
            result.Add(Addr4?.ToXElement(nameof(Addr4)));
            result.Add(Addr5?.ToXElement(nameof(Addr5)));
            result.Add(City?.ToXElement(nameof(City)));
            result.Add(State?.ToXElement(nameof(State)));
            result.Add(PostalCode?.ToXElement(nameof(PostalCode)));
            result.Add(Country?.ToXElement(nameof(Country)));
            result.Add(Note?.ToXElement(nameof(Note)));
            return result;
        }

        public new string ToString() => ToXElement().ToString();

        public new string ToString(string name) => ToXElement(name).ToString();

        public new static Address Create(XElement ret)
        {
            if (ret == null)
                return null;

            Address result = new Address();
            result.Parse(ret);
            return result;
        }

        public static implicit operator Address(XElement ret) => Create(ret);
    }

    public class ShipToAddress : Address
    {
        public string Name { get; set; }

        public bool DefaultShipTo { get; set; }

        public new void Parse(XElement ret)
        {
            if (ret == null)
                return;

            foreach (var element in ret.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case nameof(Addr1): Addr1 = element.AsString(); break;
                    case nameof(Addr2): Addr2 = element.AsString(); break;
                    case nameof(Addr3): Addr3 = element.AsString(); break;
                    case nameof(Addr4): Addr4 = element.AsString(); break;
                    case nameof(Addr5): Addr5 = element.AsString(); break;
                    case nameof(City): City = element.AsString(); break;
                    case nameof(State): State = element.AsString(); break;
                    case nameof(PostalCode): PostalCode = element.AsString(); break;
                    case nameof(Country): Country = element.AsString(); break;
                    case nameof(Note): Note = element.AsString(); break;
                    case nameof(Name): Name = element.AsString(); break;
                    case nameof(DefaultShipTo): DefaultShipTo = element.AsBool() != null && element.AsBool().Value; break;
                }
            }
        }

        public new XElement ToXElement(string name = nameof(ShipToAddress))
        {
            XElement result = new XElement(name);
            result.Add(Name?.ToXElement(nameof(Name)));
            result.Add(Addr1?.ToXElement(nameof(Addr1)));
            result.Add(Addr2?.ToXElement(nameof(Addr2)));
            result.Add(Addr3?.ToXElement(nameof(Addr3)));
            result.Add(Addr4?.ToXElement(nameof(Addr4)));
            result.Add(Addr5?.ToXElement(nameof(Addr5)));
            result.Add(City?.ToXElement(nameof(City)));
            result.Add(State?.ToXElement(nameof(State)));
            result.Add(PostalCode?.ToXElement(nameof(PostalCode)));
            result.Add(Country?.ToXElement(nameof(Country)));
            result.Add(Note?.ToXElement(nameof(Note)));
            result.Add(DefaultShipTo.ToXElement(nameof(DefaultShipTo)));
            return result;
        }

        public new string ToString() => ToXElement().ToString();

        public new string ToString(string name) => ToXElement(name).ToString();

        public new static ShipToAddress Create(XElement ret)
        {
            if (ret == null)
                return null;

            ShipToAddress result = new ShipToAddress();
            result.Parse(ret);
            return result;
        }

        public static implicit operator ShipToAddress(XElement ret) => Create(ret);
    }

    public static class AddressExtensions
    {
        public static List<XElement> ToXElement(this List<ShipToAddress> values, string name = nameof(ShipToAddress))
        {
            if (values == null)
                return null;

            List<XElement> results = new List<XElement>();
            foreach(var value in values)
            {
                results.Add(value.ToXElement(name));
            }
            return results;
        }
    }
}
