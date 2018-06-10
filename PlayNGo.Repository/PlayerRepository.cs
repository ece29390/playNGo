using PlayNGo.Common.Interfaces.Repository;
using PlayNGo.Data;
using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Repository
{
    public class PlayerRepository : IPlayerRepository,IDisposable
    {
        private  DataContext _dataContext;

        public PlayerRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        public IQueryable<Person> GetAll()
        {
            return _dataContext.Persons.AsQueryable();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
