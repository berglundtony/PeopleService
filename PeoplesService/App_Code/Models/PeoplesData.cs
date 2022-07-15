using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Peoples
{
    [DataContract]
    public class PeoplesData
    {
        public class Person
        {
            [DataMember]
            public int PId { get; set; }

            [DataMember]
            public string Forname { get; set; }

            [DataMember]
            public string Lastname { get; set; }
        }

        public class Family
        {
            [DataMember]
            public int PFId { get; set; }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public int Born { get; set; }

        }

    }
}