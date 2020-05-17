using FitnessCenter.BLL.Interface;
using FitnessCenter.Entities;
using System.Collections.Generic;
using System.Web.Mvc;
using DependenciesResolver = FitnessCenter.Common.DependenciesResolver;
namespace FitnessCenter.WebPL.Controllers
{
    public class CoachController : Controller
    {
        ICoachLogic _coachlogic = DependenciesResolver.CoachLogic;
        // GET: Coach
        [HttpGet]
        public ActionResult Index()
        {
            return View(_coachlogic.GetAll());
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Coach coach)
        {
            _coachlogic.Add(coach);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public ActionResult FindLastName()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FindlastName(Coach coach)
        {
            var coachs = _coachlogic.GetByLastName(coach.LastName);
            return View("Index", coachs);
        }

        [HttpGet]
        public ActionResult Delete(long Phone)
        {
            _coachlogic.Delete(Phone);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult FindByPhone()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FindByPhone(Coach coach)
        {
            IEnumerable<Coach> coachs = new List<Coach>() { _coachlogic.GetByPhone(coach.Phone) };
            return View("Index", coachs);
        }
        
    }
}