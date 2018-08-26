using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBAC
{
    class InfixEvaluation
    {
        public static int evaluate(String expression)
        {
            char[] tokens = expression.ToCharArray();

            // Stack for numbers: 'values' Integer Stack
            Stack values = new Stack();

            // Stack for Operators: 'ops' Character Stack
            Stack ops = new Stack();

            for (int i = 0; i < tokens.Length; i++)
            {
                // Current token is a whitespace, skip it
                if (tokens[i] == ' ')
                    continue;

                // Current token is a number, push it to stack for numbers
                if (tokens[i] >= '0' && tokens[i] <= '9')
                {
                    String sbuf = ""; //Stringbuffer
                    // There may be more than one digits in number
                    while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
                        sbuf += tokens[i++];
                    values.Push(Convert.ToInt32(sbuf));
                }

                // Current token is an opening brace, push it to 'ops'
                else if (tokens[i] == '(')
                    ops.Push(tokens[i]);

                // Closing brace encountered, solve entire brace
                else if (tokens[i] == ')')
                {
                    while (ops.Peek().ToString() != '('.ToString())
                    {
                        values.Push(applyOp(Convert.ToChar(ops.Pop()), Convert.ToInt32(values.Pop()), Convert.ToInt32(values.Pop())));
                    }
                    ops.Pop();

                }

                // Current token is an operator.
                else if (tokens[i] == '+' || tokens[i] == '-' ||
                         tokens[i] == '*' || tokens[i] == '/')
                {
                    // While top of 'ops' has same or greater precedence to current
                    // token, which is an operator. Apply operator on top of 'ops'
                    // to top two elements in values stack
                    while (!(ops.Count == 0) && hasPrecedence(tokens[i], Convert.ToChar(ops.Peek())))
                        values.Push(applyOp(Convert.ToChar(ops.Pop()), Convert.ToInt32(values.Pop()), Convert.ToInt32(values.Pop())));

                    // Push current token to 'ops'.
                    ops.Push(tokens[i]);
                }
            }

            // Entire expression has been parsed at this point, apply remaining
            // ops to remaining values
            while (!(ops.Count == 0))
                values.Push(applyOp(Convert.ToChar(ops.Pop()), Convert.ToInt32(values.Pop()), Convert.ToInt32(values.Pop())));

            // Top of 'values' contains result, return it
            return Convert.ToInt16(values.Pop());
        }

        // Returns true if 'op2' has higher or same precedence as 'op1',
        // otherwise returns false.
        public static Boolean hasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            else
                return true;
        }

        // A utility method to apply an operator 'op' on operands 'a' 
        // and 'b'. Return the result.
        public static int applyOp(char op, int b, int a)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        MessageBox.Show("Error! Are you fucking dumb that you are trying to divide this shit by 0?? Asshole!");
                        Environment.Exit(0);
                        //throw new
                        //DivideByZeroException("Cannot divide by zero");
                    }
                    
                        
                    return a / b;
            }
            return 0;
        }

        // Driver method to test above methods
        //public static void main(String[] args)
        //{
        //    Console.WriteLine(EvaluateInfix.evaluate("10 + 2 * 6"));
        //    System.out.println(EvaluateString.evaluate("100 * 2 + 12"));
        //    System.out.println(EvaluateString.evaluate("100 * ( 2 + 12 )"));
        //    System.out.println(EvaluateString.evaluate("100 * ( 2 + 12 ) / 14"));
        //}
    }
}


