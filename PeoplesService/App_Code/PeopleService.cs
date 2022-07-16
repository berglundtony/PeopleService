﻿using System;
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

        public List<Family> GetFamily(int? pId)
        {
            List<Family> familylist = new List<Family>();
            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    List<PersonFamily> pf = db.PersonFamily.Where(p => p.PId == pId).ToList();
                    int? familyid = 0;

                    foreach(PersonFamily f in pf)
                    {
                        if(f.PFId != pId)
                        familyid = f.FId;
                        Family familymember = db.Family.Where(t => t.FId == familyid).FirstOrDefault();

                        if (familymember != null)
                        {
                            Family family = new Family
                            {
                                PFId = familymember.PFId,
                                Born = familymember.Born,
                                Name = familymember.Name,
                            };

                            familylist.Add(family); 
                        }
                    }
                    
                }
            }
            catch
            {
                //Igone exception
            }
            return familylist;
        }

        public Telephone GetTelephone(int? pFId)
        {
            Telephone telephone = null;
       
            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    List<PersonFamily> pf = db.PersonFamily.Where(p => p.PFId == pFId).ToList();
                  

                    int? teleid = 0;

                    foreach (PersonFamily f in pf)
                    {
                        teleid = f.FId;
                        Telephone tp = db.Telephone.Where(t => t.FId == teleid).FirstOrDefault();

                        if (tp != null)
                        {
                            telephone = new Telephone
                            {
                                FId = tp.FId,
                                Landline = tp.Landline, 
                                Mobile = tp.Mobile,            
                            };

       
                        }
                    }
                }
            }
            catch
            {
                //Igone exception
            }
            return telephone;
        }

        public Address GetAddress(int? pfId)
        {
            Address address = null;
            try
            {
                using (PeoplesEntities db = new PeoplesEntities())
                {
                    Address currentadress = db.Address.Where(t => t.PFId == pfId).FirstOrDefault();

                    if(currentadress != null)
                    {
                        address = new Address
                        {
                            PFId = currentadress.PFId,
                            Street = currentadress.Street,
                            City = currentadress.City,
                            Zip = currentadress.Zip,
                        };
                    }
           
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
