using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class UserRepository
    {
        private DLContext _context;

        public UserRepository(DLContext context)
        {
            _context = context;
        }

        public void Insert(User user)
        {
            Console.WriteLine("Insert");
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Entry<User>(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges(); 
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public IQueryable<User> getList()
        {
            IQueryable<User> result = _context.Users;
            return result;
        }

        public void getListOfLastElements()
        {
        }
    }
}
