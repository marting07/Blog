using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class CommentRepository
    {
        private DLContext _context;

        public CommentRepository(DLContext context)
        {
            _context = context;

        }

        public void Insert(Comment comment)
        {
            Console.WriteLine("Insert");
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void Update(Comment comment)
        {
            _context.Entry<Comment>(comment).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Comment comment)
        {
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }

        public IQueryable<Comment> getList()
        {
            IQueryable<Comment> result = _context.Comments;
            return result;
        }

        public void getListOfLastElements()
        {
        }
    }
}
