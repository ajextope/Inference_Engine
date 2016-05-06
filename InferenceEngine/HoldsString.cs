using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceEngine
{
    class HoldsString: NodeOrStringInterface
    {
        string _value;

<<<<<<< HEAD
=======
        public HoldsString(string value)
        {
            _value = value;
        }

>>>>>>> 58c81833fd12553b71f39e1aa8899d9112d3e04e
        public Node GetNode()
        {
            return new LeafNode(_value);
        }
<<<<<<< HEAD
=======

        public bool Equals(string checkValue)
        {
            return _value.Equals(checkValue);
        }
>>>>>>> 58c81833fd12553b71f39e1aa8899d9112d3e04e
    }
}
