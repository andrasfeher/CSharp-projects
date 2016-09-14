using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    public class Node
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private List<Node> _children;

        public List<Node> Children
        {
            get { return _children; }
            set { _children = value; }
        }

        public Node( string id )
        {
            Id = id;
            Children = new List<Node>();
        }

        public void AddChild(Node n)
        {
            Children.Add(n);
        }
    }
}
