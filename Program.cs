// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] firstArray = new string[size];
            string[] finishArray = new string[size];
 
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                string element = Console.ReadLine();
                firstArray[i] = element;
                if (element.Length <= 3)
                {
                    finishArray[i] = element;
                }
                
            }
            Console.Write("[");
            foreach (var item in firstArray)
            {
 
                Console.Write("'{0}', ", item);
                
            }
            Console.Write("] -> ");
            Console.Write("[");
            foreach (var item2 in finishArray)
            {
                if (item2 == null)
                {
 
                }
                else
                {
                    Console.Write("'{0}',", item2);
                }
            }
            Console.Write("]");
            Console.ReadKey();
 
        }
    }
