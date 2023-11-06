using SinglyLincedList;

var myLinkedList = new MyLinkedList<int>();

var point1 = new Point<int>(10);
var point2 = new Point<int>(12);
var point3 = new Point<int>(13);

myLinkedList.AddPoint(point1);
myLinkedList.AddPoint(point2);
myLinkedList.AddPoint(point3);

myLinkedList.Print();

myLinkedList.Remove(point1);

Console.WriteLine("After removing a point:");
myLinkedList.Print();

myLinkedList.Clear();
Console.WriteLine("After clearing the list:");
myLinkedList.Print();