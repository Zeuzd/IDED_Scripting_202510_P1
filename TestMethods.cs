using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            while (stack.Count > 0)
            {
                uint num = stack.Pop();
                if (num < 2) continue;
                if (num == 2 || num == 3) return num;
                if (num % 2 == 0) continue;

                bool isPrime = true;
                for (uint i = 3; i * i <= num; i += 2)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) return num;
            }
            return 0; 
        }


        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            Stack<uint> tempStack = new Stack<uint>(); 
            bool primeFound = false;

            while (stack.Count > 0)
            {
                uint num = stack.Pop();

                if (!primeFound && num >= 2)
                {
                    bool isPrime = true;
                    if (num == 2 || num == 3) isPrime = true;
                    else if (num % 2 == 0) isPrime = false;
                    else
                    {
                        for (uint i = 3; i * i <= num; i += 2)
                        {
                            if (num % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }

                    
                    if (isPrime)
                    {
                        primeFound = true;
                        continue;
                    }
                }

                tempStack.Push(num);
            }

            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }

            return stack;
        }


        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            return new Queue<uint>(stack);
        }


        internal static List<uint> StackToList(Stack<uint> stack)
        {
            return new List<uint>(stack);
        }


        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {

            list.Sort();

            foreach (int item in list)
            {
                if (item == value)
                {
                    return true;
                }
                
                else if (item > value)
                {
                    return false;
                }
            }

            return false;
        }

    }
}