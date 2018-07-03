using System;
using BertoniApi;

namespace BertoniServices
{
    public class CommentsService : ICommentsService
    {
        #region Implementation of ICommentsService

        public CommentCollection PhotoComments(string photoId)
        {
            return Helper.Helper.Comments.PhotoComments(Convert.ToInt32(photoId));
        }

        #endregion
    }
}
