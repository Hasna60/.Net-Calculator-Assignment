using System;

namespace FirstApp
{
	public class Math
	{
            double firstNum;
            double secondNum;
            double result;

            public string getMathOpreation(string mathOp)
            {
                if (!string.IsNullOrWhiteSpace(mathOp))
                {
                    switch (mathOp)
                    {
                        case "Add":
                            result = firstNum + secondNum;
                            return Convert.ToString(result);
                        case "Minus":
                            result = firstNum - secondNum;
                            return Convert.ToString(result);
                        case "Divide":
                            result = firstNum / secondNum;
                            return Convert.ToString(result);
                        case "Multiply":
                            result = firstNum * secondNum;
                            return Convert.ToString(result);
                        default:
                            return "You have Entered invalid value";
                    }
                }
                else
                    return "Please try again later :(";
            }

        //Setter
        public void setFirstName(string fname)
        {
            this.firstNum = Convert.ToDouble(fname);
        }
        public void setSecondtName(string sname)
        {
            this.secondNum = Convert.ToDouble(sname);
        }

        //Getter
        public double getFirstName()
        {
            return this.firstNum;
        }
        public double getSecondName()
        {
            return this.secondNum;
        }
        public double getResult()
        {
            return this.result;
        }
    }
 }