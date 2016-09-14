using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    class DeepTreeTraveller: TreeTraveller, ITravelTree
    {
        protected Stack<Node> _nodeStack = new Stack<Node>();

        public DeepTreeTraveller( Node rootNode): base(rootNode)
        {
        }

        public List<Node> DoTravelTree()
        {
            List<Node> result = new List<Node>();

            _nodeStack.Push(_rootNode);

            while (_nodeStack.Count != 0)
            {
                Node n = _nodeStack.Pop();
                result.Add(n);

                foreach (Node nodeChild in n.Children)
                    _nodeStack.Push(nodeChild);
            }

            return result;
        }


    }
}
