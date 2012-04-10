using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Emp_Model_Layer
{
    public class Employee1
    {
                private string _FirstName;

                public string FirstName
                {
                  get { return _FirstName; }
                  set { _FirstName = value; }
                }
                private string _LastName;

                public string LastName
                {
                    get { return _LastName; }
                    set { _LastName = value; }
                }
                private string _Address;

                public string Address
                {
                    get { return _Address; }
                    set { _Address = value; }
                }
                private string _DOB;

                public string DOB
                {
                    get { return _DOB; }
                    set { _DOB = value; }
                }
                private string _Sex;

                public string Sex
                {
                    get { return _Sex; }
                    set { _Sex = value; }
                }

            //Employee class parameterless constructor
                public Employee():this("","","","","")
                {
                   
                }

                //Employee class parameterised constructor
                public Employee(string _FirstName,string _LastName,string _Address,string _DOB,string _Sex)
                {
                    this._FirstName=_FirstName;
                    this._LastName=_LastName;
                    this._Address=_Address;
                    this._DOB=_DOB;
                    this._Sex=_Sex;
                }//end of parameterised constructor
            
               //ToString Method()
                public string ToString()
                {
                    return "First Name : " + this.FirstName + "\nLast Name : " + this.LastName + "\nAddress : " + this.Address + "\n DOB : " + this.DOB + "\n Gender : " + this.Sex;
                }//end of to string

               
            }//end of employee class

}//end of Emp_Model_Layer namespace
