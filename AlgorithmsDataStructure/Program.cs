using AlgorithmsDataStructure.ADT;
using AlgorithmsDataStructure.Questions;
using AlgorithmsDataStructure.Stack;
using System.Collections;

Schools aru = new Schools();
//Stack values = new Stack();


// ARRAY INSERTIONS
// Insert at the end of array
int[] numbersArr = new int[6];
//int length = 0;

//for (int index = 0; index < numbersArr.Length; index++)
//{
//    numbersArr[index] = index + 2;
//    length = index;
//}

//// Insert number 20 at end of the array (i.e index 5, which is the last item in the list)
//numbersArr[length] = 20;
//Console.WriteLine(numbersArr[length]);


// Insert at the start of array
int lengthCount = 0;
// Insert number 12 at start of the array (i.e index 0, which is the first item in the list)
numbersArr[lengthCount] = 12;
Console.WriteLine(numbersArr[lengthCount]);

for (int index = 1; index < numbersArr.Length; index++)
{
    numbersArr[index] = index + 2;
}


//var myList = new LinkedList<int>();
//myList.AddLast(10);
//myList.AddLast(20);
//myList.AddLast(30);
////myList.Display(); // Output: 10 20 30


// Creating an List<T> of Integers
List<int> firstlist = new List<int>();

// Adding elements to List
firstlist.Add(1);
firstlist.Add(2);
firstlist.Add(3);
firstlist.Add(4);
firstlist.Add(5);
firstlist.Add(6);
firstlist.Add(7);

// Checking whether 4 is present
// in List or not
//Console.Write(firstlist.Contains(4));

// STACK - words manipulation
// Test cases
WordMachine wordMachine = new WordMachine();
//Console.WriteLine(wordMachine.solution(""));
//Console.WriteLine(wordMachine.solution("4 5 6 - 7 +")); // Expected output: 8
//Console.WriteLine(wordMachine.solution("13 DUP 4 POP 5 DUP + DUP + -")); // Expected output: 7
//Console.WriteLine(wordMachine.solution("5 6 + -")); // Expected output: -1
//Console.WriteLine(wordMachine.solution("3 DUP 5 - -")); // Expected output: -1
//Console.WriteLine(wordMachine.solution("1048575 DUP +")); // Expected output: -1


// QUEUE - shopping client
//Console.WriteLine(wordMachine.GroceryClients([1, 1, 0, 0, 1]));

//// STACK - string of multiple types
//Console.WriteLine(wordMachine.StringOfMultipleTypes("[]"));
//Console.WriteLine(wordMachine.StringOfMultipleTypes("[][]{}()"));
//Console.WriteLine(wordMachine.StringOfMultipleTypes("[][]}{{}[)()"));


//// STACK - number of fishes
//Console.WriteLine(wordMachine.SurvivingFishes([1,4, 2, 2, 6], [0,0,1,0, 0]));


// Solving questions
ProblemSolving problemSolving = new ProblemSolving();
//problemSolving.CheckValidStringInput("");
//problemSolving.CheckValidStringInput("BOIL");
//problemSolving.CheckValidStringInput("BRAisE");
//problemSolving.CheckValidStringInput("ROAST");
problemSolving.CheckValidStringInput("BLNKEET");
problemSolving.CheckValidStringInput("BLANKETCOVER");
