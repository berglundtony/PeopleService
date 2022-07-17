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

namespace PeoplesXMLGenerator
{
    public partial class GenerateXML : Form
    {
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
                var person = new Models.Person();
                var pList = new List<Models.Person>();  
                foreach (var people in peoplesList)
                {
                    var firstletter = people.FirstOrDefault();
               
                    switch (firstletter)
                    {
                        case 'P':
                            string[] pers = people.Split('|');
                            person.Firstname = pers[1].ToString();
                            person.Lastname = pers[2].ToString();
                            //pList.Add(person);

                            //p.person.Firstname = pers[1];
                            //p.person.Lastname = pers[2];
                            break;
                        case 'T':
                            string[] phones = people.Split('|');
                            person.phone.Mobile = phones[1].ToString();
                            person.phone.Landline= phones[2].ToString();
                            //pList.Add((person));
                            //p.phone.Mobile = phones[1];
                            //p.phone.Landline = phones[2];
                            break;
                        case 'A':
                            string[] addr = people.Split('|');
                            person.address.Street = addr[1].ToString();
                            person.address.City = addr[2].ToString();
                            if(addr[3] != String.Empty)
                            person.address.Zip = int.Parse(addr[3]);
                            //pList.Add((person));
                            p.personList.Add(person);

                       
                            //p.address.Street = addr[1]; 
                            //p.address.City = addr[2];
                            //if (addr[3] != "")
                            //p.address.Zip = int.Parse(addr[3]);
                            break;
                        case 'F':
                            string[] fam = people.Split('|');
                            p.familyList.Add(new Family { Name = fam[1].ToString(), Born = int.Parse(fam[2]) });
                            //p.family.Name = fam[1];
                            //p.family.Born = int.Parse(fam[2]);
                            break;
                        default:
                            break;
                    }
                  
                }
                //Serialize(p);
                //person2Xml(p);
                var serializer = new XmlSerializer(p.GetType());
                using (var writer = XmlWriter.Create("people.xml"))
                {
                    serializer.Serialize(writer, p);
                }
                //FileStream fs = new FileStream(@"C:\", FileMode.OpenOrCreate);
                //XmlSerializer serializedPeople = new XmlSerializer(typeof(People));
                //XmlSerializer.Serialize(fs, p);

                //using (var writer = new StreamWriter("C:\\File.xml"))
                //{
                //    XmlSerializer.Serialize(writer, );
                //}
                //using (var stringwriter = new StringWriter())
                //{
                //    var serializer = new XmlSerializer(this.GetType());
                //    serializer.Serialize(stringwriter, this);
                //    return stringwriter.ToString();
                //}
            }
        }

        //private string person2Xml(object obj)
        //{
        //    XmlSerializer serializer = new XmlSerializer(obj.GetType());
        //    StringBuilder result = new StringBuilder();
        //    using (var writer = new StreamWriter("C:\\File.xml"))
        //    {
        //        serializer.Serialize(writer, obj);
        //    }
        //    return result.ToString();
        //}
        //public static string Serialize(object dataToSerialize)
        //{
        //    if (dataToSerialize == null) return null;

        //    using (StringWriter stringwriter = new System.IO.StringWriter())
        //    {
        //        var serializer = new XmlSerializer(dataToSerialize.GetType());
        //        serializer.Serialize(stringwriter, dataToSerialize);
        //        return stringwriter.ToString();
        //    }
        //}

    }
}
