using System;
using System.Collections.Generic;

namespace RadacodeTask.Models
{
    public class IdeaListViewModel
    {
        public IEnumerable<Idea> Ideas { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}