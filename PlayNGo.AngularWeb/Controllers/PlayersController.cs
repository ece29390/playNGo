using PlayNGo.Common.Interfaces.Business;
using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlayNGo.AngularWeb.Controllers
{
    [RoutePrefix("api/players")]
    [AllowAnonymous]
    public class PlayersController : ApiController
    {
        
        private readonly IPlayerBusiness _playerBusiness;
       
        public PlayersController(IPlayerBusiness playerBusiness)
        {
            _playerBusiness = playerBusiness;
        }

        [HttpGet]            
        public int GetTotalNumberOfPlayers()
        {
            var total = _playerBusiness.GetAllPlayersCount();
            return total;
        }

        [HttpGet]
        public List<Person> GetPlayersBy(int currentPage,int pageSize)
        {
            var result = _playerBusiness.GetByPage(currentPage, pageSize);
            return result.ToList();
        }
    }
}
