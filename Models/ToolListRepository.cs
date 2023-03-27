using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ToolListRepository : IToolListRepository
    {

        private readonly EntitiesDbContext _entitiesDbContext;
        public ToolListRepository(EntitiesDbContext entitiesDbContext)
        {
            _entitiesDbContext = entitiesDbContext;
        }

        public IEnumerable<ToolList> ToolList
        {
            get
            {
                return _entitiesDbContext.ToolLists;
            }
        }

        public void SaveToolList(ToolList toolList)
        {
            _entitiesDbContext.ToolLists.Add(toolList);
            _entitiesDbContext.SaveChanges();
        }





    }
}






