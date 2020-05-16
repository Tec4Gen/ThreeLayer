using FitnessCenter.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyResolver = FitnessCenter.Common.DependenciesResolver;
namespace FitnessCenter.WebPL.Controllers
{
    public class LessonController : Controller
    {
        ILessonsLogic _lessonlogic;
        // GET: Lesson
        public ActionResult Index()
        {
            _lessonlogic = DependencyResolver.LessonsLogic;
            return View(_lessonlogic.GetAll());
        }
    }
}