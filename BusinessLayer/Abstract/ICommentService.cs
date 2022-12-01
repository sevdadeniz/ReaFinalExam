using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        public int AddComment(Comment comment);
        public int DeleteComment(Comment comment);
        public int UpdateComment(Comment comment);
        List<Comment> ListAllComments(Expression<Func<Comment, bool>> filter = null);
        Comment GetById(int id);


    }
}
