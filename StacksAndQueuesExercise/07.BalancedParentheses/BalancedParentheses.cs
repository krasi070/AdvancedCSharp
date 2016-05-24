namespace _07.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParentheses
    {
        public static void Main()
        {
            string parentheses = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < parentheses.Length; i++)
            {
                if (parentheses[i] == '(' || parentheses[i] == '{' || parentheses[i] == '[')
                {
                    stack.Push(parentheses[i]);
                }
                else if (stack.Count == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else if (parentheses[i] == ')')
                {
                    if (stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (parentheses[i] == ']')
                {
                    if (stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (parentheses[i] == '}')
                {
                    if (stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}