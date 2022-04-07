using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayRollUsingThread
{
    public class EmployeePayRollOperation
    {
        List<EmployeeDetails> employeedetails = new List<EmployeeDetails>();
        public void AddEmployeePayroll(List<EmployeeDetails> listemployeedetails)
        {
            listemployeedetails.ForEach(employeeData =>
            {
                Console.WriteLine(employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine(employeeData.EmployeeName);


            });
            Console.WriteLine(this.employeedetails.ToString());


        }
        private abstract void addEmployeePayroll(EmployeeDetails emp)
        {
            employeedetails.Add(emp);
        }
        public void AddEmployeePayrollwiththread(List<EmployeeDetails> listemployeedetails)
        {
            listemployeedetails.ForEach(employeedata =>
            {
                Task tread = new Task(() =>
                {
                    Console.WriteLine(employeedata.EmployeeName);
                    this.AddEmployeePayroll(listemployeedetails);
                    Console.WriteLine(employeedata.EmployeeName);

                });
                tread.Start();
            });
            Console.WriteLine(this.employeedetails.ToString());
        }
}
