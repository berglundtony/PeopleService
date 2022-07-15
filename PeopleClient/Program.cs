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
                Console.WriteLine("Test 1: List all peoples");
                int[] pIds = proxy.ListPeoples();

                foreach (int pid in pIds)
                {
                    Console.WriteLine("Number: {0}", pid);
                }
                Console.WriteLine();

                Console.WriteLine("Test 2: Display the details of a people");
                Person person = proxy.GetPerson(1);
                int pId = person.PId;
                Console.WriteLine("Forname: {0}", person.Forname);
                Console.WriteLine("Lastame: {0}", person.Lastname);
                //Telephone tel = proxy.GetTelephone(pFId);
                Console.WriteLine();

                Family family = proxy.GetFamily(pId);
                Console.WriteLine("Name: {0}", family.Name);
                Console.WriteLine("Born: {0}", family.Born);
                Console.ReadLine();

            }

        }
    }
}

