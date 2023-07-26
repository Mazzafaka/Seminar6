// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int FindNumbers(int count){
    int positiveCount = 0;
    count = 4;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    positiveCount++;
                }
            }

            Console.WriteLine($"Количество чисел, больше 0: {positiveCount}");
    return positiveCount;
}   

int Print = 4;
FindNumbers(Print);