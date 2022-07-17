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
        public Person person { get; set; }
        public Family family { get; set; }
        public Telephone phone { get; set; }
        public Address address { get; set; }
        public List<Family> familyList { get; set; }

        public List<Person> personList { get; set; }
        public People()
        {
            person = new Person();
            family = new Family();
            phone = new Telephone();
            address = new Address();
            familyList = new List<Family>();
            personList = new List<Person>();
        }
    }

    [Serializable]
    
    public class Person
    {
        //public int pId { get; set; }
        //public int pFId { get; set; }

        [XmlElement("firstname")]
        public string Firstname { get; set; }

        [XmlElement("lastname")]
        public string Lastname { get; set; }

        [XmlElement("phone")]
        public Telephone phone { get; set; }
        [XmlElement("adress")]
        public Address address { get; set; }

        public Person()
        {
            phone = new Telephone();
            address = new Address();
        }
    }
    //public List<Family> family { get; set; }
}
    [Serializable]
    public class Family
    {
        //public int pFId { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("born")]
        public int? Born { get; set; }
        [XmlElement("phone")]
        public Telephone phone { get; set; }
        [XmlElement("adress")]
        public Address adress { get; set; }
}
    [Serializable]
    public class Address
    {
        [XmlElement("street")]
        public string Street { get; set; }
        [XmlElement("city")]
        public string City { get; set; }
        [XmlElement("zip")]
        public int? Zip { get; set; }
    }
    [Serializable]
    public class Telephone
    {
        //public int pFId { get; set; }
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        [XmlElement("landline")]
        public string Landline { get; set; }
    }


