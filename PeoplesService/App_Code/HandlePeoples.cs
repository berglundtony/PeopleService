﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Peoples
{
    public static class HandlePeoples
    {
        public static List<string> GetPeoples()
        {
                var peopleservice = new PeopleService();
                List<int> pIds = peopleservice.ListPeoples();
                var stringList= new List<string>();

                foreach (int pid in pIds)
                {
                    var person = peopleservice.GetPerson(pid);

                    int pId = person.PId;
                    int? pFId = person.PFId;
                    string p = string.Format("P|{0}|{1}", person.Forname, person.Lastname);
                    stringList.Add(p);
                    //pd.person.Firstname = person.Forname;
                    //pd.person.Lastname = person.Lastname;

                    var tel = peopleservice.GetTelephone(pFId);

                    if (tel != null)
                    {
                        string t = string.Format("T|{0}|{1}", tel.Mobile, tel.Landline);
                        stringList.Add(t);
                        //pd.telephone.Mobile = tel.Mobile;
                        //pd.telephone.Landline = tel.Landline;
                    }

                    var address = peopleservice.GetAddress(pFId);
                    if (address != null)
                    {
                        string a = string.Format("A|{0}|{1}|{2}", address.Street,address.City, address.Zip);
                        stringList.Add(a);
                        //pd.address.Street = address.Street;
                        //pd.address.City = address.City;
                        //pd.address.Zip = address.Zip;
                    }


                    var family = peopleservice.GetFamily(pId).ToList();

                    foreach (var f in family)
                    {
                        string fa = string.Format("F|{0}|{1}", f.Name.Trim(), f.Born);
                        stringList.Add(fa);
                        //pd.familyList.Add(new Family { Name = f.Name, Born = f.Born });
                        address = peopleservice.GetAddress(f.PFId);

                        if (address != null)
                        {
                            string a = string.Format("A|{0}|{1}|{2}", address.Street, address.City, address.Zip);
                            stringList.Add(a);
                            //pd.address.Street = address.Street;
                            //pd.address.City = address.City;
                            //pd.address.Zip = address.Zip;
                        }

                        var tele = peopleservice.GetTelephone(f.PFId);
                        if (tele != null)
                        {
                            string t = string.Format("T|{0}|{1}", tel.Mobile, tel.Landline);
                            stringList.Add(t);
                            //pd.telephone.Mobile = tele.Mobile;
                            //pd.telephone.Landline = tele.Landline;
                        }
                    } 
                }
                return stringList;
            }
        }
    }



    