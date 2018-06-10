using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Common.Interfaces.Repository
{
    public interface IPlayerRepository
    {
        IQueryable<Person> GetAll();
    }
}
