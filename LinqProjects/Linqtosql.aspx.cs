using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqProjects
{
    public partial class Linqtosql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentsDataContext dataContext = new StudentsDataContext();

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GridView1.DataSource = from number in numbers
                                   where (number % 2) == 0
                                   select number;

            //GridView1.DataSource = from student in dataContext.Students
            //                       where student.Gender == "Male"
            //                       select student;

            GridView1.DataBind();
        }
    }
}