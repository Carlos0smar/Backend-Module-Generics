// See https://aka.ms/new-console-template for more information
using Activity_20_5_2024;
using Back_Module;

Console.WriteLine("Lists");

Lists integerList = new Lists();
integerList.fillList();
integerList.removeFirstAndLast();
integerList.printList();

Console.WriteLine("Dictonary");

Dictionaries dictionaries = new Dictionaries();
dictionaries.fillDictionary();
dictionaries.printAll();   
dictionaries.updateStudent();
dictionaries.printAll();

Console.WriteLine("Queues");

Queues queue = new Queues();
queue.enqueue();
queue.printQueue();
queue.dequeue();
queue.printQueue();

Console.WriteLine("Stacks");

Stacks stack = new Stacks();
stack.initializeStack();
stack.printStack();
stack.delteFromStack();
stack.printStack();


Console.WriteLine("Combined");
Combined combined = new Combined();
combined.fillDictionary();
combined.deleteBoock();
Console.WriteLine("Write a gender");
combined.listInSpecificGender(Console.ReadLine());
combined.listGroupedByGender();