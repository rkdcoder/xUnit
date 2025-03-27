namespace Calculations
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Add(decimal a, decimal b)
        {
            return Math.Round(a + b, 2); // returning result rounding by 2 decimal places
        }
    }
}
