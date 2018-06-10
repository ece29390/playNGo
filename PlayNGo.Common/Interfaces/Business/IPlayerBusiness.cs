using PlayNGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNGo.Common.Interfaces.Business
{
    public interface IPlayerBusiness
    {
        IList<Person> GetAll();
        IList<Person> GetByPage(int pageNumber, int pageSize);
        int GetAllPlayersCount();
    }
}
