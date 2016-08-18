using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class PostRepository
    {
        private DLContext _context;

        public PostRepository(DLContext context)
        {
            _context = context;
        }

        public void Insert(Post post)
        {
            Console.WriteLine("Insert");
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public void Update(Post post)
        {
            _context.Entry<Post>(post).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Post post)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges();
        }

        public IQueryable<Post> getList()
        {
            IQueryable<Post> result = _context.Posts;
            return result;
        }

        public void getListOfLastElements()
        {
        }
    }
}
