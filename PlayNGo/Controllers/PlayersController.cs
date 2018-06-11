using PlayNGo.Common.Interfaces.Business;
using PlayNGo.View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlayNGo.Controllers
{
    public class PlayersController : Controller
    {
        private const int PageSize = 5;
        private readonly IPlayerBusiness _playerBusiness;
        private const string DisplayInformationFormat = "Displaying {0} of {1}";

        public PlayersController(IPlayerBusiness playerBusiness)
        {
            _playerBusiness = playerBusiness;
        }
        // GET: Players
        public ActionResult Index()
        {
            var model = new PlayersModel();
            model.SelectedTableStyle = "greenTable";
            model.TotalCount = _playerBusiness.GetAllPlayersCount();
            model.CurrentPage = 1;
                                  
            return Index(model);
        }

        private ActionResult Index(PlayersModel model)
        {
            GetPlayers(model, model.CurrentPage);
            ViewBag.SelectedStyle = model.SelectedTableStyle;

            model.EnableNextPage = model.CurrentPage >= 1 && (model.CurrentListOfPlayers.Count==PageSize);
            model.EnablePreviousPage = model.CurrentPage > 1;

            if(model.CurrentListOfPlayers.Count == PageSize)
            {
                SetupMessage(model, model.CurrentPage * 1);
            }
            else
            {
                SetupMessage(model, model.TotalCount);
            }

            return View("Index", model);
        }

        private void SetupMessage(PlayersModel model, int currentCount)
        {
            ViewBag.Message = string.Format(DisplayInformationFormat, currentCount, model.TotalCount);
            
        }

        private void GetPlayers(PlayersModel model, int currentPage)
        {
            var list = _playerBusiness.GetByPage(currentPage, PageSize);
            model.CurrentListOfPlayers = list.ToList();
        }

        public ActionResult NextResult(PlayersModel model)
        {
            model.CurrentPage += 1;
            return Index(model);
        }

        public ActionResult PreviousResult(PlayersModel model)
        {
            model.CurrentPage -= 1;
            return Index(model);
        }   
        [HttpPost]
        public ActionResult ChangeView(PlayersModel model)
        {
            model.CurrentPage = 1;
            return Index(model);
        }
    }
}
