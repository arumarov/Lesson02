int[] CreateArray(int n) // создаем метод для создания массива
{
    int[] a = new int[n]; // создаем временный массив
    Random random = new Random(); //заполняем созданный массив псевдослучайными числами
    for(int i = 0; i < a.Length; i++) a[i] = random.Next(0,101);
    return a;
}

void PrintArray(int[] a) // создаем метод для вывода массива
{
    for(int i = 0; i < a.Length; i++) Console.Write(a[i]+" ");
}
Console.WriteLine();
int[] arr = CreateArray(2);
PrintArray(arr);
int p=1;
for(int i = 0; i < arr.Length; i++)
if (arr[i]%2==0 && arr[i]%10! = 0) // %2 ==0 - значит делится на 2 без остатка; arr[i]%10! = 0 - при делении не 10 не оканчивается на 0)
{
    p = p* arr[i];
}

Console.WriteLine(p);