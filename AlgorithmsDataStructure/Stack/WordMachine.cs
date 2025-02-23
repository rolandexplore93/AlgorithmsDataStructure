using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure.Stack
{
    public class WordMachine
    {
        // Receive a space-separated string input from the user
        // // empty string return an error; otherwise using split (' ') to convert and store each string an array
        // if string input contains a number, TryParse to an integer
        // 
        public int solution(string S)
        {
            // Define the maximum value for the 20-bit unsigned integer
            const int MAX_VALUE = (1 << 20) - 1;

            if (string.IsNullOrEmpty(S)) return -1;

            // Create an empty stack to store the integers
            Stack<int> stack = new Stack<int>();

            // Split the string from user input into an array of string
            string[] operations = S.Split(' ');

            

            try
            {
                foreach (string op in operations)
                {

                    // Check if op is a number
                    if (int.TryParse(op, out int number))
                    {
                        if (number < 0 || number > MAX_VALUE)
                            return -1;  // out of range

                        stack.Push(number);
                    }
                    else
                    {
                        switch (op)
                        {
                            case "POP":
                                if (stack.Count == 0) return -1;
                                stack.Pop();
                                break;

                            case "DUP":
                                if (stack.Count == 0) return -1;
                                stack.Push(stack.Peek());
                                break;
                            case "+":
                                if (stack.Count < 2) return -1; // Not enough for addition
                                int add1 = stack.Pop();
                                int add2 = stack.Pop();
                                long sum = (long)add1 + add2;
                                if (sum > MAX_VALUE) return -1; // Over the maximum number
                                stack.Push((int)sum);
                                break;
                            case "-":
                                if (stack.Count < 2) return -1; // Error: not enough for subtraction
                                int sub1 = stack.Pop();
                                int sub2 = stack.Pop();
                                int diff = sub1 - sub2;
                                stack.Push(diff);
                                break;
                            default:
                                return -1;
                        }
                    }
                }
            }
            catch
            {
                return -1; // unexpected error
            }

            if (stack.Count == 0)
                return -1; // Error for an empty stack

            // Return the item at the beginning of the stack without removing it
            return stack.Peek();
        }


        // QUEUE TASK
        public int GroceryClients(int[] A)
        {

            // Track the current state of the queue
            int currentQueue = 0;

            // Track the minimum no of person needed
            int minimumNeeded = 0;

            foreach (int person in A)
            {
                if (person == 0)
                {
                    currentQueue++;
                }
                else
                {
                    currentQueue--;

                    if (currentQueue < 0)
                    {
                        minimumNeeded = Math.Max(minimumNeeded, -currentQueue);
                    } 
                }
            }

            return minimumNeeded;
        }


        // TASK - String of Multiple types
        // Receive input. Input could be "", int or string. "" means it's properly nested
        // int input to be converted to string
        // all input to be stored in stack
        // 

        // Use Stack DS approach to keep track of the open brackets check with the matching close bracket
        // Receive input; if empty, then S returns 1 ; means properly nested
        // Store each opening (, {, [, in the stack and match their closing ]})respectively
        // If the stack is empty after the operation, return 1
        public int StringOfMultipleTypes(string S)
        {
            // Edge case: empty string return 1 (i.e properly nested)
            if (string.IsNullOrEmpty(S)) return 1;

            // Create a stack character type to store each character from the user input
            Stack<char> stack = new Stack<char>();

            foreach (char c in S)
            {
                // push opening brackets to stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    // if it's a closing bracket, check for it matching open bracket
                    // check if stack is not empty
                    if (stack.Count == 0) return 0; //no matching bracket

                    char top = stack.Pop();

                    if ((c == ']' && top != '[') ||
                    (c == '}' && top != '{') || (c == ')' && top != '('))
                    {
                        return 0; // no matching bracket
                    }
                }

            }
            // if stack is empty after the operation
            return stack.Count == 0 ? 1 : 0;
        }



        public int SurvivingFishes(int[] A, int[] B)
        {

            if (A.Length == 0 || B.Length == 0) return -1; // invalid parameters

            // Use Stack to track the downstream fishes
            Stack<int> downstreamStack = new Stack<int>();

            int fishesAlive = 0;

            for (int i = 0; i < A.Length; i++)
            {
                // B-direction can only be 0 or 1
                if (B[i] != 0 && B[i] != 1) return -1; // invalid direction

                if (B[i] == 1)
                {
                    // Downstream fish, add to the stack
                    downstreamStack.Push(A[i]);
                }
                else
                {
                    // Upstream fish
                    while (downstreamStack.Count > 0)
                    {
                        // Compare with the downstream fish
                        if (downstreamStack.Peek() > A[i])
                        {
                            // Upstream fish is eaten, downstream fish survives
                            break;
                        }
                        else
                        {
                            // Downstream fish is eaten, remove it
                            downstreamStack.Pop();
                        }
                    }

                    // If no downstream fish left, upstream fish survives
                    if (downstreamStack.Count == 0)
                    {
                        fishesAlive++;
                    }
                }
            }

            // Add the remaining downstream fish to the survivors
            fishesAlive += downstreamStack.Count;

            return fishesAlive;

        }
    }
}
