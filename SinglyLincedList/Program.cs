using SinglyLincedList;

var myLinkedList = new MyLinkedList<int>();

myLinkedList.AddPoint(new Point<int>(10));
myLinkedList.AddPoint(new Point<int>(12));
myLinkedList.AddPoint(new Point<int>(13));

myLinkedList.Print();

myLinkedList.Remove(myLinkedList.GetTail());

Console.WriteLine("After removing a point:");
myLinkedList.Print();

myLinkedList.Clear();
Console.WriteLine("After clearing the list:");
myLinkedList.Print();