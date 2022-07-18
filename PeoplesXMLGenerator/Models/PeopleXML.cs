using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PeoplesXMLGenerator.Models
{
    [Serializable]
    [XmlRoot("people")]
    public class People
    {
        [XmlElement("person", Type = typeof(Person))]
        public List<Person> personList { get; set; }
        public People()
        {
            personList = new List<Person>();
        }
    }

    [Serializable]
    [XmlRoot("person")]
    public class Person
    {
        //public int pId { get; set; }
        //public int pFId { get; set; }

        [XmlElement("firstname")]
        public string Firstname { get; set; }

        [XmlElement("lastname")]
        public string Lastname { get; set; }

        [XmlElement("phone", IsNullable = true, Type = typeof(Telephone))]
        public Telephone phone { get; set; }
        [XmlElement("address", IsNullable = true, Type = typeof(Address))]
        public Address address { get; set; }

        [XmlIgnore]
        public Family family { get; set; }

        [XmlElement("family", IsNullable = true, Type = typeof(Family))]
        public List<Family> familyList { get; set; }


        public Person()
        {
            phone = new Telephone();
            address = new Address();
            family = new Family();
            familyList = new List<Family>();
        }
    }
}
[Serializable]
public class Family
{

    [XmlElement("name")]
    public string Name { get; set; }
    [XmlElement("born")]
    public int? Born { get; set; }

    [XmlElement("phone", IsNullable = true, Type = typeof(Telephone))]
    public Telephone phone { get; set; }
    [XmlElement("address", Type = typeof(Address))]
    [DefaultValue(null)]
    public Address address { get; set; } 
    [XmlIgnore]
    public bool AddressSpecified
    {
        get
        {
            return address != null
                  && !string.IsNullOrEmpty(address.Street)
                  && !string.IsNullOrEmpty(address.City)
                  && !string.IsNullOrEmpty(address.Zip.ToString());
        }
        set { return; }
  
    }

    public Family()
    {
        phone = new Telephone();
        address = new Address();
    }
}
[Serializable]
public class Address
{
    [XmlElement("street")]
    public string Street { get; set; }
    public bool ShouldSerializeStreet() { return true; }

    [XmlElement("city")]
    public string City { get; set; }
    public bool ShouldSerializeCity() { return true; }

    [XmlElement("zip", IsNullable = true)]
    public int? Zip { get; set; }
    public bool ShouldSerializeZip() { return Zip != null; }
}

[Serializable]
public class Telephone
{
    [XmlElement("mobile")]
    public string Mobile { get; set; }

    [XmlElement("landline")]
    public string Landline { get; set; }
}


