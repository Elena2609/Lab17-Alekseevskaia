//3. Сумма элементов
int SumArray(int[] numbers)
{
 int sum = 0;
 foreach (int number in numbers)
 {
 sum += number;
 }
 return sum;
}

//4. Подсчёт элементов по условию
int CountAtLeast(int[] numbers, int limit){
    int count = 0;
    foreach (int number in numbers){
        if (number >= limit){
        count++;
        }
    }
    return count;
}

//5. Минимум и максимум
int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}
int FindMin(int[] numbers){
    int min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;

}

//6. Линейный поиск и индекс
int FindIndex(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }
    return -1;
}

//7. Основная часть — «Анализатор результатов»
Console.WriteLine("Введите 7 целых результатов от 0 до 100");
int[] scores = new int[7];
for (int i = 0; i < scores.Length; i++)
{
    Console.Write($"Результат {i + 1}: ");
    scores[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

Console.WriteLine(">>> Анализ результатов<<<");

Console.WriteLine($"Сумма: {SumArray(scores)}");
Console.WriteLine($"Минимум: {FindMin(scores)}");
Console.WriteLine($"Максимум: {FindMax(scores)}");
Console.WriteLine($"Результатов 50 и больше: {CountAtLeast(scores, 50)}");


Console.WriteLine();

Console.Write("Какой результат найти: ");
int target = int.Parse(Console.ReadLine());
int index = FindIndex(scores, target);

if (index == -1){
    Console.WriteLine("Результат не найден");
} else {
    Console.Write($"Первый индекс: {index}");
}
