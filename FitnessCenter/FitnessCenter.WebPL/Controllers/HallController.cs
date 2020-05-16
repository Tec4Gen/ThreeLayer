using FitnessCenter.BLL.Interface;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DependenciesResolver = FitnessCenter.Common.DependenciesResolver;

namespace FitnessCenter.WebPL.Controllers
{
    public class HallController : Controller
    {
        IHallLogic _halllogic;
        // GET: Hall
        [HttpGet]
        public ActionResult Index()
        {
            _halllogic = DependenciesResolver.HallLogic;
            return View(_halllogic.GetAll());
        }
        [HttpGet]
        public ActionResult Add()
        {   
            return View();
        }
        [HttpPost]
        public ActionResult Add(Hall hall)
        {
            _halllogic = DependenciesResolver.HallLogic;
            _halllogic.Add(hall);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Hall coach)
        {
            _halllogic = DependenciesResolver.HallLogic;
            _halllogic.Delete(coach.NameHall);
            return RedirectToAction("Index");
        }
    }
}