using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BertoniApi
{
    [Serializable]
    [CollectionDataContract(Name = "albums")]
    public class AlbumCollection : ICollection<Album>
    {
        private readonly List<Album> _albumes = new List<Album>();

        #region Implementation of IEnumerable

        public IEnumerator<Album> GetEnumerator()
        {
            return _albumes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of ICollection<Album>

        public void Add(Album item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (_albumes.Contains(item)) return;

            _albumes.Add(item);
        }

        public void Clear()
        {
            _albumes.Clear();
        }

        public bool Contains(Album item)
        {
            return _albumes.Contains(item);
        }

        public void CopyTo(Album[] array, int arrayIndex)
        {
            _albumes.CopyTo(array, arrayIndex);
        }

        public bool Remove(Album item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            return _albumes.Remove(item);
        }

        public int Count => _albumes.Count;
        public bool IsReadOnly => false;

        #endregion
    }
}