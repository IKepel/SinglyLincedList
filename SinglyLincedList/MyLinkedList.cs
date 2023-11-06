using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLincedList
{
    public class MyLinkedList<T>
    {
        private Point<T> _head;

        private Point<T> _tail;

        public void AddPoint(Point<T> point)
        {
            if (_head == null)
            {
                _head = point;
                _tail = point;
            }
            else
            {
                _tail.NextPoint = point;
                _tail = point;
            }
        }

        public void Remove(Point<T> point)
        {
            if (_head == null)
                return;

            if (_head == point)
            {
                _head = _head.NextPoint;
                if (_head == null)
                    _tail = null;
            }
            else
            {
                Point<T> current = _head;
                while (current.NextPoint != null)
                {
                    if (current.NextPoint == point)
                    {
                        current.NextPoint = point.NextPoint;
                        if (point == _tail)
                            _tail = current;
                        break;
                    }
                    current = current.NextPoint;
                }
            }
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
        }

        public void Print()
        {
            Point<T> current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.NextPoint;
            }
        }

        public Point<T> GetHead()
        {
            return _head;
        }

        public Point<T> GetTail()
        {
            return _tail;
        }
    }
}