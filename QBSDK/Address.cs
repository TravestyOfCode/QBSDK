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

        public void Parse(XElement AddressBlockRet)
        {
            if (AddressBlockRet == null)
                return;

            foreach(var element in AddressBlockRet.Elements())
            {
                switch(element.Name.LocalName)
                {
                    case nameof(Addr1): Addr1 = element.AsString(); break;
                    case nameof(Addr2): Addr2 = element.AsString(); break;
                    case nameof(Addr3): Addr3 = element.AsString(); break;
                    case nameof(Addr4): Addr4 = element.AsString(); break;
                    case nameof(Addr5): Addr5 = element.AsString(); break;
                }
            }            
        }

        public static AddressBlock Create(XElement AddressBlockRet)
        {
            if (AddressBlockRet == null) 
                return null;

            AddressBlock result = new AddressBlock();
            result.Parse(AddressBlockRet);
            return result;
        }
    }

    public class Address : AddressBlock
    {
        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Note { get; set; }

        public new void Parse(XElement AddressRet)
        {
            if (AddressRet == null)
                return;

            foreach (var element in AddressRet.Elements())
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

        public new static Address Create(XElement AddressRet)
        {
            if (AddressRet == null)
                return null;

            Address result = new Address();
            result.Parse(AddressRet);
            return result;
        }
    }

    public class ShipToAddress : Address
    {
        public string Name { get; set; }

        public bool DefaultShipTo { get; set; }

        public new void Parse(XElement ShipToAddressRet)
        {
            if (ShipToAddressRet == null)
                return;

            foreach (var element in ShipToAddressRet.Elements())
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

        public new static ShipToAddress Create(XElement ShipToAddressRet)
        {
            if (ShipToAddressRet == null)
                return null;

            ShipToAddress result = new ShipToAddress();
            result.Parse(ShipToAddressRet);
            return result;
        }
    }

    public static class AddressExtensions
    {
        public static AddressBlock AsAddressBlock(this XElement element) => AddressBlock.Create(element);
        public static Address AsAddress(this XElement element) => Address.Create(element);
        public static ShipToAddress AsShipToAddress(this XElement element) => ShipToAddress.Create(element);
    }
}
