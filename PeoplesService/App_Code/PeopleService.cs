using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PeopleLibrary;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
namespace Peoples
{


    public class PeopleService : IPeopleService
    {
        public List<int> ListPeoples()
        {
            List<int> peoplelist = new List<int>();

            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    var peoples = db.Person.Select(p => p.PId).ToList();
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

            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    Person currentperson = db.Person.Where(t => t.PId == pId).FirstOrDefault();

                    person = new Person
                    {
                        PId = currentperson.PId,
                        PFId = currentperson.PFId,  
                        Forname = currentperson.Forname,
                        Lastname = currentperson.Lastname
                    };
                }
            }
            catch
            {
                //Igone exception
            }
            return person;
        }

        public Family GetFamily(int? pId)
        {
            Family family = null;
            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    List<PersonFamily> pf = db.PersonFamily.ToList();
                    List<PersonFamily> familymembers = pf.Where(p => p.PId == pId).ToList(); 
                    int? familyid = 0;

                    foreach(PersonFamily familyfam in familymembers)
                    {
                        if(familyfam.PFId != pId)
                        familyid = familyfam.FId;
                        Family familymember = db.Family.Where(t => t.FId == familyid).FirstOrDefault();

                        if (familymember != null)
                        {
                            family = new Family
                            {
                                PFId = familymember.PFId,
                                Born = familymember.Born,
                                Name = familymember.Name,
                            };
                        }
                    }
                    
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
                    Telephone currentnumbers = db.Telephone.Where(t => t.FId == fId).FirstOrDefault();

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
                    Address currentadress = db.Address.Where(t => t.PFId == pfId).FirstOrDefault();

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
