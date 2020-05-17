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
        IHallLogic _halllogic = DependenciesResolver.HallLogic;
        // GET: Hall
        [HttpGet]
        public ActionResult Index()
        {    
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
            _halllogic.Add(hall);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(string NameHall)
        {
            _halllogic.Delete(NameHall);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult FindByNameHall()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FindByNameHall(string NameHall)
        {
            IEnumerable<Hall> hall = new List<Hall>() { _halllogic.GetByName(NameHall) };
            return RedirectToAction("Index", hall);
        }

    }
}