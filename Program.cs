using System;
using System.Collections.Generic;

    class Program
    {
        static Boolean hasMatchingParentheses(string s)
        {
            int leftBracketCount = 0;
            int rightBracketCount = 0;

            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    leftBracketCount++;
                }
                else if (s[i] == ')')
                {
                    rightBracketCount++;
                }
            }

            if (leftBracketCount == rightBracketCount)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(hasMatchingParentheses("((hello()))"));
            Console.WriteLine(hasMatchingParentheses("()(hello())"));
            Console.WriteLine(hasMatchingParentheses("((hello))"));
            Console.WriteLine(hasMatchingParentheses("(hello)"));

            Console.WriteLine();

            Console.WriteLine(hasMatchingParentheses("(hello("));
            Console.WriteLine(hasMatchingParentheses(")hello)"));
            Console.WriteLine(hasMatchingParentheses(")hello("));
            Console.WriteLine(hasMatchingParentheses("hello(("));
            Console.WriteLine(hasMatchingParentheses("(hello"));
            Console.WriteLine(hasMatchingParentheses("((hello)"));
        }
    }
