namespace Linq
{
    internal class Program
    {   //language integrated query
        //1-Linq method syntax - select,where,join,groupjoin,
        //2-Linq squery syntax 
        //  deferred execution of linq querie, Immediate execution

        //Linq encapsulated 2 static class -queryable - enumarable

        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> deparmentList = Data.GetDepartments();
            List<Role> roleList = Data.GetRoles();
            //method syntax - deffered execution example
            var result = employeeList.Select(e => new
            {
                FullName = e.FirstName,
                LastName = e.LastName,
                Salary = e.AnnualSalary
            }).Where( z => z.Salary > 5000);

            //method syntax- immediate execution example
            //var resultImmediet = (employeeList.Select(e => new
            //{
            //    FullName = e.FirstName,
            //    LastName = e.LastName,
            //    Salary = e.AnnualSalary
            //}).Where(z => z.Salary > 5000)).ToList();


            //query syntax - deffered execution
            //var query = from employee in employeeList
            //            where employee.AnnualSalary > 5000
            //            select new
            //            {
            //                FirstName = employee.FirstName,
            //                LastName = employee.LastName,
            //                Salary = employee.AnnualSalary

            //            };


            //Inner JOIN LINQ
            //method syntax join table
            //var methodResult = employeeList.Join(deparmentList,
            //               employee => employee.DepartmentId,
            //               department => department.Id,
            //               (employee, department) => new {
            //               FirstName = employee.FirstName,
            //               Lastname = employee.LastName,
            //               DepartmentName = department.LongName
            //               }
            //                 );
            ////query syntax
            //var queryResult = from role in roleList
            //                  join employee in employeeList
            //                  on role.Id equals employee.RoleId
            //                  join department in deparmentList
            //                  on employee.DepartmentId equals
            //                  department.Id
            //                  select new
            //                  {

            //                      FullName = employee.FirstName + " " + employee.LastName,
            //                      AnnualSalary = employee.AnnualSalary,
            //                      RoleType = role.RoleType,
            //                      Department = department.LongName
            //                  };

            //leftJoin - method Syntax
            //var methodResult = (deparmentList.GroupJoin(employeeList,
            //    z => z.Id,
            //    x => x.DepartmentId,
            //    (departmentType,employeegroup) => new
            //    {
            //        Employee = employeegroup,
            //        DepartmentName = departmentType.LongName

            //    }

            //    )).ToList();

            //leftJoin - Query Syntax

            //var queryResult = from dep in deparmentList
            //                  join employee in employeeList
            //                  on dep.Id equals employee.Id into employeeGroup
            //                  select new
            //                  {
            //                      DepartmentName = dep.LongName,
            //                      Employee = employeeGroup,

            //                  };



            //foreach (var employee in methodResult)
            //{

            //    Console.WriteLine("{0} : {1} :{2} : {3}", employee.FullName, employee.AnnualSalary, employee.RoleType, employee.Department);



            //}


           /*
            * LINQ OPERATORS!!!
            * 
            * 
            * 
            */




        }
    }
}