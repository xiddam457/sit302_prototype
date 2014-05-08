using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sit302_prototype.Models.DAO;
using sit302_prototype.Models.DAO.Impl;
using sit302_prototype.Models.Impl;
using sit302_prototype.Models.Manager;

namespace sit302_prototype.Controllers
{
    public class PlannerWizardController : Controller
    {
        private const string SESSION = "planId";

        //
        // GET: /PlannerWizard/
        public ActionResult Index()
        {
            if (Session[SESSION] == null) {
                Session[SESSION] = new Plan();
            }

            CourseDao dao = new CourseDao();
            ViewBag.courses = dao.getAllCourses();

            return View();
        }

        [HttpPost]
        public ActionResult SelectMajor(string course) {
            CourseDao courseDao = new CourseDao();
            MajorDao majorDao = new MajorDao();
            Plan plan = (Plan)Session[SESSION];

            Course selectedCourse = courseDao.getByCode(course);
            plan.selectedCourse = selectedCourse;

            ViewBag.majors = selectedCourse.majors;

            return View();
        }

        [HttpPost]
        public ActionResult ShowGrid(string major) {
            MajorDao majorDao = new MajorDao();
            UnitDao unitDao = new UnitDao();
            Plan plan = (Plan)Session[SESSION];

            PlanningManager manager = new PlanningManager(plan);

            Major selectedMajor = majorDao.getByCode(major);

            plan.selectedMajor = selectedMajor;

            List<Unit> coreUnits = unitDao.getAllCoreUnits();
            List<Unit> majorUnits = unitDao.getAllUnitsForMajor(selectedMajor);

            //prototype - generate list of combined and make a table
            List<Unit> prototype = new List<Unit>();
            prototype.AddRange(coreUnits);
            prototype.AddRange(majorUnits);

            ViewBag.units = prototype;

            return View();
        }
    }
}
