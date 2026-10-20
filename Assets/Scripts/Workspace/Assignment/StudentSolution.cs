using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int count = stack.Count;
            int popped = stack.Pop();
            int peek = stack.Peek();
            int countAfterPeek = stack.Count;

            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            throw new NotImplementedException();
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            throw new NotImplementedException();
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            throw new NotImplementedException();
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            string result = "";

            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            return result;
        }

        public bool ASN02_StackPalindrome(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            string reversed = "";

            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            return str == reversed;
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            var stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                        return false;

                    char open = stack.Pop();

                    if ((c == ')' && open != '(') ||
                        (c == ']' && open != '[') ||
                        (c == '}' && open != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        #endregion
    }
}