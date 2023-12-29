using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEMPLATE.DAL.Data;
using TEMPLATE.DAL.Repository;

namespace TEMPLATE.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IClientRepostory Clients { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Clients = new ClientRepostory(_db);
        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
