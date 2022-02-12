using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableAndBST
{
    public class UC3_BST<T> where T : IComparable<T>
    {
        public T nodeData { get; set; }
        public UC3_BST<T> leftTree { get; set; }

        public UC3_BST<T> rightTree { get; set; }

        public UC3_BST(T data)
        {
            this.nodeData = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        private bool result;

        public void Insert(T item)
        {
            T CurrNodeVal = this.nodeData;
            if ((CurrNodeVal.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new UC3_BST<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                    leftCount++;
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new UC3_BST<T>(item);
                }
                else
                {
                    this.rightTree.Insert(item);
                    rightCount++;
                }
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size " + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(T element, UC3_BST<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.nodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST " + " " + node.nodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST ", node.nodeData);
            }
            if (element.CompareTo(node.nodeData) < 0)
            {
                IfExists(element, node.leftTree);
            }
            if (element.CompareTo(node.nodeData) > 0)
            {
                IfExists(element, node.rightTree);
            }

            return result;
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

    }
}