using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    class WideTreeTraveller: TreeTraveller, ITravelTree
    {
        protected Queue<Node> _nodeQueue = new Queue<Node>();

        public WideTreeTraveller( Node rootNode): base(rootNode)
        {
        }

        public List<Node> DoTravelTree()
        {
            List<Node> result = new List<Node>();

            _nodeQueue.Enqueue(_rootNode);

            while (_nodeQueue.Count != 0)
            {
                Node n = _nodeQueue.Dequeue();
                result.Add( n );

                foreach ( Node nodeChild in n.Children)
                    _nodeQueue.Enqueue(nodeChild);
            }

            return result;
        }

        protected List<Node> GetChildren(Node n, List<Node> nodeList)
        {
            foreach (Node childNode in n.Children)
            {
                nodeList.Add(childNode);
                nodeList = GetChildren(childNode, nodeList);
            }

            return nodeList;

        }



    }
}
