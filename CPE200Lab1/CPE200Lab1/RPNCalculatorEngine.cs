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
                if (isOperator(rpn_string))
                {
                    if (rpn_stack.Count > 1)
                    {
                        second_operator = rpn_stack.Pop().ToString();
                        first_operator = rpn_stack.Pop().ToString();                      
                        rpn_stack.Push(calculate(rpn_string, first_operator, second_operator));
                    }
                    else
                    {
                        return "E";
                    }                                      
                }
            }
            if (rpn_stack.Count == 1)
            {
                if (arr_string[1] == "√" || arr_string[1] == "1/x")
                {
                    string unary_num = rpn_stack.Pop().ToString();
                    rpn_stack.Push(unaryCalculate(arr_string[1], unary_num));
                }
                return decimal.Parse(rpn_stack.Peek().ToString()).ToString("G29");           
            }
            return "E";
        }
    }
}
