using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using Nodes;

namespace Composite
{
    public class BinaryTree
    {
        private Node _root = null;
        public int Count { get; private set; } = 0;

        public BinaryTree() { }

        public void Add(double value)
        {
            Console.WriteLine($"Элемент {value} добавлен");

            if (_root == null)
            {
                _root = new Node(value);
                Count++;
                return;
            }

            Node current = _root;
            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(value);
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(value);
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        public void Remove(double value)
        {
            Node parent = null;
            Node current = _root;

            while(current != null && current.Value != value)
            {
                parent = current;
                if (value < current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            if (current == null)
            {
                Console.WriteLine($"Элемент {value} не найден");
                return;
            }
            if (current.Left == null && current.Right == null)
            {
                if (parent == null)
                {
                    _root = null;
                }
                else if (parent.Left == current)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            else if (current.Left == null)
            {
                if (parent == null)
                {
                    _root = current.Right;
                }
                else if (parent.Left == current)
                {
                    parent.Left = current.Right;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else if (current.Right == null)
            {
                if (parent == null)
                {
                    _root = current.Left;
                }
                else if (parent.Left == current)
                {
                    parent.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Left;
                }
            }
            else
            {
                Node parentMin = current;
                Node min = current.Right;

                while (min.Left != null)
                {
                    parentMin = min;
                    min = min.Left;
                }

                current.Value = min.Value;

                if (parentMin.Left == min)
                {
                    parentMin.Left = min.Right;
                }
                else
                {
                    parentMin.Right = min.Right;
                }
            }
            Count--;
            Console.WriteLine($"Элемент {value} удалён");
        }

        public double Min()
        {
            if (!IsEmpty())
            {
                Node current = _root;

                while(current.Left != null)
                {
                    current = current.Left;
                }

                Console.WriteLine($"Минимальный элемент = {current.Value}");
                return current.Value;
            }
            else
            {
                throw new InvalidOperationException("Дерево пусто");
            }
        }

        public double Max()
        {
            if (!IsEmpty())
            {
                Node current = _root;

                while (current.Right != null)
                {
                    current = current.Right;
                }

                Console.WriteLine($"Максимальный элемент = {current.Value}");
                return current.Value;
            }
            else
            {
                throw new InvalidOperationException("Дерево пусто");
            }
        }

        public void InOrderWalk()
        {
            if (_root != null)
            {
                Console.WriteLine("Симметричный обход дерева:");
                InOrderWalk(_root);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Обход дерева невозможно совершить, так как дерево пусто");
            }
        }

        private void InOrderWalk(Node element)
        {
            if (element != null)
            {
                InOrderWalk(element.Left);
                Console.Write(element.Value + " ");
                InOrderWalk(element.Right);
            }
        }

        private void FillArray(Node element, double[] values, ref int i)
        {
            if (element != null)
            {
                FillArray(element.Left, values, ref i);
                values[i] = element.Value;
                i++;
                FillArray(element.Right, values, ref i);
            }
        }

        public double[] GetAllValues()
        { 
            double[] values = new double[Count];
            int i = 0;
            FillArray(_root, values, ref i);
            return values;
        }

        private bool Search(double value)
        {
            if (_root == null)
            {
                return false;
            }

            Node current = _root;
            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else if (value > current.Value)
                {
                    if (current.Right == null)
                    {
                        return false;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    return true;
                }
            }
        }

        public bool Contains(double value)
        {
            if (Search(value))
            {
                Console.WriteLine($"Элемент {value} содержится в дереве");
                return true;
            }
            else
            {
                Console.WriteLine($"Элемент {value} отсутствует в дереве");
                return false;
            }
        }

        public bool IsEmpty()
        {
            return _root == null;
        }

        public void IsEmptyString()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Дерево пусто");
            }
            else
            {
                Console.WriteLine("Дерево не пусто");
            }
        }

        public void Clear()
        {
            Console.WriteLine("Дерево очищено");
            _root = null;
            Count = 0;
        }

        private int Height(Node element)
        {
            if (element == null)
            {
                return -1;
            }
            return 1 + Math.Max(Height(element.Left), Height(element.Right));
        }

        public int Height()
        {
            return Height(_root);
        }
    }
}
