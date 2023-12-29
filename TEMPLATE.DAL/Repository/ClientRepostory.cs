using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEMPLATE.DAL.Data;
using TEMPLATE.DAL.Generic;
using TEMPLATE.Models.Models;

namespace TEMPLATE.DAL.Repository
{
    public class ClientRepostory : GenericRepository<Client>, IClientRepostory
    {
        private readonly ApplicationDbContext _db;
        public ClientRepostory(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        public void Update(Client model)
        {
            _db.Update(model);
        }
    }
}
