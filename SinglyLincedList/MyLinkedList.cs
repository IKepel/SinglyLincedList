using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLincedList
{
    public class MyLinkedList<T>
    {
        private List<Point<T>> _points = new();

        public void AddPoint(Point<T> point)
        {
            if (_points.Count == 0)
                _points.Add(point);
            else
            {
                _points.Last().NextPoint = point;
                _points.Add(point);
            }
        }

        public void Remove(Point<T> point)
        {
            _points.Remove(point);

            foreach (var p in _points)
            {
                if (p.NextPoint == point)
                {
                    p.NextPoint = point.NextPoint;
                    break;
                }
            }
        }

        public void Print()
        {
            foreach (var point in _points)
            {
                Console.WriteLine(point.Value);
            }
        }

        public void Clear()
        {
            _points.Clear();
        }
    }
}