using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;


//STACK

//Generates a stack of integers. 

Stack<int> Numbers = new Stack<int>();

//Generate the size of the int stack. (n) 

Console.WriteLine("How many numbers would you like to reverse?");
int n = Convert.ToInt32(Console.ReadLine());

//Loop (n) times until all number have been added to stack. 

Console.WriteLine("Enter numbers.");
while (Numbers.Count < n)
{
    int q = Convert.ToInt32(Console.ReadLine());
    Numbers.Push(q);
}   

//Loop (n) times again until all numbers in stack have been popped. Display results.

while (Numbers.Count > 0)
{
    Console.Write(Numbers.Pop() + " ");
}

Console.WriteLine();

//ARRAY
//Generate a sample array and our occurrences array.

int[] numbers = { 1, 9, 3, 4, 2, 3, 4, 7, 8, 9, 1, 3, 4, 5, 8, 7, 8, 9, 1 };
int[] occurrences = new int[1001];

// foreach loop that counts up the totals for each number. 

foreach (int p in numbers)
    {
        occurrences[p]++;
    }

//for loop that lists out the frequency of each number in the sample. If loop allows totals of 0 to be hidden.

for (int i = 0; i < occurrences.Length; i++)
{
    if (occurrences[i] != 0)
    {
        Console.WriteLine(i + " occurs " + occurrences[i] + " times");
    }
}

Console.WriteLine();

//QUEUE
//Generate a queue

Queue<int> Sequence = new Queue<int>();

//Determine the first value of the Queue (N).

Console.WriteLine("\n" + "What number would you like to begin with?");
int N = Convert.ToInt32(Console.ReadLine());
Sequence.Enqueue(N);

//Loop the sequence until 50 numbers have been added to the queue. 

for (int i = 0; i < 50; i++)
{
    int M = Sequence.Dequeue();
    Console.WriteLine(M);
    Sequence.Enqueue(M + 1);
    Sequence.Enqueue(2 * M + 1);
    Sequence.Enqueue(M + 2);
}