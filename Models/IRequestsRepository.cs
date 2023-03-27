using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public interface IRequestsRepository
    {
        IEnumerable<Request> AllRequests { get; }

        void SaveRequest(Request requests);


    }
}
