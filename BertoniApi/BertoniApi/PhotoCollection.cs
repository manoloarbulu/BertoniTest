using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BertoniApi
{
    [Serializable]
    [DataContract(Name = "Photos")]
    public class PhotoCollection : ICollection<Photo>
    {
        private readonly List<Photo> _photos = new List<Photo>();

        [DataMember]
        public Photo this[int index]
        {
            get => _photos[index];
            set => _photos[index] = value;
        }

        #region Implementation of IEnumerable

        public IEnumerator<Photo> GetEnumerator()
        {
            return _photos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of ICollection<Photo>

        public void Add(Photo item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (_photos.Contains(item)) return;

            _photos.Add(item);
        }

        public void Clear()
        {
            _photos.Clear();
        }

        public bool Contains(Photo item)
        {
            return _photos.Contains(item);
        }

        public void CopyTo(Photo[] array, int arrayIndex)
        {
            _photos.CopyTo(array, arrayIndex);
        }

        public bool Remove(Photo item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            return _photos.Remove(item);
        }

        public int Count => _photos.Count;
        public bool IsReadOnly => false;

        #endregion
    }
}