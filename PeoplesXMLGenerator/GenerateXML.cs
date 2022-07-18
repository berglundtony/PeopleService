using PeoplesXMLGenerator.PeopleServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeoplesXMLGenerator.Models;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace PeoplesXMLGenerator
{
    public partial class GenerateXML : Form
    {
        static Regex emptyElementRegex = new Regex(@"<(\w+)\s*/>");
        public GenerateXML()
        {
            InitializeComponent();
        }

        private void generateXML_Click(object sender, EventArgs e)
        {
           
            using (PeopleServiceClient psc = new PeopleServiceClient())
            {
                string[] peoplesList = psc.GetPeopleStringList();
                People p = new People();
                bool familybool = false;
                bool personbool = false;
                var person = new Models.Person();
                foreach (var people in peoplesList)
                {
                    var firstletter = people.FirstOrDefault();

            
                    if (firstletter == 'P')
                    {
                        if (personbool)
                        {
                            personbool = false;
                            p.personList.Add(person);
                            person = new Models.Person();
                        }
                        string[] pers = people.Split('|');
                        person.Firstname = pers[1].ToString();
                        person.Lastname = pers[2].ToString();
                        familybool = false;
                   
                    }
                    if (familybool == false)
                    {
                        if (firstletter == 'T')
                        {
                            string[] phones = people.Split('|');
                            person.phone.Mobile = phones[1].ToString();
                            person.phone.Landline = phones[2].ToString();
                            personbool = true;
                        }
                        if (firstletter == 'A')
                        {
                            string[] addr = people.Split('|');
                            person.address.Street = addr[1].ToString();
                            person.address.City = addr[2].ToString();
                            if (addr[3] != String.Empty)
                                person.address.Zip = int.Parse(addr[3]);
                            personbool = true;
                        }
                        if (firstletter == 'F')
                        {
                            if (person.familyList.Count > 0)
                                person.family = new Family();
                            string[] fam = people.Split('|');
                            person.family.Name = fam[1].ToString();
                            person.family.Born = int.Parse(fam[2]);
                            familybool = true;
                       }
                        if(p.personList.Count > 0 && personbool == true)
                        {
                        
                            personbool = false;
                            p.personList.Add(person);
                        }
                    }
                    else
                    {
         
                        if (firstletter == 'T')
                        {
                            string[] phones = people.Split('|');
                            person.family.phone.Mobile = phones[1].ToString();
                            person.family.phone.Landline = phones[2].ToString();

                        }
                        if (firstletter == 'A')
                        {
                            string[] addr = people.Split('|');
                            person.family.address.Street = addr[1].ToString();
                            person.family.address.City = addr[2].ToString();
                            if (addr[3] != String.Empty)
                                person.family.address.Zip = int.Parse(addr[3]);
                        }
                        person.familyList.Add(person.family);
                        familybool = false;

                        if (person.Firstname != String.Empty)
                        {
                            personbool = true;
                        }  
                    }
                
                }

                var serializer = new XmlSerializer(p.GetType());
                using (var writer = XmlWriter.Create("people.xml"))
                {
                    StringWriter sw = new StringWriter();
                    serializer.Serialize(writer, p);
                }
            }
        }

    }

}