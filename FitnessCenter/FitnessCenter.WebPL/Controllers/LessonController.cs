using FitnessCenter.BLL.Interface;
using FitnessCenter.Common;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependenciesResolver = FitnessCenter.Common.DependenciesResolver;
namespace FitnessCenter.WebPL.Controllers
{
    public class LessonController : Controller
    {
        ILessonsLogic _lessonlogic = DependenciesResolver.LessonsLogic;
        // GET: Lesson
        [HttpGet]
        public ActionResult Index()
        {
            return View(_lessonlogic.GetAll());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Lesson lesson)
        {
            _lessonlogic.Add(lesson);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            _lessonlogic.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult LessonByCoach()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LessonByCoach(Coach coach)
        {
            var _lesson = _lessonlogic.GetAllLessonByPhoneCoach(coach.Phone);
            return View("Index", _lesson);
        }

        [HttpGet]
        public ActionResult LessonByClient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LessonByClient(Client cleint)
        {
            var _lesson = _lessonlogic.GetAllLessonBySubNumClient(cleint.SubscriptionNumber);
            return View("Index", _lesson);
        }

        [HttpGet]
        public ActionResult LessonByHall()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LessonByHall(string namehall)
        {
            var _lesson = _lessonlogic.GetAllLessonByNameHall(namehall);
            return View("Index", _lesson);
        }
    }
}