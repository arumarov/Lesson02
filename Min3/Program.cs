// Нужно найти минимальное из 3-х чисел
int min (int a, int b, int c) // пишем функцию min - нахождение минимального числа
{
       int result = a;
       if (b < result) result = b;
       if (c < result) result = c;
       return result;
    
}

Console.WriteLine(min (12, 5, 88));  // обращаемся к подпрограмме min
