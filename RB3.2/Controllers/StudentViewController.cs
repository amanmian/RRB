using RB3._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RB3._2.Controllers
{
    public class StudentViewController : Controller
    {
        StudentContext context;
        public StudentViewController()
        {
            context = new StudentContext();
        }
        // GET: StudentView
        public ActionResult Index()
        {
            return View();
        }
         /*public ActionResult GetData()
          {
              using (StudentContext db = new StudentContext())
              {

                  var StudentData = db.students.OrderBy(a => a.Id).ToList();
                  //var StudentDetailsData = db.studentDetails.OrderBy(a => a.RollNo).ToList();
                  var StudentDetailsData = db.studentDetails.OrderBy(a => a.Id).ToList();
                  return Json(new { data = StudentDetailsData }, JsonRequestBehavior.AllowGet);


              }
          }*/
        

    }
}
