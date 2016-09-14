using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    public class TreeTraveller
    {
        protected Node _rootNode;

        public TreeTraveller()
        {
        }

        public TreeTraveller( Node rootNode)
        {
            _rootNode = rootNode;
        }

    }
}
