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
        public Node front;
        public Node back;
        public int size;
        
        public LinkedList(object item)
        {
            this.front = this.back = new Node(item);
            this.size = 1;
        }

        public void Append(object toAppend)
        {
            this.back = new Node(toAppend);
            this.front.next = this.back;
            this.size++;
        }

        public void Prepend(object toPrepend)
        {
            Node newFront = new Node(toPrepend);
            newFront.next = this.front;
            this.front = newFront;
            this.size++;
        }

        public void RemoveIndex(int index)
        {
            if(index >= this.size || index < 0)
            {
                throw new IndexOutOfRangeException("Oops... sorry, your index is out of range.");
            }

            if(this.size < 2)
            {
                this.front = this.back = null;
                this.size--;
                return;
            }

            ref = this.front;
            for(int i = 0; i < index; i++)
            {

            }
            --this.size;
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
