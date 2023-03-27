using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public interface IToolListRepository
    {
        IEnumerable<ToolList> ToolList { get; }

        void SaveToolList(ToolList toolList);

    }
}
