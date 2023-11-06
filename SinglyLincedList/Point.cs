using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLincedList
{
    public class Point<T>
    {
        public T Value { get; set; }

        public Point<T> NextPoint { get; set; }

        public Point(T value)
        {
            Value = value;
        }
    }
}