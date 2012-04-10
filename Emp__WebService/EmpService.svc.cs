using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Emp_Business_Layer;
using Emp_Model_Layer;
using System.Web.Script.Serialization;

namespace Emp__WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class EmpService : IEmpService
    {


         //[WebInvoke(UriTemplate ="Create",
         //  Method="GET",
         //    RequestFormat = WebMessageFormat.Json
         //    , ResponseFormat = WebMessageFormat.Json
         //    , BodyStyle = WebMessageBodyStyle.Bare)]
        public bool CreateEmployee(Employee Jemp)
        {
            JavaScriptSerializer objJSSerializer = new JavaScriptSerializer();
            //Employee emp = objJSSerializer.Deserialize<Employee>(Jemp);
            Emp_BL bl = new Emp_BL();
            if (bl.CreateEmployee(emp))
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }//end of Create employee

        [WebGet(UriTemplate = "Select",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        public List<Employee> SelectEmployees()
        {
            List<Employee> list = new List<Employee>();
            Emp_BL bl = new Emp_BL();
            list = bl.SelectEmployess();
            return list;
        }

    }
}
