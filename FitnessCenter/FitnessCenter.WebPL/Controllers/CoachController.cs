using FitnessCenter.BLL.Interface;
using FitnessCenter.Entities;
using System.Collections.Generic;
using System.Web.Mvc;
using DependenciesResolver = FitnessCenter.Common.DependenciesResolver;
namespace FitnessCenter.WebPL.Controllers
{
    public class CoachController : Controller
    {
        ICoachLogic _coachlogic;
        // GET: Coach
        [HttpGet]
        public ActionResult Index()
        {
            _coachlogic = DependenciesResolver.CoachLogic;
            
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
            _coachlogic = DependenciesResolver.CoachLogic;
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
            _coachlogic = DependenciesResolver.CoachLogic;
            var coachs = _coachlogic.GetByLastName(coach.LastName);
            return View("Index", coachs);
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Coach coach)
        {
            _coachlogic = DependenciesResolver.CoachLogic;
            _coachlogic.Delete(coach.Phone);
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
            _coachlogic = DependenciesResolver.CoachLogic;
            IEnumerable<Coach> coachs = new List<Coach>() { _coachlogic.GetByPhone(coach.Phone) };
            return View("Index", coachs);
        }
        
    }
}