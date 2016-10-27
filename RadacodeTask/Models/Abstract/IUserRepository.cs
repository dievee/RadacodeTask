using System.Collections.Generic;

namespace RadacodeTask.Models.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> Users { get; }
    }
}
