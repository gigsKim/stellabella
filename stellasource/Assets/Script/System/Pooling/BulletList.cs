using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BulletList
{
    public class Bullets<T>
    {
        private Node root;
        private int length;

        public Bullets()
        {
            root = null;
            length = 0;
        }

        public void reset()
        {
            root = null;
            length = 0;
        }
        //추가 0이면 그대로추가하고 아니면 마지막에
        public void add(T entry)
        {
            if (length == 0)
                root = new Node(entry);
            else
                getNodeAt(length - 1).next = new Node(entry);

            length++;
        }

        //인덱스값으로 노드반환받기
        private Node getNodeAt(int position)
        {
            Node temp = root;
            for (int i = 0; i < position; i++)
                temp = temp.next;
            return temp;
        }

        //인덱스정해서 추가
        public void add(T entry, int index)
        {
            if (index >= length)
                add(entry);
            else
            {
                Node prev = getNodeAt(index - 1);
                Node next = getNodeAt(index);
                prev.next = new Node(entry, next);
            }

            length++;
        }

        //인덱스에 해당하는 노드 지우기
        public void remove(int index)
        {
            if(index != 0)
            {
                getNodeAt(index - 1).next = getNodeAt(index + 1);
                length--;
            }
            else
            {
                root = getNodeAt(index).next;
            }
            
        }

        //인덱스값으로 오브젝트반환받기
        public T get(int index)
        {
            return getNodeAt(index).data;
        }

        //몇개인지 반환
        public int Length()
        {
            return length;
        }
        //노드 클래스
        public class Node
        {
            public T data;
            public Node next;

            public Node(T data)
            {
                this.data = data;
                this.next = null;
            }
            public Node(T data, Node nextNode)
            {
                this.data = data;
                
            }
        }
    }
}

