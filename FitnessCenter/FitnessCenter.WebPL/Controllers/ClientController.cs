using FitnessCenter.BLL.Interface;
using FitnessCenter.Entities;
using System.Web.Mvc;
using DependencyResolver = FitnessCenter.Common.DependenciesResolver;

namespace FitnessCenter.WebPL.Controllers
{
    public class ClientController : Controller
    {
        IClientLogic _clientlogic = DependencyResolver.ClientLogic;
        // GET: Client
        [HttpGet]
        public ActionResult Index()
        {
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
            _clientlogic.Add(client);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(Client client)
        {
            return View(client);
        }

        [HttpPost]
        public ActionResult Update(int SubscriptionNumber, int? IdCoach)
        {
            _clientlogic.Update(SubscriptionNumber, IdCoach);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int SubscriptionNumber)
        {
            _clientlogic.Delete(SubscriptionNumber);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult FindLastName()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FindlastName(string lastname)
        {
            var clients = _clientlogic.GetByLastName(lastname);
            return View("Index", clients);
        }
    }
}