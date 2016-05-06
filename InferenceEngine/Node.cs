using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceEngine
{
    abstract class Node: NodeOrStringInterface
    {
        public Node GetNode()
        {
            return this;
        }
<<<<<<< HEAD
=======

        public bool Equals(string checkValue)
        {
            return false;
        }
>>>>>>> 58c81833fd12553b71f39e1aa8899d9112d3e04e
    }
}
