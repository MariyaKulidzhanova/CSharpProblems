namespace TestTasks
{
    public class Brackets
    {
        private char[] inputArray;

        public Brackets(string str)
        {
            inputArray = str.ToCharArray();
        }

        int bracketCount = 0;

        public bool CountBrackets()
        {
            foreach (char i in inputArray)
            {
                switch (i)
                {
                    case '(': bracketCount++; break;
                    case ')': bracketCount--; break;
                }
                if (bracketCount < 0) break;
            }
            if (bracketCount != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
