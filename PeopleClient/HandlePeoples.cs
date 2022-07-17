using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using PeopleClient.ServiceReference;
using PeopleLibrary;


namespace PeopleClient
{
    public class HandlePeoples
    {
        public PeoplesData GetPeoples()
        {
            using (PeopleServiceClient proxy = new PeopleServiceClient())
            {
                PeoplesData pd = new PeoplesData();

                int[] pIds = proxy.ListPeoples();

                foreach (int pid in pIds)
                {
                    var person = proxy.GetPerson(pid);

                    int pId = person.PId;
                    int? pFId = person.PFId;
                    string p = $"P|{person.Forname}|{person.Lastname}";
                    pd.stringList.Add(p);
                    //pd.person.Firstname = person.Forname;
                    //pd.person.Lastname = person.Lastname;

                    var tel = proxy.GetTelephone(pFId);

                    if (tel != null)
                    {
                        string t = $"T|{tel.Mobile}|{tel.Landline}";
                        pd.stringList.Add(t);
                        //pd.telephone.Mobile = tel.Mobile;
                        //pd.telephone.Landline = tel.Landline;
                    }

                    var address = proxy.GetAddress(pFId);
                    if (address != null)
                    {
                        string a = $"A|{address.Street}|{address.City}|{address.Zip}";
                        pd.stringList.Add(a);
                        //pd.address.Street = address.Street;
                        //pd.address.City = address.City;
                        //pd.address.Zip = address.Zip;
                    }


                    var family = proxy.GetFamily(pId).ToList();

                    foreach (var f in family)
                    {
                        string fa = $"F|{f.Name.Trim()}|{f.Born}";
                        pd.stringList.Add(fa);
                        //pd.familyList.Add(new Family { Name = f.Name, Born = f.Born });
                        address = proxy.GetAddress(f.PFId);

                        if (address != null)
                        {
                            string a = $"A|{address.Street}|{address.City}|{address.Zip}";
                            pd.stringList.Add(a);
                            //pd.address.Street = address.Street;
                            //pd.address.City = address.City;
                            //pd.address.Zip = address.Zip;
                        }

                        var tele = proxy.GetTelephone(f.PFId);
                        if (tele != null)
                        {
                            string t = $"T|{tel.Mobile}|{tel.Landline}";
                            pd.stringList.Add(t);
                            //pd.telephone.Mobile = tele.Mobile;
                            //pd.telephone.Landline = tele.Landline;
                        }
                    } 
                }
                return pd;
            }
        }
        //public List<string> GetConcatenatedData()
        //{
        //    var peoplesdata = new List<string>();
        //    PeoplesData pd = GetPeoples();

        //    peoplesdata.Add($"P|{pd.person.Firstname}|{pd.person.Lastname}");
        //    peoplesdata.Add($"A|{pd.address.Street}|{pd.address.City}|{pd.address.Zip}");
        //    peoplesdata.Add($"T|{pd.telephone.Mobile}|{ pd.telephone.Landline}");
        //    foreach(var f in pd.familyList)
        //    peoplesdata.Add($"F|{f.Name}|{f.Born}");

        //    return peoplesdata;
        //}
    }
}


    