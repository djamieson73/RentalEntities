using Entities.Models;
using System.IO.Pipelines;


namespace Entities.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }



    }

}






