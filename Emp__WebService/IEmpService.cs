using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Emp_Model_Layer;
namespace Emp__WebService
{
  
    [ServiceContract]
    public interface IEmpService
    {
      
        [OperationContract]
        [WebInvoke(UriTemplate = "Create/{Jemp}",
          Method = "GET"
            , ResponseFormat = WebMessageFormat.Json
            , BodyStyle = WebMessageBodyStyle.Wrapped)]
        
        bool CreateEmployee(string Jemp);
        
       
        [OperationContract]
        
        List<Employee> SelectEmployees();

        
    }


   
}
