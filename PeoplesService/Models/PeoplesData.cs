using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Peoples
{
    public class PeoplesData
    {
        public Person person { get; set; }
        public Family family { get; set; }
        public Telephone telephone { get; set; }
        public Address address { get; set; }
        public List<Family> familyList { get; set; }

        public List<String> stringList { get; set; }
        public PeoplesData()
        {
            person = new Person();
            family = new Family();
            telephone = new Telephone();
            address = new Address();
            familyList = new List<Family>();
            stringList = new List<String>();    
        }
    }
        public class Person
        {
            //public int pId { get; set; }
            //public int pFId { get; set; }

            [DisplayName("firstname")]
            public string Firstname { get; set; }

            [DisplayName("lastname")]
            public string Lastname { get; set; }
        }

        public class Family
        {
            //public int pFId { get; set; }
            [DisplayName("name")]
            public string Name { get; set; }
            [DisplayName("born")]
            public int? Born { get; set; }
        }

        public class Address
        {
        
            [DisplayName("street")]
            public string Street { get; set; }
            [DisplayName("city")]
            public string City { get; set; }
            [DisplayName("zip")]
            public int? Zip{ get; set; }
        }

        public class Telephone
        {
            //public int pFId { get; set; }
            [DisplayName("mobile")]
            public string Mobile { get; set; }

            [DisplayName("landline")]
            public string Landline { get; set; }
        }
}