using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PeopleService;

namespace PeoplesClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleServiceClient proxy = new PeopleServiceClient();
            Console.WriteLine("Test 1: List all peoples");
            Task <string[]> pIds = proxy.ListPeoplesAsync();

            foreach (string pid in pIds.Result)
            {
                Console.WriteLine("Number: {0}", pid);
            }
            Console.WriteLine();

            Console.WriteLine("Test 2: Display the details of a people");
            PeopleData product = proxy.GetPeopleAsync("1");
            Console.WriteLine("Number: {0}", product.ProductNumber);
            Console.WriteLine("Name: {0}", product.Name);
            Console.WriteLine("Color: {0}", product.Color);
            Console.WriteLine("Price: {0}", product.ListPrice);
            Console.WriteLine();
        }
    }
}

