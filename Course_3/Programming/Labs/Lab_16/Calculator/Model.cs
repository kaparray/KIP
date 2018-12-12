using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Model
    {
        public Double Result { get; set; } = 0;
        public Double Var1 { get; set; }
        public Double Var2 { get; set; }
        public String Binar_Operator { get; set; }
        public String Unar_Operator { get; set; }
        public String memory_box = "0";

        public void Calculate()
        {
            switch (Binar_Operator)
            {
                case "+":
                    Result = Var1 + Var2;
                    break;
                case "-":
                    Result = Var1 - Var2;
                    break;
                case "/":
                    if (Var2 == 0)
                        throw new Exception();
                    Result = Var1 / Var2;
                    break;
                case "*":
                    Result = Var1 * Var2;
                    break;
                default:
                    break;
            }
        }

        public Decimal Calculate_unar_Operator(String var)
        {
            switch (Unar_Operator)
            {
                case "1/x":
                    if (var.Equals("0"))
                        throw new Exception();
                    return (Decimal)(1 / Double.Parse(var));
                case "Sqrt":
                    if (Double.Parse(var) < 0)
                        throw new Exception();
                    return (Decimal)Math.Sqrt(Double.Parse(var));
                case "+-":
                    return Decimal.Negate((Decimal)Double.Parse(var));
                default:
                    return 0;
            }
        }

        public String Percent (String var)
        {
            return (Result * Double.Parse(var) / 100).ToString();
        }
    }
}
