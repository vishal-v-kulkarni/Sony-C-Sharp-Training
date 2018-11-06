using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Example.Models
{
    public class MathOperation
    {
        public static List<MathOperation> ilist = new List<MathOperation>();
        public int num1 { set; get; }
        public string op { set; get; }
        public int num2 { set; get; }
        public int result { set; get; }

        public void FindResult()
        {
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

            }
        }

    }
}