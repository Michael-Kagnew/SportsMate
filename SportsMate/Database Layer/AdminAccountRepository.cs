using SportsMate.Business_Layer.Business_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Database_Layer
{
    public class AdminAccountRepository : IRepository<AdminAccount>
    {
        private AppDbContext dbContext { get; set; }

        public AdminAccountRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public void Create(AdminAccount entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AdminAccount entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public AdminAccount GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AdminAccount entity)
        {
            throw new NotImplementedException();
        }
    }
}
