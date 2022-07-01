using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public interface BST<T> where T : IComparable<T>
    {
        public void Insert(T value);

        public bool Exists(T value);

        public int Count();
    }
}
