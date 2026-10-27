//2. Массив для проверки алгоритмов
// int[] scores = { 60, 80, 40, 80, 90 };

//3. Сумма элементов
// int sum = 0;
// foreach (int score in scores)
// {
//  sum += score;
// }
// int SumArray(int[] numbers)
// {
//  int sum = 0;
//  foreach (int number in numbers)
//  {
//  sum += number;
//  }
//  return sum;
// }
// Console.WriteLine(SumArray(scores));

//Найдите ошибку: сумма элементов
// int sum = 0;
// int SumArray(int[] numbers){
// foreach (int number in numbers){
//     sum += number;
//     }
//     return sum;
// }
// Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));

//4. Подсчёт элементов по условию
// int CountAtLeast(int[] numbers, int limit){
//     int count = 0;
//     foreach (int number in numbers){
//         if (number >= limit){
//         count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine(CountAtLeast(scores, 50));

//Найдите ошибку: количество элементов
// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;
//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));

//5. Минимум и максимум
// int FindMax(int[] numbers)
// {
//     int max = numbers[0];
//     for (int i = 1; i < numbers.Length; i++)
//     {
//         if (numbers[i] > max)
//         {
//             max = numbers[i];
//         }
//     }
//     return max;
// }
// int FindMin(int[] numbers){
//     int min = numbers[0];
//     for (int i = 1; i < numbers.Length; i++)
//     {
//         if (numbers[i] < min)
//         {
//             min = numbers[i];
//         }
//     }
//     return min;

// }
// Console.WriteLine(FindMax(scores));
// Console.WriteLine(FindMin(scores));

//Найдите ошибку: минимум
// int FindMin(int[] numbers)
// {
//     int min = numbers[0];
//     foreach (int number in numbers)
//     {
//         if (number < min)
//         {
//             min = number;
//         }
//     }
//     return min;
// }
// Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));

//6. Линейный поиск и индекс
// int FindIndex(int[] numbers, int target)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             return i;
//         }
//     }
//     return -1;
// }
// Console.WriteLine(FindIndex(scores, 80));
// Console.WriteLine(FindIndex(scores, 100));

//Найдите ошибку: первое совпадение
// int FindIndex(int[] numbers, int target)
// {
//     int index = -1;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             index = i;
//             break;
//         }
//     }
//     return index;
// } 
// Console.WriteLine(FindIndex(scores, 80));
// Console.WriteLine(FindIndex(scores, 60));
// Console.WriteLine(FindIndex(scores, 100));

//7. Основная часть — «Анализатор результатов»
int[] scores = new int[7];
for (int i = 0; i < scores.Length; i++)
{
    Console.Write($"Результат {i + 1}: ");
    scores[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine(">>> Анализ результатов<<<");
Console.WriteLine();
Console.WriteLine($"Сумма: {SumArray(scores)}");
Console.WriteLine($"Минимум: {FindMin(scores)}");
Console.WriteLine($"Максимум: {FindMax(scores)}");
Console.WriteLine($"Результатов 50 и больше: {CountAtLeast(scores, 50)}");

Console.Write("Какой результат найти: ");
int sum = 0;
int SumArray(int[] numbers){
foreach (int number in numbers){
    sum += number;
    }
    return sum;
}
 