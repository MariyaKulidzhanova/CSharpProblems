using System;

namespace TestTasks
{
    public class RomanNumbers
    {
        private string romanString;
        public RomanNumbers(string str)
        {
            romanString = str.ToUpper();
        }

        int intNum = 0;
        public int RomanToInt(){
            foreach(var i in romanString)
            {
                switch (i)
                {
                    case 'I':
                        {
                            intNum += 1; break;
                        }
                    case 'V':
                        {
                            intNum += 5; break;
                        }
                    case 'X':
                        {
                            intNum += 10; break;
                        }
                    case 'L':
                        {
                            intNum += 50; break;
                        }
                    case 'C':
                        {
                            intNum += 100; break;
                        }
                    case 'D':
                        {
                            intNum += 500; break;
                        }
                    case 'M':
                        {
                            intNum += 1000; break;
                        }
                    default:
                        {
                            throw new ArgumentException("Invalid character");
                        }
                }
            }

            if (romanString.Contains("IV") || romanString.Contains("IX"))
                intNum -= 2;

            if (romanString.Contains("XL") || romanString.Contains("XC"))
                intNum -= 20;

            if (romanString.Contains("CD") || romanString.Contains("CM"))
                intNum -= 200;

            return intNum;
        }

    }
}
