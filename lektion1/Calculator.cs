namespace lektion1
{
 
        class Calculator
        {
            public int FirstNumber;
            public int SecondNumber;
            public int NumberInMemory;

            public Calculator()
            {
                FirstNumber = 0;
                SecondNumber = 0;
                NumberInMemory = 0;
            }
            public override string ToString()
            {
                return "First number: " + FirstNumber + "\nSecond number: " + SecondNumber + "\nNumber in memory: " + NumberInMemory;
            }
            public int SumNumbers()
            {
                return FirstNumber + SecondNumber;
            }
            public int MultiplyNumbers()
            {
                return FirstNumber * SecondNumber;
            }
            public int SumInBetween()
            {
                int sum = 0;
                for (int i = FirstNumber; i <= SecondNumber; i++)
                {
                    sum += i;
                }
                return sum;
            }
        }
    }




