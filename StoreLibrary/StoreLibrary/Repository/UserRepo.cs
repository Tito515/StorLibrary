using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary.Database;
using StoreLibrary.Models;

namespace StoreLibrary.Repository
{
    class UserRepo : IRepository<User>
    {
        private readonly StorLibDbContext _context = new StorLibDbContext();
        public void Create(User _entity)
        {
            if (_entity != null)
            {
                var user = new User()
                {
                    ID = Guid.NewGuid(),
                    UserNAme = _entity.UserNAme,
                    Role = Role.Employee

                };
                _context.USers.Add(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _context.USers.ToList();
        }

        public void Remove(User _entity)
        {
            if (_entity !=null)
            {
                _context.USers.Remove(_entity);
                _context.SaveChanges();
            }
        }

        public void Update(User _entity)
        {
            throw new NotImplementedException();
        }
    }
}
