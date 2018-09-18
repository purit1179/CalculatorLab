using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace CPE200Lab1
{
    public class RPNCalculatorEngine : CalculatorEngine
    {
        public string Process(string str)
        {
            // your code here
            if (str.Length == 1)
            {
                return "E";
            }
            string first_operator, second_operator;
            string[] arr_string = str.Split(' ');
            Stack rpn_stack = new Stack();
            foreach (string rpn_string in arr_string)
            {
                if (isNumber(rpn_string))
                {
                    rpn_stack.Push(rpn_string);
                }
                else if (isOperator(rpn_string))
                {
                    if (rpn_stack.Count > 1)
                    {
                        first_operator = rpn_stack.Pop().ToString();
                        second_operator = rpn_stack.Pop().ToString();
                        rpn_stack.Push(calculate(rpn_string, second_operator, first_operator));
                    }
                    else
                    {
                        return "E";
                    }                                      
                }
            }
            if (rpn_stack.Count == 1)
            {
                return decimal.Parse(rpn_stack.Peek().ToString()).ToString("G29");           
            }
            return "E";
        }
    }
}
