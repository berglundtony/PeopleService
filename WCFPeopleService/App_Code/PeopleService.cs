using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PeopleLibrary;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
namespace People
{


    public class PeopleService : IPeopleService
    {
        private object numbers;

        public List<int> ListPeoples()
        {
            List<int> peoplelist = new List<int>();

            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    var peoples = db.People.Select(p => p.PId).ToList();
                    peoplelist = peoples;
                }
            }
            catch
            {
                //ignore exceptions
            }

            return peoplelist;
        }

        public Person GetPerson(int pId)
        {
            Person person = null;
            Address address = null; 
            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    Person currentperson = db.People.Where(t => t.PId == pId).FirstOrDefault();

                    person = new Person
                    {
                        PId = person.PId,   
                        Forname = person.Forname,
                        Lastname = person.Lastname
                    };
                }
            }
            catch
            {
                //Igone exception
            }
            return person;
        }

        public Family GetFamily(int? pFId)
        {
            Family family = null;
            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    Family familymember = db.Families.Where(t => t.PFId == pFId).FirstOrDefault();

                    family = new Family 
                    { 
                        PFId = family.PFId,    
                        Born = family.Born,
                        Name = family.Name,        
                    };
                }
            }
            catch
            {
                //Igone exception
            }
            return family;
        }

        public Telephone GetTelephone(int fId)
        {
            Telephone telephone = null;
            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    Telephone currentnumbers= db.Telephones.Where(t => t.FId == fId).FirstOrDefault();

                    telephone = new Telephone
                    {
                        FId = currentnumbers.FId,
                        Mobile = currentnumbers.Mobile,
                        Landline = currentnumbers.Landline,
                    };
                }
            }
            catch
            {
                //Igone exception
            }
            return telephone;
        }

        public Address GetAddress(int pfId)
        {
            Address address = null;
            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    Address currentadress = db.Addresses.Where(t => t.PFId == pfId).FirstOrDefault();

                    address = new Address
                    {
                        PFId = currentadress.PFId,
                        Street = currentadress.Street,  
                        City = currentadress.City,
                        Zip = currentadress.Zip,
                    };
                }
            }
            catch
            {
                //Igone exception
            }
            return address;
        }

    }
}

