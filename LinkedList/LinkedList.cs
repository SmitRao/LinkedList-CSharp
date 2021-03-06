﻿using System;
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

            Node ref = this.front; // Errors... start
            for(int i = 0; i < index - 1; i++)
            {
                ref = ref.next;
            }

            if (ref.next is this.back)
            {
                this.back = ref;
                this.back.next = null;
                this.size--;
                return;
            } 

            ref.next = ref.next.next;
            --this.size;
            return;
        } // Errors... end

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
