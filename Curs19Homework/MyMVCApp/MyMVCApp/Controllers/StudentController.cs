using MyMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApp.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>
            {
                new Student() { ID=1, StudentName="John", Age=18},
                new Student() { ID=2, StudentName="Steve", Age=21},
                new Student() { ID=3, StudentName="Bill", Age=25},
                new Student() { ID=4, StudentName="Ram", Age=20},
                new Student() { ID=5, StudentName="Ron", Age=31},
                new Student() { ID=6, StudentName="Chris", Age=17},
                new Student() { ID=7, StudentName="Rob", Age=19},
            };

        //GET: Student
        public ActionResult Index()
        {
            //Get students from the db in the real application
            return View(studentList);
        }

        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.ID == id).FirstOrDefault();
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var name = std.StudentName;
            var age = std.Age;
            //write code to update student
            return RedirectToAction("Index");
        }

        //-----------------------------------//



        //-----------------------------------//
        //public string Index()
        //{
        //    return "This is Index action method of StudentController";
        //}

        //[HttpPost]
        //public ActionResult Edit(Student std)
        //{
        //    return RedirectToAction("Index");
        //}

        //[HttpDelete]
        //public ActionResult Delete(int ID)
        //{
        //    return RedirectToAction("Index");
        //}

        //public StudentController()
        //{ }


        ////This action method will be invoked on http://localhost/student/find/1 request instead of http://localhost/student/getbyid/1 request.
        //[ActionName("find")]
        //public ActionResult GetById(int id)
        //{
        //    //get student from the database
        //    return View();
        //}

        //[NonAction]
        //public Student GetStudent(int id)
        //{
        //    List<Student> studentList = new List<Student>();
        //    return studentList.Where(s => s.ID == id).FirstOrDefault();
        //}

        ////-----------------------------------------------------//

        //[HttpPost]
        //public ActionResult PostAction()
        //{
        //    return View("Index");
        //}

        //[HttpPut]
        //public ActionResult PutAction()
        //{
        //    return View("Index");
        //}

        //[HttpDelete]
        //public ActionResult DeleteAction()
        //{
        //    return View("Index");
        //}

        //[HttpHead]
        //public ActionResult HeadAction()
        //{
        //    return View("Index");
        //}

        //[HttpOptions]
        //public ActionResult OptionsAction()
        //{
        //    return View("Index");
        //}

        //[HttpPatch]
        //public ActionResult PatchAction()
        //{
        //    return View("Index");
        //}

        //[AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        //public ActionResult GetAndPostAction()
        //{
        //    return RedirectToAction("Index");
        //}
    }
}