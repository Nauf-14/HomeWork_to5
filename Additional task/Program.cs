void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}
int PositiveRating(int[] array)
{
    int count = 0;  
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] % 2 == 0)
          count ++;
    }
    return count;
}
int NegativeRating(int[] array)
{
    int count = 0;    
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] % 2 != 0)      
      count ++;
    }
    return count;
}
string GoodStudent(int[] array)
{    
    for (int i = 0; i < array.Length; i++)
    {
      if (NegativeRating(array) < PositiveRating(array))
      {
           
      return "yes";
      }
      
       
    }
return "no";   
}

Console.Clear();
Console.Write("Введите кол-во дней в месяце: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четверок = {PositiveRating(array)}");
Console.WriteLine($"Количество троек = {NegativeRating(array)}");
Console.WriteLine($"Ударник: {GoodStudent(array)}");