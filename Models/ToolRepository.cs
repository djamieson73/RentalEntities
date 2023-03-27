using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{

    public class ToolRepository : IToolRepository

    {
        private readonly EntitiesDbContext _entitiesDbContext;
        public ToolRepository(EntitiesDbContext entitiesDbContext)
        {
            _entitiesDbContext = entitiesDbContext;
        }

        public IEnumerable<Tool> AllTools
        {
            get
            {
                return _entitiesDbContext.Tools;
            }
        }

    }
}
