using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_pre_calc
{
    class PreFixada
    {
        public static double calcular(String input)
        {
            double total = 0.0;
            int temp1 = 0;
            int temp2 = 0;
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            Stack<Int32> stack = new Stack<Int32>();

            for (int i = 0; i < charArr.Length; i++)
            {
                switch (charArr[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        stack.Push(charArr[i] - '0');
                        break;
                    case '+':
                        temp1 = stack.Pop();
                        temp2 = stack.Pop();
                        stack.Push(temp2 + temp1);
                        break;
                    case '-':
                        temp1 = stack.Pop();
                        temp2 = stack.Pop();
                        stack.Push(temp2 - temp1);
                        break;
                    case '*':
                        temp1 = stack.Pop();
                        temp2 = stack.Pop();
                        stack.Push(temp2 * temp1);
                        break;
                    case '/':
                        temp1 = stack.Pop();
                        temp2 = stack.Pop();
                        stack.Push(temp2 / temp1);
                        break;
                }
            }
            total = stack.Pop();
            return total;
        }
    }
}
