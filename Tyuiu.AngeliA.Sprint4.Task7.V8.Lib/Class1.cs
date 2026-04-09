using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AngeliA.Sprint4.Task7.V8.Lib
{
    public class Class1 : ISprint4Task7V8
    {
        public int Calculate(int n, int m, string value)
        {
            if (value.Length != n * m)
            {
                throw new ArgumentException($"Длина строки ({value.Length}) не соответствует размеру матрицы {n}x{m} = {n * m}");
            }

            int sum = 0;
            int index = 0;

            // Обход всех элементов матрицы
            for (int i = 0; i < n; i++)      // строки
            {
                for (int j = 0; j < m; j++)  // столбцы
                {
                    // Преобразуем символ в цифру
                    int digit = int.Parse(value[index].ToString());

                    // Проверка на нечетность
                    if (digit % 2 != 0)
                    {
                        sum += digit;
                    }

                    index++;
                }
            }

            return sum;
        }
    }
}
