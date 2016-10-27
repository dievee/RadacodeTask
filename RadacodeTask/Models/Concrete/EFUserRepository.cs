using RadacodeTask.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadacodeTask.Models.Concrete
{
    public class EFUserRepository : IUserRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<ApplicationUser> Users { get { return context.Users; } }
    }
}