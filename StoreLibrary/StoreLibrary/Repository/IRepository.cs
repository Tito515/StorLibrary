using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Repository
{
    public interface IRepository<Entity> where Entity : class
    {
        IEnumerable<Entity> GetAll();
        void Create(Entity _entity);
        void Update(Entity _entity);
        void Remove(Entity _entity);

    }
}
