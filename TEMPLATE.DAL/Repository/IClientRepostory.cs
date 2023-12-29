using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEMPLATE.DAL.Generic;
using TEMPLATE.Models.Models;

namespace TEMPLATE.DAL.Repository
{
    public interface IClientRepostory : IGenericRepository<Client>
    {
        void Update(Client model);
    }
}
