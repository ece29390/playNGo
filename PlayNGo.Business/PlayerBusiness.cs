using PlayNGo.Common.Interfaces.Business;
using PlayNGo.Common.Interfaces.Repository;
using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Business
{
    public class PlayerBusiness : IPlayerBusiness
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerBusiness(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public IList<Person> GetAll()
        {
            var list = _playerRepository.GetAll().ToList();
            return list;
        }

        public int GetAllPlayersCount()
        {
            var count = _playerRepository.GetAll().Count();
            return count;
        }

        public IList<Person> GetByPage(int pageNumber, int pageSize)
        {            
            var list = _playerRepository.GetAll()
                .OrderBy(p=>p.LastName)                
                .Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return list;
        }
    }
}
