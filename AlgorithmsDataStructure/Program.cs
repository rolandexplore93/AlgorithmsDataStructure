using AlgorithmsDataStructure.ADT;
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


var myList = new LinkedList<int>();
myList.AddLast(10);
myList.AddLast(20);
myList.AddLast(30);
//myList.Display(); // Output: 10 20 30