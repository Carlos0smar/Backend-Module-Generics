//// See https://aka.ms/new-console-template for more information
//using Activity_20_5_2024;
//using Back_Module;

using SimpleTextProcessingApplication;

Console.WriteLine("Third activity");

string textFile = @"D:\UNIVERSIDAD\Formación_Desarrollo_De_Software\6_Backend\code\SimpleTextProcessingApplication\SimpleTextProcessingApplication\TestFile.txt";

string text = textFile.readText();

TextProcessor processor = new TextProcessor(text);

processor.ProcessText(text);

//Console.WriteLine("Lists");

//Lists integerList = new Lists();
//integerList.fillList();
//integerList.removeFirstAndLast();
//integerList.printList();

//Console.WriteLine("Dictonary");

//Dictionaries dictionaries = new Dictionaries();
//dictionaries.fillDictionary();
//dictionaries.printAll();   
//dictionaries.updateStudent();
//dictionaries.printAll();

//Console.WriteLine("Queues");

//Queues queue = new Queues();
//queue.enqueue();
//queue.printQueue();
//queue.dequeue();
//queue.printQueue();

//Console.WriteLine("Stacks");

//Stacks stack = new Stacks();
//stack.initializeStack();
//stack.printStack();
//stack.delteFromStack();
//stack.printStack();


//Console.WriteLine("Combined");
//Combined combined = new Combined();
//combined.fillDictionary();
//combined.deleteBoock();
//Console.WriteLine("Write a gender");
//combined.listInSpecificGender(Console.ReadLine());
//combined.listGroupedByGender();



//int Add(int a, int b)
//{
//    Console.WriteLine(a + b);
//    return a + b;
//}

//int Subtract(int a, int b)
//{
//    Console.WriteLine(a - b);
//    return a - b;
//}

//MathOperation addOperation = Add;
//MathOperation substractOperation = Subtract;

////Console.WriteLine(addOperation(10, 11));

//MathOperation MulticasDelegate = addOperation + substractOperation;

//int resul = MulticasDelegate(14, 12);


////Console.Write(resul);


//public delegate int MathOperation(int a, int b);


// Second Activity


//int Add(int a, int b)
//{
//    Console.WriteLine(a + b);
//    return a + b;
//}

//int Subtract(int a, int b)
//{
//    Console.WriteLine(a - b);
//    return a - b;
//}

//MathOperation addOperation = Add;
//MathOperation substractOperation = Subtract;

////Console.WriteLine(addOperation(10, 11));

//MathOperation MulticasDelegate = addOperation + substractOperation;

//int resul = MulticasDelegate(14, 12);


////Console.Write(resul);


//public delegate int MathOperation(int a, int b);

