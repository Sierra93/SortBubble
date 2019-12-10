using System;

namespace SortBubble {
    class Program {
        static void Main() {
            int[] array = new int[10];
            Random r = new Random();
            Console.WriteLine("Начальный массив: ");
            for (int i = 0; i < array.Length; i++) {
                array[i] = r.Next(1, 10);
                Console.WriteLine("Элемент [" + i + "]: " + array[i]);
            }
            Console.WriteLine("Новый массив:");
            for (int i = 0; i < array.Length; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] > array[j]) {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
                Console.WriteLine("Элемент [" + i + "]: " + array[i]);
            }
            Console.ReadKey();
        }
    }
}
