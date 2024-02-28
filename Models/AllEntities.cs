using System.Collections;
using System.Collections.Generic;

namespace BlogApp.Models
{
    public class AllEntities
    {
        public Blog Blog { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        
    }
}
