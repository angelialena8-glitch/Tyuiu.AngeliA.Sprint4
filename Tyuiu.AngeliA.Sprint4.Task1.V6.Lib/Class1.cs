using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AngeliA.Sprint4.Task1.V6.Lib
{
    public class Class1 : ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int calculate = 1;

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    calculate *= i;
                }
            }
            return calculate;
        }
    }
}
