using System.Diagnostics.Metrics;

namespace Linq_2
{
    internal class Program
    {   //LINQ OPERATOR
        //SORTING OPERATOR 1-ORDERBY 2- ORDERBYDECENDING 3-THENBY 4-THENBYDECENDING
        //GROUPING OPERATOR 1-GROUPBY 2-TOLOOKUP
        //QUANTIFIER OPERATOR 1-ALL 2-ANY 3-CONTAIN
        //FILTER OPERATOR 1-OFTYPE 2-WHERE
        //ELEMENT OPERATOR 1-ELEMENTAT 2-ELEMENTATODEFAULT 3-FIRST 4-FIRSTORDEFAULT 5-SINGLE 6-SINGLEORDEFAULT


        static void Main(string[] args)
        {

            //GET DATA FROM DATA CLASS

            //var employeeList = Data.GetEmployees();
            //var departmentList = Data.GetDepartments();

            //var methodJoin = employeeList.Join(departmentList,
            //    employee => employee.DepartmentId,
            //    department => department.Id,
            //    (employee,department) => new { 
            //        FirstName = employee.FirstName,
            //        LastName = employee.LastName,               
            //        AnnualSalary = employee.AnnualSalary,
            //        DepartmentId = department.Id,
            //        DepartmentName = department.LongName             
            //    }).OrderByDescending( z => z.DepartmentName).ThenBy( y => y.FirstName);



            //foreach (var item in methodJoin)
            //{
            //    Console.WriteLine("First Name:{0} LastName:{1} AnnualSalary:{2} Department Name: {3}",item.FirstName,item.LastName,item.AnnualSalary,item.DepartmentName);
            //}

            string input = "hello redone";
            var charArray = input.ToLower().ToCharArray();
            
            var query = charArray.GroupBy(x => x).Select(x => new {
                CharGroup = x.Key,
                Count = x.Count()
            });



            foreach (var count in query)
            {
                Console.WriteLine("{0} : {1}", count.CharGroup, count.Count);


            }
        }
    }
}