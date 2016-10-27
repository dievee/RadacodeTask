using RadacodeTask.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadacodeTask.Models.Concrete
{
    public class EFIdeaRepository : IIdeaRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<Idea> Ideas { get { return context.Ideas; } }
    }
}