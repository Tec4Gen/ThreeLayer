using FitnessCenter.BLL.Interface;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DependencyResolver = FitnessCenter.Common.DependenciesResolver;

namespace FitnessCenter.WebPL.Controllers
{
    public class ClientController : Controller
    {
        IClientLogic _clientlogic;
        // GET: Client
        [HttpGet]
        public ActionResult Index()
        {
            _clientlogic = DependencyResolver.ClientLogic;

            return View("Index", _clientlogic.GetAll());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Client client)
        {
            _clientlogic = DependencyResolver.ClientLogic;
            _clientlogic.Add(client);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Client client)
        {
            _clientlogic = DependencyResolver.ClientLogic;
            _clientlogic.Update(client.SubscriptionNumber, (int)client.IDCoach);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Client client)
        {
            _clientlogic = DependencyResolver.ClientLogic;
            _clientlogic.Delete(client.SubscriptionNumber);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult FindLastName()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FindlastName(Client client)
        {
            _clientlogic = DependencyResolver.ClientLogic;
            var clients = _clientlogic.GetByLastName(client.LastName);
            return View("Index", clients);
        }

    }
}