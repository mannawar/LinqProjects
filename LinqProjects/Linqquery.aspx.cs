using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqProjects
{
    public partial class Linqquery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //IEnumerable<Employee> queryResult =  Employee.GetAllStudents().Where(employee => employee.Gender == "Male");
            IEnumerable<Employee> queryResult = from Employee in Employee.GetAllStudents()
                                                where Employee.Gender == "Female"
                                                select Employee;

            GridView1.DataSource = queryResult;
            GridView1.DataBind();
        }
    }
}