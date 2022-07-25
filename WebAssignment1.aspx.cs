using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace WebAssignment1
{
    public partial class WebAssignment1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var stulist = StudentList();
            DropDown.DataSource = stulist;
            DropDown.DataTextField = "Fname";
            DropDown.DataValueField = "Rollno";
            DropDown.DataBind();


        }
        
        public class Student
        {
           public string Fname { get; set; }
           public string Name { get; set; }
           public  string Rollno { get; set; }
           
        }
        public static List<Student> StudentList() 
        {
            var myList = new List<Student>();
            myList.Add(new Student() { Fname= "Ali", Name ="Hadir", Rollno="19" });
            myList.Add(new Student() { Fname = "Hamza", Name = "Mushtaq", Rollno = "33" });
            myList.Add(new Student() { Fname = "Rida", Name = "Fatima", Rollno = "44" });
            myList.Add(new Student() { Fname = "Iram", Name = "Fiyaz", Rollno = "43" });
            myList.Add(new Student() { Fname = "Hadiqa", Name = "Rabnawaz", Rollno = "42" });
            myList.Add(new Student() { Fname = "Aliya", Name = "Hadi", Rollno = "192" });
            myList.Add(new Student() { Fname = "Alim", Name = "baloch", Rollno = "59" });

            return myList;


        }
        [WebMethod]
        public static List<string> DisplayData(string student)
        {
            var stulist = StudentList();
            var dispStudent = new List<string>(); //data of selected student sent back to ajax

            foreach (var attribute in stulist)
            {
                if (attribute.Rollno == student)
                {
                    dispStudent.Add(attribute.Fname);
                    dispStudent.Add(attribute.Name);
                    dispStudent.Add(attribute.Rollno);
                }

            }
            return dispStudent;
        }


    }
}