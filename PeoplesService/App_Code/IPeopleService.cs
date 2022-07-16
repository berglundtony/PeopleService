using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PeopleLibrary;

namespace Peoples
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPeopleService
    {

        [OperationContract]
        List<int> ListPeoples();

        [OperationContract]
        Person GetPerson(int pId);

        [OperationContract]
        List<Family> GetFamily(int? pId);

        [OperationContract]
        Telephone GetTelephone(int? pFId);

        [OperationContract]
        Address GetAddress(int? pfId);
    }

}
