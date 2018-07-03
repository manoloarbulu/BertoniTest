using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BertoniApi
{
    [Serializable]
    [CollectionDataContract(Name = "users")]
    public class UsuarioCollection : ICollection<Usuario>
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();

        public Usuario this[int index]
        {
            get => _usuarios[index];
            set => _usuarios[index] = value;
        }

        #region Implementation of IEnumerable

        public IEnumerator<Usuario> GetEnumerator()
        {
            return _usuarios.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of ICollection<Usuario>

        public void Add(Usuario item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (_usuarios.Contains(item)) return;

            _usuarios.Add(item);
        }

        public void Clear()
        {
            _usuarios.Clear();
        }

        public bool Contains(Usuario item)
        {
            return _usuarios.Contains(item);
        }

        public void CopyTo(Usuario[] array, int arrayIndex)
        {
            _usuarios.CopyTo(array, arrayIndex);
        }

        public bool Remove(Usuario item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            return _usuarios.Remove(item);
        }

        public int Count => _usuarios.Count;
        public bool IsReadOnly => false;

        #endregion
    }
}