using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenceEngine
{
    class ConjunctiveNormalForm
    {
        char[] _specialCharacters;

        public ConjunctiveNormalForm()
        {
            _specialCharacters = new char[] { '(', ')', '-', '&', '+' };
        }
        public Node CreateBinaryTree(string propositionalLogic)
        {
<<<<<<< HEAD
            List<string> convertedStringList = ConvertToStringList(propositionalLogic);

=======
            List<NodeOrStringInterface> convertedStringList = ConvertToStringList(propositionalLogic);

            foreach(NodeOrStringInterface s in convertedStringList)
            {
                if (s.Equals("("))
                {

                }
            }
>>>>>>> 58c81833fd12553b71f39e1aa8899d9112d3e04e

            return null;
        }

<<<<<<< HEAD
        private List<string> ConvertToStringList(string propositionalLogic)
        {
            string tempString = "";
            List<string> returningList = new List<string>();
=======
        private List<NodeOrStringInterface> ConvertToStringList(string propositionalLogic)
        {
            string tempString = "";
            List<NodeOrStringInterface> returningList = new List<NodeOrStringInterface>();
>>>>>>> 58c81833fd12553b71f39e1aa8899d9112d3e04e

            for (int i = 0; i < propositionalLogic.Length; i++)
            {
                if(_specialCharacters.Contains(propositionalLogic[i]))
                {
                    if (!tempString.Equals(""))
                    {
<<<<<<< HEAD
                        returningList.Add(tempString);
                    }
                    returningList.Add(propositionalLogic[i].ToString());
=======
                        returningList.Add(new HoldsString(tempString));
                    }
                    returningList.Add(new HoldsString(propositionalLogic[i].ToString()));
>>>>>>> 58c81833fd12553b71f39e1aa8899d9112d3e04e
                    tempString = "";
                }
                else
                {
                    tempString += propositionalLogic[i];
                }
            }
            return returningList;
        }
    }
}
