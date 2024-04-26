using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fieldd_Constant
{
    public class Employee
    {
        //Constants -> <Access Modifier>  <DataType> <constName> =  <inital val>
        public double tax = 0.03;
        //Fields -> <Access Modifier>  <DataType> <fieldName> =  <inital val (optional)>
        //Access Modifier -> public - private - protected
        public string fName, lName;
        public double loggedHrs, wage;

        public double calcNetSalary(double loggedHrs, double wage)
        {
            return (loggedHrs * wage) - (loggedHrs * wage * tax);
        }

    }
}
