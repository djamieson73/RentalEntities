using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class RequestsRepository : IRequestsRepository
    {

        private readonly EntitiesDbContext _entitiesDbContext;
        public RequestsRepository(EntitiesDbContext entitiesDbContext)
        {
            _entitiesDbContext = entitiesDbContext;
        }

        public IEnumerable<Request> AllRequests
        {
            get
            {
                return _entitiesDbContext.Requests;
            }
        }

        public void SaveRequest(Request requests)
        {
            _entitiesDbContext.Requests.Add(requests);
            _entitiesDbContext.SaveChanges();
        }



    }
}
