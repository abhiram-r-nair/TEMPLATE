using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEMPLATE.DAL.Repository;

namespace TEMPLATE.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IClientRepostory Clients { get; }

        void Save();
    }
}
