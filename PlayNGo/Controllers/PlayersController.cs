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
            model.TotalCount = _playerBusiness.GetAllPlayersCount();

            var currentPage = model.CurrentPage + 1;
           

            var list = _playerBusiness.GetByPage(currentPage, PageSize);
            model.CurrentListOfPlayers = list.ToList();
           
            ViewBag.Message = string.Format(DisplayInformationFormat, model.CurrentListOfPlayers.Count, model.TotalCount);
            model.CurrentPage = currentPage;

            return View(model);
        }
        
        public ActionResult NextResult(PlayersModel model)
        {
            var currentPage = model.CurrentPage + 1;

            var list = _playerBusiness.GetByPage(currentPage, PageSize);
            model.CurrentListOfPlayers = list.ToList();

            if (model.CurrentListOfPlayers.Count ==PageSize)
            {
                ViewBag.Message = string.Format(DisplayInformationFormat, currentPage * PageSize, model.TotalCount);
                model.CurrentPage = currentPage;
            }
            else
            {
                ViewBag.Message = string.Format(DisplayInformationFormat, model.TotalCount, model.TotalCount);
            }
           

            return View("Index",model);
        }

      
    }
}
