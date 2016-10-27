using System.Collections.Generic;

namespace RadacodeTask.Models.Abstract
{
    public interface IIdeaRepository
    {
        IEnumerable<Idea> Ideas { get; }    
    }
}
