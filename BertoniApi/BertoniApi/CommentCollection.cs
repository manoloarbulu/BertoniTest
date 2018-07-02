using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BertoniApi
{
    [Serializable]
    [CollectionDataContract(Name = "comments")]
    public class CommentCollection : ICollection<Comment>
    {
        private readonly List<Comment> _comments = new List<Comment>();

        #region Implementation of IEnumerable

        public IEnumerator<Comment> GetEnumerator()
        {
            return _comments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of ICollection<Comment>

        public void Add(Comment item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (_comments.Contains(item)) return;

            _comments.Add(item);
        }

        public void Clear()
        {
            _comments.Clear();
        }

        public bool Contains(Comment item)
        {
            return _comments.Contains(item);
        }

        public void CopyTo(Comment[] array, int arrayIndex)
        {
            _comments.CopyTo(array, arrayIndex);
        }

        public bool Remove(Comment item)
        {
            throw new NotImplementedException();
        }

        public int Count => _comments.Count;
        public bool IsReadOnly => false;

        #endregion
    }
}