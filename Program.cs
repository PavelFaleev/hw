//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


namespace DifferenceBetweenMaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 }; // Массив вещественных чисел

            // Нахождение максимального и минимального элементa
            double maxElement = array[0];
            double minElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
            }

            // Вычисление разницa между максимальным и минимальным элементами
            double difference = maxElement - minElement;

            // Вывод разницы
            Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
          }
     }
}
