using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentMan : ICommentService
    {
        ICommentDAL commentDAL;

        public CommentMan(ICommentDAL commentDAL)
        {
            this.commentDAL = commentDAL;
        }

        public int AddComment(Comment comment)
        {
            return commentDAL.Add(comment);
        }

        public int DeleteComment(Comment comment)
        {
            return commentDAL.Delete(comment);
        }

        public Comment GetById(int id)
        {
            return commentDAL.GetById(id);
        }

        public List<Comment> ListAllComments(Expression<Func<Comment, bool>> filter = null)
        {
            return commentDAL.ListAll();
        }

        public int UpdateComment(Comment comment)
        {
            return commentDAL.Update(comment);
        }
    }
}
