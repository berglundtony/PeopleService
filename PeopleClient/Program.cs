using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleClient.ServiceReference;
using PeopleLibrary;

namespace PeopleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PeopleServiceClient proxy = new PeopleServiceClient())
            {
                Console.WriteLine("List all peoples");
                int[] pIds = proxy.ListPeoples();
                Person person = new Person();

                foreach (int pid in pIds)
                {
                    Console.WriteLine("Number: {0}", pid);
                    person = proxy.GetPerson(pid);
                    Console.WriteLine("Test 2: Display the details of a people");

                    int pId = person.PId;
                    int? pFId = person.PFId;
                    Console.WriteLine("Forname: {0}", person.Forname);
                    Console.WriteLine("Lastame: {0}", person.Lastname);
                    Console.WriteLine();
                    Telephone tel = proxy.GetTelephone(pFId);
                    if (tel != null)
                    {
                        Console.WriteLine("<Telephone>");
                        Console.WriteLine("Mobile: {0}", tel.Mobile);
                        Console.WriteLine("Landline: {0}", tel.Landline);
                        Console.WriteLine();
                    }

                    Address address = proxy.GetAddress(pFId);
                    if (address != null)
                    {
                        Console.WriteLine("<Adress>");
                        Console.WriteLine("Street: {0}", address.Street);
                        Console.WriteLine("City: {0}", address.City);
                        Console.Write("Zip: {0}", address.Zip);
                        Console.WriteLine();
                    }


                    List<Family> family = proxy.GetFamily(pId).ToList();
                    foreach (Family f in family)
                    {
                        Console.WriteLine();
                        Console.WriteLine("<Family>");
                        Console.WriteLine("Name: {0}", f.Name);
                        Console.WriteLine("Born: {0}", f.Born);
                        address = proxy.GetAddress(f.PFId);

                        if (address != null)
                        {
                            Console.WriteLine("<Adress>");
                            Console.WriteLine();
                            Console.WriteLine("Street: {0}", address.Street);
                            Console.WriteLine("City: {0}", address.City);
                            Console.Write("Zip: {0}", address.Zip);
                            Console.WriteLine();
                        }

                        tel = proxy.GetTelephone(f.PFId);
                        if (tel != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("<Telephone>");
                            Console.WriteLine("Mobile: {0}", tel.Mobile);
                            Console.WriteLine("Landline: {0}", tel.Landline);
                            Console.WriteLine();
                        }
                    }
                }
                Console.ReadLine();

            }

        }
    }
}

