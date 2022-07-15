using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;
    using PeopleLibrary;

    namespace PeopleService
    {
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
        // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
        public class PeopleService : IPeopleService
        {
            public List<string> GetPeople()
            {
                List<string> peoplelist = new List<string>();

                try
                {
                    using (PeoplesEntities database = new PeoplesEntities())
                    {
                        var peoples = from person in database.Person select person.PId;
                        peoplelist = peoples.ToList();
                    }
                }
                catch
                {
                    //ignore exceptions
                }

                return peoplelist;
            }

            public PeopleData GetPeople(string pId)
            {
                PeopleData peopleData = null;

                try
                {
                    using (PeoplesEntities database = new PeoplesEntities())
                    {
                        Person matchingPerson = database.Person.First(
                            p => String.Compare(p.PId, pId) == 0);

                        peopleData = new PeopleData()
                        {
                            Forname = matchingPerson.Forname,
                            Lastname = matchingPerson.Lastname
                        };
                    }
                }
                catch
                {
                    //Igone exception
                }
                return peopleData;
            }
        }
    }
}
