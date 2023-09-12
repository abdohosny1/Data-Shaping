using System.Collections.Generic;
using Entities.Models;
using System.Threading.Tasks;

namespace Entities.Helpers
{
    public interface IDataShaper<T>
    {
        IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldsString);
        Entity ShapeData(T entity, string fieldsString);
    }
}
