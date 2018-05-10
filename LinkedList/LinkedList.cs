using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {





        public static void Main(string[] args)
        {
            Node node = new Node("Hello");
            Debug.WriteLine("Value: " + node.value + " Next: " + node.next);

        }
    }

    class Node
    {
        public object value;
        public object next;

        public Node(object value)
        {
            this.value = value;
        }
    }

    
}
